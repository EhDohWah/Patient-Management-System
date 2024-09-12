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

namespace project_practice_3.MVC_View.Ipd
{
    public partial class PatientIPDForm : Form
    {

        public static string fullName;
        public PatientIPDForm()
        {
            InitializeComponent();
            
            activeShow();
            listIPDPatients();
        }

        // Get all the records, which is active
        private void activeShow()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve the total number of records in Patient OPD
                int totalOPDRecords = context.Patient_IPD
                                      .Where(opd => opd.Status == "Active")
                                      .Count();

                if (totalOPDRecords > 0)
                {
                    // Display the total number 
                    lblIPDActiveNo.Text = totalOPDRecords.ToString();
                } else if (totalOPDRecords <= 0)
                {
                    // Display the total number 
                    lblIPDActiveNo.Text = "0";
                }
                

            }
        }

        // IPD patients lists and bind the data to datagrid
        private void listIPDPatients ()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve all records from Patient_OPD_Model without loading the related Patient entity
                var ipdPatients = context.Patient_IPD
                                         .Where(ipd => ipd.Status == "Active")
                                         .Select(ipd => new
                                         {
                                             ipd.AN,
                                             ipd.PID,
                                             ipd.SiteCode,
                                             ipd.AdmitDate,
                                             ipd.DischargeDate,
                                             ipd.Status
                                         })
                                         .ToList();


                // Bind the retrieved records to the DataGridView
                dgvIPDLists.DataSource = ipdPatients;


            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            activeShow();
            listIPDPatients();
        }

        private void DgvIPDLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvIPDLists.Rows[e.RowIndex];
                    string pid = row.Cells["PID"].Value.ToString();
                    string AN = row.Cells["AN"].Value.ToString();
                    string status = row.Cells["Status"].Value.ToString();
                    string siteCode = row.Cells["SiteCode"].Value.ToString();
                    string date = row.Cells["AdmitDate"].Value.ToString();

                    using (var context = new DatabaseConnection())
                    {
                        var fullName = context.Patients
                                            .Where(p => p.PID == pid)
                                            .Select(p => p.FullName)
                                            .FirstOrDefault();
                    }

                    IPD_Record ipdR = new IPD_Record(status, pid, AN, fullName, siteCode, date);
                    ipdR.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                // Log the exception if needed (optional)
                // Show a friendly message to the user
                MessageBox.Show("An error occurred while retrieving patient details. Please try again or contact support if the issue persists.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                // Optionally, you can log the error details for debugging purposes
                Console.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");
            }
        }

    }
}
