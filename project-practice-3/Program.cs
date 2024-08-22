using project_practice_3.MVC_View.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_practice_3.MVC_View.Ipd;
using project_practice_3.MVC_View.Opd;

namespace project_practice_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Master());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Retrieve the launch count from settings or file
            int launchCount = Properties.Settings.Default.LaunchCount;
            Form formToOpen = null;

            switch (launchCount)
            {
                case 0:
                    formToOpen = new RegisterForm();
                    break;
                case 1:
                    formToOpen = new PatientOPDForm();
                    break;
                case 2:
                    formToOpen = new PatientIPDForm();
                    break;
                default:
                    MessageBox.Show("All windows have been displayed.", "Information");
                    break;
            }

            // Update the launch count for next time
            Properties.Settings.Default.LaunchCount = (launchCount + 1) % 3;
            Properties.Settings.Default.Save();

            if (formToOpen != null)
            {
                formToOpen.Show(); // Show the form without blocking the code
                Application.Run(); // Start the application loop
            }
        }
    }
}
