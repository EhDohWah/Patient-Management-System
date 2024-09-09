using project_practice_3.MVC_View.ID_Printer;
using project_practice_3.MVC_View.Ipd;
using project_practice_3.MVC_View.Opd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_practice_3.MVC_View.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            displayOPD();
            displayIPD();
        }

        // Show OPD patient numbers on the dashboard 
        private void displayOPD()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve the total number of records in Patient OPD
                int totalOPDRecords = context.Patient_OPD
                                      .Where(opd => opd.Status == "Active")
                                      .Count();

                // Display the total number 
                lblOPDNO.Text = totalOPDRecords.ToString();
            }
        }

        // Show IPD patient numbers on the dashboard 
        private void displayIPD()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve the total number of records in Patient IPD
                int totalIPDRecords = context.Patient_IPD
                                      .Where(opd => opd.Status == "Active")
                                      .Count();

                // Display the total number
                lblIPDNo.Text = totalIPDRecords.ToString();
            }
        }

        private void BtnROG_Click(object sender, EventArgs e)
        {
            Reg_Auth_Form reg_Auth_Form = new Reg_Auth_Form();
            reg_Auth_Form.ShowDialog();
        }

        private void BtnOPD_Click(object sender, EventArgs e)
        {
            PatientOPDForm patientOPDForm = new PatientOPDForm();
            patientOPDForm.ShowDialog();    
        }

        private void BtnIPD_Click(object sender, EventArgs e)
        {
            PatientIPDForm patientIPDForm = new PatientIPDForm();
            patientIPDForm.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            displayOPD();
            displayIPD();
        }

        private void BtnGenerateIDCard_Click(object sender, EventArgs e)
        {
            IDCardPrinting idcp = new IDCardPrinting();
            idcp.ShowDialog();
        }
    }
}
