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
                            // Match found; retrieve the associated PID and Patient details
                            string matchedPID = fingerprint.PID;
                            string patientName = fingerprint.Patient?.FullName ?? "Unknown";

                            // Construct the message
                            string message = $"The fingerprint is already registered to PID: {matchedPID}.\n" +
                                             $"Patient Name: {patientName}.\n" +
                                             "Please use another finger or proceed to identification.";



                            // Display the message box on the UI thread
                            // Assuming this method is called from a non-UI thread, use Invoke if necessary
                            if (InvokeRequired)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    MessageBox.Show(message,
                                                    "Fingerprint Duplication",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                }));
                            }
                            else
                            {
                                MessageBox.Show(message,
                                                "Fingerprint Duplication",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
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





    }
}
