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


        #region -------- FIELDS --------

        Thread captureThread = null;
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

        // Dictionary to hold fingerprint templates in memory
        private Dictionary<string, string> fingerprintTemplates = new Dictionary<string, string>();
        public static string fingerID;

        #endregion


        // Constructor for the RegisterForm class, initializes components and sets up the form.
        public RegisterForm()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            lblStatusLabel.Visible = false;
            gbxFingers.Enabled = false;
            lblFingerPrintCount.Visible = false;
            gbxFingerPrintStatus.Enabled = false;
            btnStartReg.Enabled = false;
            FormHandle = this.Handle;

            gpxGeneratedPID.Enabled = false;

        }

        // Handles the connection process to the fingerprint device and initializes necessary parameters.
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
                   
                    MessageBox.Show($"Unable to connect with the device! (Return Code: {openDeviceCallBackCode}", "No Device connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                btnStartReg.Enabled = true;
                gpxGeneratedPID.Enabled = true;
                bIsTimeToDie = false;



                // Connected Successfully
                MessageBox.Show("Fingerprint Device Connected Successfully!", "Device Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Unable to initialize the device. Unalble to load the algorithms! Please Connect the device", "No Device connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //home.toolStripStatusLabelMessage.Text = "$\"Unable to initialize the device. Unable to load the algorithms! Please Connect the device\"";
                //home.toolStripStatusLabelMessage.BackColor = Color.FromArgb(230, 112, 134);
            }

        }

        // Continuously captures fingerprints from the connected device in a background thread.
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

        // Sends a Windows message from the unmanaged code to the specified window handle.
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);


        // Starts the fingerprint registration process, prompting the user to press their finger multiple times.
        private void btnCaptuerFP_Click(object sender, EventArgs e)
        {
            if (!IsRegister)
            {
                ClearImage();
                ClearDeviceUser();
                IsRegister = true;
                RegisterCount = 0;
                regTempLen = 0;
                lblFingerPrintCount.Visible = true;
                lblStatusLabel.Visible = true;
                lblStatusLabel.Text = "Please press your finger " + REGISTER_FINGER_COUNT + " times to register";
                lblStatusLabel.BackColor = Color.LightGreen;
                lblFingerPrintCount.Visible = true;
                lblFingerPrintCount.Text = REGISTER_FINGER_COUNT.ToString();
            }
        }

        // Handles Windows messages, including the captured fingerprint data, and manages the registration and verification logic.
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

                        // Check if the dictionary (fingerprintTemplates[fingerID]) key are exist, if exist, compare the value with the captured template, and if exit show the message fingered is already registered. 
                        if (fingerprintTemplates.Count > 0)
                        {
                            // Loop through all entries in the dictionary to compare the captured fingerprint with stored fingerprints
                            foreach (var kvp in fingerprintTemplates)
                            {
                                // Retrieve the stored template and convert it from Base64
                                string storedTemplateBase64 = kvp.Value;
                                byte[] storedTemplate = Convert.FromBase64String(storedTemplateBase64);

                                // Compare the stored template with the captured template
                                int compareResult = fpInstance.Match(CapTmp, storedTemplate);
                                if (compareResult > 0)
                                {
                                    // Show a message indicating that the fingerprint is already registered
                                    MessageBox.Show($"This fingerprint is already registered for {kvp.Key}", "Duplicate Fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }




                        //if (zkfp.ZKFP_ERR_OK == ret)
                        //{
                        //    int deleteCode = fpInstance.DelRegTemplate(fid);   // <---- REMOVE FINGERPRINT
                        //    if (deleteCode != zkfp.ZKFP_ERR_OK)
                        //    {
                        //        MessageBox.Show("CurrentFingerAlreadyRegistered" + fid);
                        //        return;
                        //    }
                        //}


                        if (RegisterCount > 0 && fpInstance.Match(CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                        {
                            lblStatusLabel.BackColor = Color.Tomato;
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

                                    // Register the finger with its ID (e.g., "R1") and the generated template
                                    RegisterFinger(fingerID, fingerPrintTemplate);  // Replace "R1" with the appropriate finger ID

                                    lblStatusLabel.BackColor = Color.LightGreen;
                                    lblStatusLabel.Text = "Enroll Successfull";

                                    DisconnectFingerPrintCounter();
                                } else
                                {
                                    lblStatusLabel.BackColor = Color.Tomato;
                                    lblStatusLabel.Text = "Failed to add template";
                                }
                                    

                            } else
                            {
                                lblStatusLabel.BackColor = Color.Tomato;
                                lblStatusLabel.Text = "Unable to Enroll Current User";
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

        // Displays the captured fingerprint image on the form.
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


        // Converts a byte array to a Bitmap object based on the provided width and height.
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


        // Clears the displayed fingerprint image from the form.
        private void ClearImage()
        {
            picFPImg.Image = null;
            //pbxImage2.Image = null;
        }

        public void ClearDeviceUser()
        {
            try
            {
                int deleteCode = fpInstance.DelRegTemplate(iFid);   // <---- REMOVE FINGERPRINT
                if (deleteCode != zkfp.ZKFP_ERR_OK)
                {
                    //DisplayMessage(MessageManager.msg_FP_UnableToDeleteFingerPrint + iFid, false);
                }
                iFid = 1;
            }
            catch { }

        }

        // Generates a fingerprint template from the registered fingerprints.
        private int GenerateRegisteredFingerPrint()
        {
            return fpInstance.GenerateRegTemplate(RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref regTempLen);
        }

        // Adds the generated fingerprint template to the device's memory.
        private int AddTemplateToMemory()
        {
            return fpInstance.AddRegTemplate(iFid, RegTmp);
        }

        // Resets the fingerprint registration counter and hides the counter display.
        private void DisconnectFingerPrintCounter()
        {
            lblFingerPrintCount.Text = REGISTER_FINGER_COUNT.ToString();
            lblFingerPrintCount.Visible = false;
        }

        // Handles the disconnection process from the fingerprint device, stopping any ongoing capture.
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
                    lblFingerPrintCount.Visible = false;
                    lblStatusLabel.Visible = false;

                    gbxFingerPrintStatus.Enabled = false;
                    gbxPatientFP.Enabled = false;
                    gpxGeneratedPID.Enabled = false;
                    btnStartReg.Enabled = false;

                    //tbcPatientInfo.Visible = false;
                    //toolStripStatusLabel1.Text = "Please click the 'CONNECT' button to connect the device.";
                    //toolStripStatusLabel1.BackColor = Color.FromArgb(230, 112, 134);
                }
            }
        }

        #region ------------ Multiple Fingers registration __________________

        // Method to register a fingerprint template
        private void RegisterFinger(string fingerID, string template)
        {
            // Store the template in the dictionary
            fingerprintTemplates[fingerID] = template;

            // Change the corresponding button's color to yellow to indicate registration
            switch (fingerID)
            {
                case "RT":
                    btnRT.BackColor = Color.Yellow;
                    break;
                case "RI":
                    btnRI.BackColor = Color.Yellow;
                    break;
                case "RM":
                    btnRM.BackColor = Color.Yellow;
                    break;
                case "RR":
                    btnRR.BackColor = Color.Yellow;
                    break;
                case "RP":
                    btnRP.BackColor = Color.Yellow;
                    break;
                case "LT":
                    btnLT.BackColor = Color.Yellow;
                    break;
                case "LI":
                    btnLI.BackColor = Color.Yellow;
                    break;
                case "LM":
                    btnLM.BackColor = Color.Yellow;
                    break;
                case "LR":
                    btnLR.BackColor = Color.Yellow;
                    break;
                case "LP":
                    btnLP.BackColor = Color.Yellow;
                    break;
                // Add cases for other fingers as needed
                default:
                    break;
            }

            // Update the UI or status (for demonstration purposes, just print to console)
            //MessageBox.Show($"{fingerID} registered with template: {template}");
        }

        // Triggers the fingerprint capture process using a button click.
        private void BtnRT_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "RT"; // Right Thumb

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }


        // Triggers the fingerprint capture process using a button click 
        private void BtnRI_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "RI"; // Right Index

            // Start the registration process
            btnCaptuerFP_Click(sender, e);

        }


        private void BtnRM_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "RM"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnRR_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "RR"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnRP_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "RP"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnLT_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "LT"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnLI_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "LI"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnLM_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "LM"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnLR_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "LR"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        private void BtnLP_Click(object sender, EventArgs e)
        {
            // Set the finger ID for the upcoming registration
            fingerID = "LP"; // Right Middle

            // Start the registration process
            btnCaptuerFP_Click(sender, e);
        }

        #endregion


        #region ----------- Button UI --------------------
        private void BtnConnect_MouseMove(object sender, MouseEventArgs e)
        {
            btnConnect.BackColor = Color.White;
        }

        private void BtnConnect_MouseLeave(object sender, EventArgs e)
        {
            btnConnect.BackColor = Color.LightGreen;
        }

        private void BtnDisconnect_MouseMove(object sender, MouseEventArgs e)
        {
            btnDisconnect.BackColor = Color.White;
        }

        private void BtnDisconnect_MouseLeave(object sender, EventArgs e)
        {
            btnDisconnect.BackColor = Color.Tomato;
        }
















        #endregion

        private void BtnStartReg_Click(object sender, EventArgs e)
        {
            gbxFingers.Enabled = true;
            gbxFingerPrintStatus.Enabled = true;
        }
    }
}
