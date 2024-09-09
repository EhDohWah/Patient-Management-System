using project_practice_3.MVC_Model;
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
    public partial class OPD_Record : Form
    {
        string PID;
        string opdFullName;
        string status;
        string siteCode;
        string date;
        string reasonVisit;
        string note;

        public OPD_Record(string opdPID, string opdFullName, string status, string siteCode, string date, string reasonVisit, string note)
        {
            InitializeComponent();
            this.PID = opdPID;
            this.opdFullName = opdFullName;
            this.status = status;
            this.siteCode = siteCode;
            this.date = date;
            this.reasonVisit = reasonVisit;
            this.note = note;
            LoadData();
            tclPatientTransfer.Visible = false;
            btnTransferSave.Visible = false;
        }

        public void LoadData()
        {
            lblPIDValue.Text = PID;
            lblStatusValue.Text = status;
            if (status == "Active")
            {
                lblStatusValue.ForeColor = Color.Green;
            } else if (status == "Transferred")
            {
                lblStatusValue.ForeColor = Color.Tomato;
            }
            lblFullName.Text = opdFullName;
            lblDateValue.Text = date;
            tbxReasonVisit.Text = reasonVisit;
            tbxNote.Text = note;

        }

        private void CbxPatientTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tclPatientTransfer.Visible = true;
            btnTransferSave.Visible = true;


            // Get the selected index of the ComboBox
            int selectedIndex = cbxPatientTransfer.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // IPD selected
                        // Automatically select the OPD tab and enable it
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageIPD"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageIPD"], true); // Disable IPD
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHome"], false);
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHospital"], false);
                    //tbxIPDAN.Text = "";
                    //tbxIPDSiteCode.Text = "";

                    break;

                case 1: // Home selected
                        // Automatically select the IPD tab and enable it
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageHome"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageIPD"], false);  // Disable IPD
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHome"], true);
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHospital"], false); // Disable Hospital
                    //tbxOPDSiteCode.Text = "";
                    //tbxReasonVisit.Text = "";
                    //tbxOPDNote.Text = "";
                    break;

                case 2:
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageHospital"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageIPD"], false);  // Disable IPD
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHome"], false);
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageHospital"], true); // Disable OPD
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


        // Validate the form 
        private bool validateForm()
        {
            bool isValid = true;

            //validate AN 
            if (string.IsNullOrEmpty(tbxIPDAN.Text))
            {
                errorProvider.SetError(tbxIPDAN, "This field is required");
                isValid = false;
            } 
            else
            {
                errorProvider.SetError(tbxIPDAN, string.Empty); //Clear error
            }

            // Validate SiteCode
            if (string.IsNullOrEmpty (tbxIPDSiteCode.Text))
            {
                errorProvider.SetError(tbxIPDSiteCode, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxIPDSiteCode, string.Empty); //Clear error
            }

            // Validate Date
            if (!dtpAdmitDate.Checked && dtpAdmitDate.Value.Date > DateTime.Now.Date)
            {
                errorProvider.SetError(dtpAdmitDate, "Please select correct date");
                isValid = false;
            } 
            else
            {
                errorProvider.SetError(dtpAdmitDate, string.Empty);
            }

            return isValid;
        }


        // Save the transfer method
        private void BtnTransferSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    // 0 index is for IPD transfer
                    if(cbxPatientTransfer.SelectedIndex == 0)
                    {
                        // save the data inside the IPD table.
                        using (var context = new DatabaseConnection())
                        {
                            var newIPD = new Patient_IPD_Model
                            {
                                AN = tbxIPDAN.Text,
                                PID = PID,
                                SiteCode = tbxIPDSiteCode.Text,
                                AdmitDate = dtpAdmitDate.Value,
                                Status = "Active",
                            };

                            context.Patient_IPD.Add(newIPD);
                            context.SaveChanges();
                        }

                        // update OPD status
                        using (var context = new DatabaseConnection())
                        {
                            //PID
                            string pidToUpdate = PID;

                            // Retrieve the existing record
                            var existingPatientOPD = context.Patient_OPD.SingleOrDefault(p => p.PID == pidToUpdate);
                            if (existingPatientOPD != null)
                            {
                                existingPatientOPD.Status = "Transferred";
                                context.SaveChanges();
                            }
                        }

                        // record in the patient transfer
                        // Save data into TransferTable
                        using (var context = new DatabaseConnection())
                        {
                            var newPatientTransfer = new Patient_Transfer_Model
                            {
                                Id = (context.Patient_Transfer.Max(f => (int?)f.Id) ?? 0) + 1,
                                PID = PID,
                                Date = DateTime.Now,
                                From = "OPD",
                                To = "IPD",
                            };

                            context.Patient_Transfer.Add(newPatientTransfer);
                            context.SaveChanges();
                        }
                    }
                }

                MessageBox.Show("The patient has been successfully transferred.", "Transfer Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {

            }
        }


        private void reloadData()
        {
            using (var context = new DatabaseConnection())
            {
                // Retrieve all records from Patient_OPD_Model without loading the related Patient entity
                var opdPatient = context.Patient_OPD
                                         .Where(opd => opd.PID == PID)
                                         .Select(opd => new
                                         {
                                             opd.Date,
                                             opd.SiteCode,
                                             opd.ReasonVisit,
                                             opd.Note,
                                             opd.Status
                                         })
                                         .SingleOrDefault();


                // Bind the retrieved records to the DataGridView
                if (opdPatient != null)
                {
                    lblPIDValue.Text = PID;
                    lblStatusValue.Text = opdPatient.Status;
                    if (opdPatient.Status == "Active")
                    {
                        lblStatusValue.ForeColor = Color.Green;
                    }
                    else if (opdPatient.Status == "Transferred")
                    {
                        lblStatusValue.ForeColor = Color.Tomato;
                        gbxPatientTransfer.Enabled = false;
                    }
                    lblFullName.Text = opdFullName;
                    lblDateValue.Text = opdPatient.Date.ToString();
                    tbxReasonVisit.Text = opdPatient.ReasonVisit;
                    tbxNote.Text = opdPatient.Note;
                }


            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            reloadData();
        }
    }
}
