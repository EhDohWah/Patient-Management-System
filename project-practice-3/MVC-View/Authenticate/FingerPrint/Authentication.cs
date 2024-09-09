using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libzkfpcsharp;
using project_practice_3.MVC_Controller;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Security.Cryptography;
using System.Messaging;

namespace project_practice_3.MVC_View.Authenticate.FingerPrint
{
    public partial class FingerPrint_Authentication : Form
    {
        #region -------- FIELDS --------

        Thread captureThread = null;
        CancellationTokenSource _cancellationTokenSource;

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

        // Dictionary to hold fingerprint templates in memory
        private Dictionary<string, string> fingerprintTemplates = new Dictionary<string, string>();
        public static string fingerID;
        public static string generatedPID;

        public static byte[] dbString = new byte[2048];

        DatabaseConnection _context = new DatabaseConnection();

        public static string fingerName;


        public FingerPrint_Authentication()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            tclFingerPrintControl.Enabled = false;
            gbxAuthFingerPrint.Enabled = false;
            gbxAuthPID.Enabled = false;
            FormHandle = this.Handle;
            
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
                bIsTimeToDie = false;

                // Create a thread to retrieve any new fingerprint and handle device events
                captureThread = new Thread(new ThreadStart(DoCapture));
                captureThread.IsBackground = true;
                captureThread.Start();
                            

                // Connected Successfully
                MessageBox.Show("Fingerprint Device Connected Successfully!", "Device Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //toolStripStatusLabel1.Text = "The device is successfully connected";
                //toolStripStatusLabel1.BackColor = Color.FromArgb(79, 208, 154);

                string devSN = fpInstance.devSn;

                // Resetting UI 
                tbxDeviceInfo.Text = devSN;
                lblConnectionStatus.Text = "Connected!";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;

                gbxPatientFP.Enabled = true;
                gbxAuthPID.Enabled = true;
                gbxAuthFingerPrint.Enabled = true;







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

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    // All your registration and verification code needs to be handled here
                    
                    // Reset all bottoms colors.
                    ResetBtnColor();
                    DisplayFingerPrintImage();
                    
                    if (bIdentify)
                    {

                        MatchFingerprintAsync();                    

                    }

                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        // Fingerprint Duplication Check.
        private async Task MatchFingerprintAsync()
        {
            try
            {
                using (var context = new DatabaseConnection()) // Replace with your actual DbContext class
                {
                    // Fetch all fingerprints along with associated patient information
                    var fingerprints = await context.Finger_Print_Data
                        .Include(fp => fp.Patient) // Ensure navigation property is set up
                        .ToListAsync();

                    foreach (var fingerprint in fingerprints)
                    {
                        // Convert the stored Base64 fingerprint string to byte array
                        byte[] dbBlob = zkfp.Base64String2Blob(fingerprint.FingerPrintID);
                        fpInstance.AddRegTemplate(1, dbBlob); // '1' is a temporary template ID

                        // Perform the fingerprint matching
                        int ret = fpInstance.Match(CapTmp, dbBlob);

                        if (ret > 0)
                        {
                            // Match found; retrieve the associated PID
                            string matchedPID = fingerprint.PID;

                            // Retrieve all fingerprints for the matched PID
                            var matchedFingerprints = fingerprints
                                .Where(fp => fp.PID == matchedPID)
                                .ToList();

                            // Dictionary to map finger names to corresponding buttons
                            var fingerButtonMapping = new Dictionary<string, Button>
                            {
                                { "RT", btnRT },
                                { "RI", btnRI },
                                { "RM", btnRM },
                                { "RR", btnRR },
                                { "RP", btnRP },
                                { "LT", btnLT },
                                { "LI", btnLI },
                                { "LM", btnLM },
                                { "LR", btnLR },
                                { "LP", btnLP }
                            };

                            // Highlight the buttons based on the registered fingerprints for the matched PID
                            foreach (var matchedFingerprint in matchedFingerprints)
                            {
                                if (fingerButtonMapping.TryGetValue(matchedFingerprint.FingerName, out Button button))
                                {
                                    button.BackColor = Color.Yellow;
                                }
                            }


                            // Match found; retrieve the associated PID and Patient details

                            string patientName = fingerprint.Patient?.FullName ?? "Unknown";

                            // Construct the message
                            string message = $"The fingerprint is registered to PID: {matchedPID}.\n" +
                                             $"Patient Name: {patientName}.\n" +
                                             "Would you like to proceed to the next window to update the patient's information?";

                            // Display the message box with Yes, No, and Cancel buttons
                            DialogResult result = MessageBox.Show(message,
                                                                  "Fingerprint Found",
                                                                  MessageBoxButtons.YesNoCancel,
                                                                  MessageBoxIcon.Question);

                            // Handle the user's response
                            if (result == DialogResult.Yes)
                            {
                                // Logic to proceed to the update window
                                // Replace with your actual update method
                                UpdatePatientFormDetail npfd = new UpdatePatientFormDetail(matchedPID);
                                npfd.ShowDialog();
                                removeFPColors();
                            }
                            else if (result == DialogResult.No)
                            {
                                removeFPColors();
                                MessageBox.Show("You have chosen not to update the patient's information.",
                                                "Operation Cancelled",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                removeFPColors();
                                MessageBox.Show("The operation has been cancelled.",
                                                "Cancelled",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }



                            // Execute additional code after the user clicks OK or closes the message box
                            fpInstance.DelRegTemplate(1);
                            //ResetUI();// Remove the temporary template
                            //StopRegistrationProcess();

                            IsRegister = false;

                            return;
                        }
                        else
                        {
                            // No match found for this fingerprint, clean up the template
                            fpInstance.DelRegTemplate(1); // Remove the temporary template
                            continue;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }));
                }
                else
                {
                    MessageBox.Show($"An error occurred: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
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

        // Handles the disconnection process from the fingerprint device, stopping any ongoing capture.
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = true;
            RegisterCount = 0;

            // Close the connection
            int result = fpInstance.CloseDevice();
            Thread.Sleep(1000);
            if (captureThread != null && captureThread.IsAlive)
            {
                captureThread.Abort();

            }

            if (result == zkfp.ZKFP_ERR_OK)
            {
                result = fpInstance.Finalize();   // Clear the resources
                if (result == zkfp.ZKFP_ERR_OK)
                {
                    // Reset any variables and data if necessary
                    ClearImage();
                    regTempLen = 0;
                    IsRegister = false;

                    // Resest UI
                    btnDisconnect.Enabled = false;
                    btnConnect.Enabled = true;
                    lblConnectionStatus.Text = "Disconnect!";
                    tbxDeviceInfo.Text = "";
                    
                    tclFingerPrintControl.Enabled = false;
                    btnDisconnect.Enabled = false;
                    tclFingerPrintControl.Enabled = false;
                    gbxAuthFingerPrint.Enabled = false;
                    gbxAuthPID.Enabled = false;

                    gbxAuthPID.Enabled = false;


                    

                    // Clear Fingers Button Colors "yellow" 

                    removeFPColors();


                    //tbcPatientInfo.Visible = false;
                    //toolStripStatusLabel1.Text = "Please click the 'CONNECT' button to connect the device.";
                    //toolStripStatusLabel1.BackColor = Color.FromArgb(230, 112, 134);
                }
            }
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

        public void ResetBtnColor()
        {
            // Dictionary to map finger names to corresponding buttons
            var fingerButtonMapping = new Dictionary<string, Button>
            {
                { "RT", btnRT },
                { "RI", btnRI },
                { "RM", btnRM },
                { "RR", btnRR },
                { "RP", btnRP },
                { "LT", btnLT },
                { "LI", btnLI },
                { "LM", btnLM },
                { "LR", btnLR },
                { "LP", btnLP }
            };

            // Reset all buttons to their default color
            foreach (var button in fingerButtonMapping.Values)
            {
                button.BackColor = SystemColors.Control; // Reset to default color
            }
        }

        private void FingerPrint_Authentication_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnDisconnect_Click(sender, e);
        }


        // remove fingerPrints yellow colors 
        private void removeFPColors()
        {
            // Clear Fingers Button Colors "yellow" 

            btnRT.BackColor = Color.Transparent;
            btnRI.BackColor = Color.Transparent;
            btnRM.BackColor = Color.Transparent;
            btnRR.BackColor = Color.Transparent;
            btnRP.BackColor = Color.Transparent;
            btnLT.BackColor = Color.Transparent;
            btnLI.BackColor = Color.Transparent;
            btnLM.BackColor = Color.Transparent;
            btnLR.BackColor = Color.Transparent;
            btnLP.BackColor = Color.Transparent;
        }


        private bool validatePIDSearch()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(tbxPIDSearch.Text))
            {
                errorProvider.SetError(tbxPIDSearch, "This field is required");
                isValid = false;
            } else
            {
                errorProvider.SetError(tbxPIDSearch, string.Empty);
            }

            return isValid;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(validatePIDSearch())
            {
                using (var context = new DatabaseConnection())
                {
                    var pidSearch = (string)tbxPIDSearch.Text;

                    // Retrieve the entire patient record based on the PID
                    var patientDetail = context.Patients
                                               .Where(ipd => ipd.PID == pidSearch)
                                               .SingleOrDefault();
                                    

                    
                    if (patientDetail != null)
                    {
                        // Fetch all fingerprints along with associated patient information
                        var fingerprints = context.Finger_Print_Data
                            .Include(fp => fp.Patient) // Ensure navigation property is set up
                            .ToList();

                        if (fingerprints != null)
                        {
                            // Fetch only the fingerprints for the specific PID
                            var matchedFingerprints = context.Finger_Print_Data
                                .Where(fp => fp.PID == pidSearch)
                                .ToList();

                            // Dictionary to map finger names to corresponding buttons
                            var fingerButtonMapping = new Dictionary<string, Button>
                                {
                                    { "RT", btnRT },
                                    { "RI", btnRI },
                                    { "RM", btnRM },
                                    { "RR", btnRR },
                                    { "RP", btnRP },
                                    { "LT", btnLT },
                                    { "LI", btnLI },
                                    { "LM", btnLM },
                                    { "LR", btnLR },
                                    { "LP", btnLP }
                                };

                            // Reset button colors
                            foreach (var button in fingerButtonMapping.Values)
                            {
                                button.BackColor = DefaultBackColor; // Reset to default color
                            }


                            if (matchedFingerprints.Any())
                            {
                                // Highlight the buttons based on the registered fingerprints for the matched PID
                                foreach (var fingerprint in matchedFingerprints)
                                {
                                    if (fingerButtonMapping.TryGetValue(fingerprint.FingerName, out Button button))
                                    {
                                        button.BackColor = Color.Yellow;
                                    }
                                }
                            }
                        } 
                        
                        else

                        {
                            // Handle the case where no fingerprints are found
                            MessageBox.Show("No fingerprints found for the selected PID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally reset button colors
                            var fingerButtonMapping = new Dictionary<string, Button>
                            {
                                { "RT", btnRT },
                                { "RI", btnRI },
                                { "RM", btnRM },
                                { "RR", btnRR },
                                { "RP", btnRP },
                                { "LT", btnLT },
                                { "LI", btnLI },
                                { "LM", btnLM },
                                { "LR", btnLR },
                                { "LP", btnLP }
                            };

                            foreach (var button in fingerButtonMapping.Values)
                            {
                                button.BackColor = DefaultBackColor; // Reset to default color
                            }
                        }

                        string message = $"A record found: {patientDetail.PID}.\n" +
                                         $"Patient Name: {patientDetail.FullName}.\n";

                        // Display the message box with Yes, No, and Cancel buttons
                        DialogResult result = MessageBox.Show(message,
                                                              "A record found",
                                                              MessageBoxButtons.YesNoCancel,
                                                              MessageBoxIcon.Question);

                        // Handle the user's response
                        if (result == DialogResult.Yes)
                        {
                            // Logic to proceed to the update window
                            // Replace with your actual update method
                            UpdatePatientFormDetail npfd = new UpdatePatientFormDetail(pidSearch);
                            npfd.ShowDialog();
                            removeFPColors();
                        }
                        else if (result == DialogResult.No)
                        {
                            removeFPColors();
                            MessageBox.Show("You have chosen not to update the patient's information.",
                                            "Operation Cancelled",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            removeFPColors();
                            MessageBox.Show("The operation has been cancelled.",
                                            "Cancelled",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }



                    } else
                    {
                        MessageBox.Show("No records were found for the provided Patient ID (PID). Please check the PID and try again.",
                                        "Record Not Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                    }

                }
                
            } else
            {
                MessageBox.Show("Please enter the PID", "Required PID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
