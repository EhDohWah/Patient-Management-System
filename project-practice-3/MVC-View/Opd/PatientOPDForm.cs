using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_practice_3.MVC_View.Opd
{
    public partial class PatientOPDForm : Form
    {
        public static string fullName;

        public PatientOPDForm()
        {
            InitializeComponent();
            totalShow();
            activeShow();
            listOPDpatients();
        }

        // Show all OPD patients records
        private void totalShow()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve the total number of records in Patient OPD
                int totalOPDRecords = context.Patient_OPD.Count();
                                      

                // Display the total number 
                lblOPDNO.Text = totalOPDRecords.ToString();
            }
        }

        // Show active OPD patients records
        private void activeShow()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve the total number of records in Patient OPD
                int totalOPDRecords = context.Patient_OPD
                                      .Where(opd => opd.Status == "Active")
                                      .Count();

                // Display the total number 
                lblActiveNo.Text = totalOPDRecords.ToString();
            }
        }

        // Bind the data to gridView
        private void listOPDpatients()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve all records from Patient_OPD_Model with "Active" status without loading the related Patient entity
                var opdPatients = context.Patient_OPD
                                         .Where(opd => opd.Status == "Active") // Filter by "Active" status
                                         .Select(opd => new
                                         {
                                             opd.Id,
                                             opd.PID,
                                             opd.Date,
                                             opd.SiteCode,
                                             opd.ReasonVisit,
                                             opd.Note,
                                             opd.Status
                                         })
                                         .ToList();



                // Bind the retrieved records to the DataGridView
                dgvOPDLists.DataSource = opdPatients;


            }
        }

        // DataGRid cell click
        private void DgvOPDLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOPDLists.Rows[e.RowIndex];
                string pid = row.Cells["PID"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();
                string siteCode = row.Cells["SiteCode"].Value.ToString();
                string date = row.Cells["Date"].Value.ToString();
                string reasonVisit = row.Cells["ReasonVisit"].Value.ToString();
                string note = row.Cells["Note"].Value.ToString();

                using (var context = new DatabaseConnection())
                {
                    fullName = context.Patients.Where(p => p.PID == pid).Select(p => p.FullName).FirstOrDefault();

                }

                OPD_Record opdR = new OPD_Record(pid, fullName, status, siteCode, date, reasonVisit, note);
                opdR.ShowDialog();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            totalShow();
            activeShow();
            listOPDpatients();
        }
    }
}
