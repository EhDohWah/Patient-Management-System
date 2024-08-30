using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libzkfpcsharp;
using project_practice_3.MVC_View.Register;

namespace project_practice_3.MVC_Controller
{
    
    internal class FingerPrintDeviceController
    {

        // Create an instance (object) of zkfp class;
        zkfp fpInstance = new zkfp();
        IntPtr FormHandle = IntPtr.Zero;

        int RegisterCount = 0;
        int regTempLen = 0;
        public static int iFid = 1;
        static byte[] RegTmp = new byte[2048];
        public static bool bIdentify = false;

        public static string deviceSN;

        //For DoCaputer method.
        byte[][] RegTmps = new byte[3][];
        public static byte[] CapTmp = new byte[2048];
        int cbCapTmp;
        bool IsRegister = false;
        public static byte[] dbString = new byte[2048];

        int SelectedIndex;
        const int REGISTER_FINGER_COUNT = 3;
        bool bIsTimeToDie = false;


        public int mfpWidth = 0;
        public int mfpHeight = 0;


        // Thread 
        Thread captureThread = null;

        byte[] FPBuffer;   // Image Buffer
        private int selectedDeviceIndex;

        





    }
}
