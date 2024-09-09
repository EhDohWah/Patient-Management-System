using project_practice_3.MVC_View.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_practice_3.MVC_View.Ipd;
using project_practice_3.MVC_View.Opd;
using project_practice_3.MVC_View.Authenticate;
using project_practice_3.MVC_View.Authenticate.FingerPrint;
using project_practice_3.MVC_View.Dashboard;

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
                    formToOpen = new Dashboard();
                    break;
                case 1:
                    formToOpen = new RegisterForm();
                    break;
                case 2:
                    formToOpen = new PatientIPDForm();
                    break;
                case 3:
                    formToOpen = new PatientOPDForm();
                    break;
                case 4:
                    formToOpen = new FingerPrint_Authentication();
                    break;
                default:
                    MessageBox.Show("All windows have been displayed.", "Information");
                    break;
            }

            // Update the launch count for next time
            Properties.Settings.Default.LaunchCount = (launchCount + 1) % 5;
            Properties.Settings.Default.Save();

            if (formToOpen != null)
            {
                formToOpen.FormClosed += (s, e) =>
                {
                    // Check if there are any open forms left
                    if (Application.OpenForms.Count == 0)
                    {
                        Application.ExitThread(); // Stop the application loop
                    }
                };

                formToOpen.Show(); // Show the form without blocking the code
                Application.Run(); // Start the application loop
            }
        }
    }
}
