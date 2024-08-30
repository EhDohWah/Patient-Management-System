using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libzkfpcsharp;
using project_practice_3.MVC_Controller;
using project_practice_3.MVC_View.Register;

namespace project_practice_3.MVC_View.Register
{
    public partial class RegisterForm : Form
    {
        Thread captureThread = null;

        #region -------- FIELDS --------

        const int REGISTER_FINGER_COUNT = 3;

        zkfp fpInstance = new zkfp();
        IntPtr FormHandle = IntPtr.Zero; // To hold the handle of the form
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        byte[] FPBuffer;   // Image Buffer
        int RegisterCount = 0;

        byte[][] RegTmps = new byte[3][];

        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        int regTempLen = 0;
        int iFid = 1;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        private int mfpWidth = 0;
        private int mfpHeight = 0;
        int selectedDeviceIndex;

        #endregion



        public RegisterForm()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            lblStatusLabel.Visible = false;
            FormHandle = this.Handle;
            
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            int callBackCode = fpInstance.Initialize();
            if (callBackCode == zkfp.ZKFP_ERR_OK)
            {
                int nCount = fpInstance.GetDeviceCount();
                if (nCount > 0)
                {
                    // Assuming you want to connect to the first available device automatically
                    selectedDeviceIndex = 0;
                }
                else
                {
                    int finalizeCount = fpInstance.Finalize();
                    MessageBox.Show("No device available.");
                    return;
                }

                // Connect to the fingerprint device
                int openDeviceCallBackCode = fpInstance.OpenDevice(selectedDeviceIndex);
                if (zkfp.ZKFP_ERR_OK != openDeviceCallBackCode)
                {
                    MessageBox.Show($"Unable to connect with the device! (Return Code: {openDeviceCallBackCode} )");
                    return;
                }

                RegisterCount = 0;
                regTempLen = 0;
                iFid = 1;

                for (int i = 0; i < REGISTER_FINGER_COUNT; i++)
                {
                    RegTmps[i] = new byte[2048];
                }

                byte[] paramValue = new byte[4];


                // Retrieve the fingerprint image width 
                int size = 4;
                fpInstance.GetParameters(1, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

                // Retrieve the fingerprint image height
                size = 4;
                fpInstance.GetParameters(2, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

                FPBuffer = new byte[mfpWidth * mfpHeight];


                // Create a thread to retrieve any new fingerprint and handle device events
                captureThread = new Thread(new ThreadStart(DoCapture));
                captureThread.IsBackground = true;
                captureThread.Start();

                bIsTimeToDie = false;

                

                // Connected Successfully
                MessageBox.Show("Fingerprint Device Connected Successfully!");
                //toolStripStatusLabel1.Text = "The device is successfully connected";
                //toolStripStatusLabel1.BackColor = Color.FromArgb(79, 208, 154);

                

                string devSN = fpInstance.devSn;
                tbxDeviceInfo.Text = devSN;
                lblConnectionStatus.Text = "Connected!";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            
            }
            else
            {

                MessageBox.Show($"Unable to initialize the device. Unable to load the algorithms! Please Connect the device");
                //home.toolStripStatusLabelMessage.Text = "$\"Unable to initialize the device. Unable to load the algorithms! Please Connect the device\"";
                //home.toolStripStatusLabelMessage.BackColor = Color.FromArgb(230, 112, 134);
            }

        }

        private void DoCapture()
        {
            try
            {
                while (!bIsTimeToDie)
                {
                    cbCapTmp = 2048;
                    int ret = fpInstance.AcquireFingerprint(FPBuffer, CapTmp, ref cbCapTmp);

                    if (ret == zkfp.ZKFP_ERR_OK)
                    {
                        //if (RegisterCount == 0)
                        //    btnEnroll.Invoke((Action)delegate
                        //    {
                        //        btnEnroll.Enabled = true;
                        //    });
                        SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                    }
                    Thread.Sleep(100);
                }
            }
            catch { }

        }

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        
        private void btnCaptuerFP_Click(object sender, EventArgs e)
        {
            if (!IsRegister)
            {
                ClearImage();
                IsRegister = true;
                RegisterCount = 0;
                regTempLen = 0;
                lblStatusLabel.Visible = true;
                lblStatusLabel.Text = "Please press your finger " + REGISTER_FINGER_COUNT + " times to register";
                lblStatusLabel.BackColor = Color.LightGreen;
                lblFingerPrintCount.Visible = true;
                lblFingerPrintCount.Text = REGISTER_FINGER_COUNT.ToString();
            }
        }

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    // All your registration and verification code needs to be handled here

                    DisplayFingerPrintImage();

                    if (IsRegister)
                    {
                        // Code to be executed in case of registration
                        #region -------- IF REGISTERED FINGERPRINT --------

                        int ret = zkfp.ZKFP_ERR_OK;
                        int fid = 0, score = 0;
                        ret = fpInstance.Identify(CapTmp, ref fid, ref score);
                        if (RegisterCount > 0 && fpInstance.Match(CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                        {
                            lblStatusLabel.Text = "Please press the same finger " + REGISTER_FINGER_COUNT + " times for enrollment";

                            return;
                        }
                        Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);

                        RegisterCount++;
                        if (RegisterCount >= REGISTER_FINGER_COUNT)
                        {

                            RegisterCount = 0;
                            ret = GenerateRegisteredFingerPrint();   // <--- GENERATE FINGERPRINT TEMPLATE



                            if (zkfp.ZKFP_ERR_OK == ret)
                            {

                                ret = AddTemplateToMemory();        //  <--- LOAD TEMPLATE TO MEMORY
                                if (zkfp.ZKFP_ERR_OK == ret)         // <--- ENROLL SUCCESSFULL
                                {
                                    string fingerPrintTemplate = string.Empty;
                                    zkfp.Blob2Base64String(RegTmp, regTempLen, ref fingerPrintTemplate);
                                    // GET THE TEMPLATE HERE : fingerPrintTemplate
                                    //tbxIDcard.Text = GenerateIDCard(fingerPrintTemplate);
                                    //tbxFPid.Text = fingerPrintTemplate;

                                    lblStatusLabel.Text = fingerPrintTemplate;

                                    DisconnectFingerPrintCounter();
                                }
                                else
                                    lblStatusLabel.Text = "Failed to add template";

                            }


                            IsRegister = false;
                            return;
                        }
                        else
                        {
                            int remainingCont = REGISTER_FINGER_COUNT - RegisterCount;
                            lblFingerPrintCount.Text = remainingCont.ToString();
                            string message = "Please provide your fingerprint " + remainingCont + " more time(s)";

                            lblStatusLabel.Text = message;

                        }
                        #endregion
                        // Checkout the 'Registration Case' explained below
                    }
                    else
                    {
                        // Code to be executed in case of fingerprint verification 
                        // and any random fingerprint 
                        // Checkout the 'Identification and Match' case explained below 
                    }

                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }


        public void DisplayFingerPrintImage()
        {
            //Bitmap fingerPrintImage = GetImage(FPBuffer, fpInstance.imageWidth, fpInstance.imageHeight);
            //Rectangle cropRect = new Rectangle(0, 0, picFPImg.Width / 2, picFPImg.Height / 2);
            //Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            //using (Graphics g = Graphics.FromImage(target))
            //{
            //    g.DrawImage(fingerPrintImage, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            //}
            //this.picFPImg.Image = target;

            // OPTIMIZED METHOD
            MemoryStream ms = new MemoryStream();
            BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
            Bitmap bmp = new Bitmap(ms);
            this.picFPImg.Image = bmp;
        }


        public static Bitmap GetImage(byte[] buffer, int width, int height)
        {
            Bitmap output = new Bitmap(width, height);
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = output.LockBits(rect, ImageLockMode.ReadWrite, output.PixelFormat);
            IntPtr ptr = bmpData.Scan0;

            Marshal.Copy(buffer, 0, ptr, buffer.Length);
            output.UnlockBits(bmpData);

            return output;
        }


        private void ClearImage()
        {
            picFPImg.Image = null;
            //pbxImage2.Image = null;
        }


        private int GenerateRegisteredFingerPrint()
        {
            return fpInstance.GenerateRegTemplate(RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref regTempLen);
        }

        private int AddTemplateToMemory()
        {
            return fpInstance.AddRegTemplate(iFid, RegTmp);
        }

        private void DisconnectFingerPrintCounter()
        {
            lblFingerPrintCount.Text = REGISTER_FINGER_COUNT.ToString();
            lblFingerPrintCount.Visible = false;
        }




        #region ----------- Button UI --------------------
        private void BtnConnect_MouseMove(object sender, MouseEventArgs e)
        {
          btnConnect.BackColor = Color.White;
        }

        private void BtnConnect_MouseLeave(object sender, EventArgs e)
        {
            btnConnect.BackColor= Color.LightGreen;
        }

        #endregion

        private void BtnRT_Click(object sender, EventArgs e)
        {
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnDisconnect_MouseMove(object sender, MouseEventArgs e)
        {
            btnDisconnect.BackColor = Color.White;
        }

        private void BtnDisconnect_MouseLeave(object sender, EventArgs e)
        {
            btnDisconnect.BackColor = Color.Tomato;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            int result = fpInstance.CloseDevice();  // Close the connection
            bIsTimeToDie = true;
            RegisterCount = 0;
            
            if (captureThread == null || !captureThread.IsAlive)
            {
                // Show "connect to the device"
                MessageBox.Show("Connect to the device.");
            }
            else
            {
                // If captureThread is running, abort it
                captureThread.Abort();
            }

            if (result == zkfp.ZKFP_ERR_OK)
            {
                result = fpInstance.Finalize();   // Clear the resources
                if (result == zkfp.ZKFP_ERR_OK)
                {
                    // Reset any variables and data if necessary
                    ClearImage();

                    btnDisconnect.Enabled = false;
                    btnConnect.Enabled = true;
                    lblConnectionStatus.Text = "Disconnect!";
                    tbxDeviceInfo.Text = "";
                    //tbcPatientInfo.Visible = false;
                    //toolStripStatusLabel1.Text = "Please click the 'CONNECT' button to connect the device.";
                    //toolStripStatusLabel1.BackColor = Color.FromArgb(230, 112, 134);
                }
            }
        }
    }
}
