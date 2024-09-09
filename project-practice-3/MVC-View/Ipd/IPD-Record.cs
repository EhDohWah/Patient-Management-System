using project_practice_3.MVC_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_practice_3.MVC_View.Ipd
{
    public partial class IPD_Record : Form
    {
        string status;
        string PID;
        string AN;
        string opdFullName;
        string siteCode;
        string AdmitDate;

        public IPD_Record(string status, string PID, string AN, string opdFullName, string siteCode, string admitDate)
        {
            InitializeComponent();
            this.status = status;
            this.PID = PID;
            this.AN = AN;
            this.opdFullName = opdFullName;
            this.siteCode = siteCode;
            this.AdmitDate = admitDate;
            loadData();
            tclPatientTransfer.Visible = false;
        }

        public void loadData()
        {
            lblPIDValue.Text = PID;
            lblStatusValue.Text = status;
            lblANValue.Text = AN;   
            if (status == "Active")
            {
                lblStatusValue.ForeColor = Color.Green;
            }
            else if (status == "Transferred")
            {
                lblStatusValue.ForeColor = Color.Tomato;
            }
            lblFullName.Text = opdFullName;
            lblDateValue.Text = AdmitDate;
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseConnection())
                {
                    // Replace this with the actual PID you want to update
                    string pidToUpdate = PID;

                    // Retrieve the existing record
                    var existingPatient = context.Patient_IPD.SingleOrDefault(p => p.PID == pidToUpdate);

                    if (existingPatient != null)
                    {
                        // Update the discharge date
                        existingPatient.DischargeDate = dtpDischargeDate.Value;
                        existingPatient.Status = "Transferred";
                        // Save the changes to the database
                        context.SaveChanges();




                        // Inform the user about the success
                        MessageBox.Show("Patient discharge date updated successfully!", "Update Successful",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If no patient is found, notify the user
                        MessageBox.Show("Patient not found. Please verify the Patient ID.", "Patient Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


                
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");

                // Show a user-friendly error message
                MessageBox.Show("An error occurred while updating the patient record. Please try again or contact support.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void CbxPatientTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tclPatientTransfer.Visible = true;

            // Get the selected index of the ComboBox
            int selectedIndex = cbxPatientTransfer.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // IPD selected
                        // Automatically select the OPD tab and enable it
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageHome"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHome"], true); // Disable IPD
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHospital"], false);
         
                    //tbxIPDAN.Text = "";
                    //tbxIPDSiteCode.Text = "";

                    break;

                case 1: // Home selected
                        // Automatically select the IPD tab and enable it
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageHospital"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHome"], false);
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHospital"], true); // Disable Hospital
                    //tbxOPDSiteCode.Text = "";
                    //tbxReasonVisit.Text = "";
                    //tbxOPDNote.Text = "";
                    break;
                
                default:
                    // Optionally handle other cases
                    break;
            }
        }

        // Method to enable or disable all controls inside a TabPage
        private void SetTabEnabled(TabPage page, bool enabled)
        {
            foreach (Control ctrl in page.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }

        private void BtnTransferSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseConnection())
                {
                    var newPatientTransfer = new Patient_Transfer_Model
                    {
                        Id = (context.Patient_Transfer.Max(f => (int?)f.Id) ?? 0) + 1,
                        PID = PID,
                        Date = DateTime.Now,
                        From = "IPD",
                    };

                    if (cbxPatientTransfer.SelectedIndex == 0) // Home
                    {
                        newPatientTransfer.To = "Home";
                    }
                    else if (cbxPatientTransfer.SelectedIndex == 1) // Hospital
                    {
                        newPatientTransfer.To = "Hospital";
                    }
                    else
                    {
                        // If the selected index is not valid, show an error
                        MessageBox.Show("Please select a valid transfer destination.",
                                        "Invalid Selection",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    // Add the transfer record to the database
                    context.Patient_Transfer.Add(newPatientTransfer);
                    context.SaveChanges();

                    
                }

                // Update IPD patient
                using (var context = new DatabaseConnection())
                {
                    // Replace this with the actual PID you want to update
                    string pidToUpdate = PID;

                    // Retrieve the existing record
                    var existingPatient = context.Patient_IPD.SingleOrDefault(p => p.PID == pidToUpdate);

                    if (existingPatient != null) 
                    {
                        existingPatient.Status = "Transferred";
                        // Save the changes to the database
                        context.SaveChanges();
                                                
                    }
                }

                // Show success message
                MessageBox.Show("Patient transfer saved successfully!",
                                "Transfer Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                // Log the error for debugging or tracking purposes
                Console.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");

                // Show user-friendly error message
                MessageBox.Show("An error occurred while saving the patient transfer. Please try again or contact support.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            reloadData();
        }

        private void reloadData ()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve all records from Patient_OPD_Model without loading the related Patient entity
                var ipdPatients = context.Patient_IPD
                                         .Where(ipd => ipd.PID == PID)
                                         .Select(ipd => new
                                         {
                                             ipd.AN,
                                             ipd.PID,
                                             ipd.SiteCode,
                                             ipd.AdmitDate,
                                             ipd.DischargeDate,
                                             ipd.Status
                                         })
                                         .SingleOrDefault();


                // Bind the retrieved records to the DataGridView
                if (ipdPatients != null)
                {
                    lblPIDValue.Text = ipdPatients.PID;
                    lblStatusValue.Text = ipdPatients.Status;
                    lblANValue.Text = ipdPatients.AN;
                    if (ipdPatients.Status == "Active")
                    {
                        lblStatusValue.ForeColor = Color.Green;
                    }
                    else if (ipdPatients.Status == "Transferred")
                    {
                        lblStatusValue.ForeColor = Color.Tomato;
                    }
                    lblFullName.Text = opdFullName;
                    lblDateValue.Text = AdmitDate;
                }


            }
        }
    }
}
