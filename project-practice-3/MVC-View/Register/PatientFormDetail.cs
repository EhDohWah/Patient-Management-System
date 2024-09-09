using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using project_practice_3.MVC_View.Register;
using project_practice_3.MVC_Model;

namespace project_practice_3.MVC_View.Register
{
    public partial class PatientFormDetail : Form
    {
        string PID;

        public PatientFormDetail(string PID)
        {
            InitializeComponent();
            this.PID = PID;
            tbxIDcard.Text = this.PID;

            // Clear any items set in the designer
            cbxGender.Items.Clear();

            // Add items with text and value (Male -> 0, Female -> 1)
            cbxGender.Items.Add(new { Text = "Male", Value = 0 });
            cbxGender.Items.Add(new { Text = "Female", Value = 1 });

            // Set how the ComboBox displays the text and stores the value
            cbxGender.DisplayMember = "Text";
            cbxGender.ValueMember = "Value";

            tclPatientTransfer.Visible = false;

            // Show empty DateTimePicker
            dtpDOB.CustomFormat = " "; // Set custom format to empty space
            dtpDOB.Format = DateTimePickerFormat.Custom; // Use custom format


        }

        // Tab 1 next button
        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Check if the currently selected tab is not the last one
            if (tclPatientFormControl.SelectedIndex < tclPatientFormControl.TabCount - 1)
            {
                // Move to the next tab
                tclPatientFormControl.SelectedIndex++;
            }
            else
            {
                // Optionally, if you want to loop back to the first tab when reaching the last one:
                // tbcPatientInfo.SelectedIndex = 0;

                // Alternatively, if you want to display a message when reaching the last tab:
                MessageBox.Show("You have reached the last tab.", "End of Tabs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tab 2 next button
        private void BtnNextTwo_Click(object sender, EventArgs e)
        {
            // Check if the currently selected tab is not the last one
            if (tclPatientFormControl.SelectedIndex < tclPatientFormControl.TabCount - 1)
            {
                // Move to the next tab
                tclPatientFormControl.SelectedIndex++;
            }
            else
            {
                // Optionally, if you want to loop back to the first tab when reaching the last one:
                // tbcPatientInfo.SelectedIndex = 0;

                // Alternatively, if you want to display a message when reaching the last tab:
                MessageBox.Show("You have reached the last tab.", "End of Tabs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Check if the currently selected tab is not the first one
            if (tclPatientFormControl.SelectedIndex > 0)
            {
                // Move to the previous tab
                tclPatientFormControl.SelectedIndex--;
            }
            else
            {
                // Optionally, if you want to loop back to the last tab:
                // tclPatientFormControl.SelectedIndex = tclPatientFormControl.TabCount - 1;

                // Alternatively, if you want to display a message when reaching the first tab:
                MessageBox.Show("You are already at the first tab.", "Beginning of Tabs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBackTwo_Click(object sender, EventArgs e)
        {
            // Check if the currently selected tab is not the first one
            if (tclPatientFormControl.SelectedIndex > 0)
            {
                // Move to the previous tab
                tclPatientFormControl.SelectedIndex--;
            }
            else
            {
                // Optionally, if you want to loop back to the last tab:
                // tclPatientFormControl.SelectedIndex = tclPatientFormControl.TabCount - 1;

                // Alternatively, if you want to display a message when reaching the first tab:
                MessageBox.Show("You are already at the first tab.", "Beginning of Tabs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbxPatientTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tclPatientTransfer.Visible = true;

            // Get the selected index of the ComboBox
            int selectedIndex = cbxPatientTransfer.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // OPD selected
                        // Automatically select the OPD tab and enable it
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageOPD"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageOPD"], true);  // Enable OPD
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageIPD"], false); // Disable IPD
                    tbxIPDAN.Text = "";
                    tbxIPDSiteCode.Text = "";

                    break;

                case 1: // IPD selected
                        // Automatically select the IPD tab and enable it
                    tclPatientTransfer.SelectedTab = tclPatientTransfer.TabPages["tabPageIPD"];
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageIPD"], true);  // Enable IPD
                    SetTabEnabled(tclPatientTransfer.TabPages["tabPageOPD"], false); // Disable OPD
                    tbxOPDSiteCode.Text = "";
                    tbxReasonVisit.Text = "";
                    tbxOPDNote.Text = "";
                    break;

                default:
                    // Optionally handle other cases
                    break;
            }

            

            // Debugging message to check the selected index and tab
            MessageBox.Show("You have selected: " + tclPatientTransfer.SelectedTab.Text +
                            "\n Current Tab: " + tclPatientTransfer.SelectedTab.Name, "");

        }

        // Method to enable or disable all controls inside a TabPage
        private void SetTabEnabled(TabPage page, bool enabled)
        {
            foreach (Control ctrl in page.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // FullName validation
            if (string.IsNullOrEmpty(tbxFullName.Text))
            {
                errorProvider.SetError(tbxFullName, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxFullName, string.Empty); // Clear error
            }

            // Gender validation
            if (cbxGender.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxGender, "Please select a gender");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(cbxGender, string.Empty); // Clear error
            }

            // Date of Birth validation
            if (!dtpDOB.Checked && dtpDOB.Value.Date > DateTime.Now.Date)
            {
                errorProvider.SetError(dtpDOB, "Please select a date");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(dtpDOB, string.Empty); // Clear error
            }

            // PhoneNumber validation (using MaskedTextBox)
            if (!mtbxPhoneNumber.MaskFull)
            {
                errorProvider.SetError(mtbxPhoneNumber, "Invalid phone number");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(mtbxPhoneNumber, string.Empty); // Clear error
            }


            // Address Code (Validation) 
            if (string.IsNullOrEmpty(tbxAddressCode.Text))
            {
                errorProvider.SetError(tbxAddressCode, "This field is required");
                isValid = false;
            } else
            {
                errorProvider.SetError(tbxAddressCode, string.Empty);
            }

            // Section Name (Validation) 
            if (string.IsNullOrEmpty(tbxSectionName.Text))
            {
                errorProvider.SetError(tbxSectionName, "This field is required");
                isValid = false;
            } else
            {
                errorProvider.SetError(tbxSectionName, string.Empty);
            }


            // Site Code (Validation) 
            if (string.IsNullOrEmpty(tbxSiteCode.Text))
            {
                errorProvider.SetError(tbxSiteCode, "This field is required");
                isValid = false;
            } else
            {
                errorProvider.SetError(tbxSiteCode, string.Empty);
            }


            // Transfer dropdown validate
            if (cbxPatientTransfer.SelectedIndex == -1)
            {
                errorProvider.SetError(cbxPatientTransfer, "Please select an option");
                isValid = false;
            } else
            {
                errorProvider.SetError(cbxPatientTransfer , string.Empty);  
            }

            // Check if OPD is selected (index 0) 
            if (cbxPatientTransfer.SelectedIndex == 0)
            {
                // Validate OPD-specific fields
                if (string.IsNullOrEmpty(tbxOPDSiteCode.Text))
                {
                    errorProvider.SetError(tbxOPDSiteCode, "This field is required");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(tbxOPDSiteCode, string.Empty);
                }

                if (string.IsNullOrEmpty(tbxReasonVisit.Text))
                {
                    errorProvider.SetError(tbxReasonVisit, "This field is required");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(tbxReasonVisit, string.Empty);
                }

                if (string.IsNullOrEmpty(tbxOPDNote.Text))
                {
                    errorProvider.SetError(tbxOPDNote, "This field is required");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(tbxOPDNote, string.Empty);
                }

            } else if (cbxPatientTransfer.SelectedIndex == 1)
            {
                // Validate IPD-specific fields
                if (string.IsNullOrEmpty(tbxIPDAN.Text))
                {
                    errorProvider.SetError(tbxIPDAN, "This field is required");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(tbxIPDAN, string.Empty);
                }

                if (string.IsNullOrEmpty(tbxIPDSiteCode.Text))
                {
                    errorProvider.SetError(tbxIPDSiteCode, "This field is required");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(tbxIPDSiteCode, string.Empty);
                }

                if (dtpAdmitDate.Value == null || dtpAdmitDate.Value == DateTime.MinValue)
                {
                    errorProvider.SetError(dtpAdmitDate, "Please select a valid admit date");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(dtpAdmitDate, string.Empty);
                }

            }

            

            return isValid;
        }

        // Saving data.
        private void SaveData()
        {
            try
            {
                if (ValidateForm())
                {
                    MessageBox.Show("All fields are filled!");

                    // Retrieve the selected gender as TINYINT (0 for Male, 1 for Female)
                    var selectedGender = cbxGender.SelectedIndex;

                    using (var context = new DatabaseConnection())
                    {
                        // Save Address
                        var newAddress = new Address
                        {
                            AddressCode = tbxAddressCode.Text,
                            SectionName_EN = tbxSectionName.Text,
                            VillageCode = tbxVillageCode.Text,
                            VillageName_EN = tbxVillageNEn.Text,
                            VillageName_MM = tbxVillageNMM.Text,
                            VillageName_KAREN = tbxVillageNKaren.Text,
                            VillageGPSLat = tbxVGPSLat.Text,
                            VillageGPSLong = tbxVGPSLong.Text,
                            SubdistrictCode = tbxSubDCode.Text,
                            SubdistrictName_EN = tbxSubDNameEN.Text,
                            DistrictCode = tbxDistrictCode.Text,
                            DistrictName_EN = tbxDistrictNEN.Text,
                            ProvinceCode = tbxProvinceCode.Text,
                            ProvinceName_EN = tbxProvinceNameEN.Text,
                            RegionCode = tbxRegionCode.Text,
                            RegionName_EN = tbxRegionNEN.Text,
                            CountryCode = tbxCountryCode.Text,
                            CountryName_EN = tbxCountryNameEN.Text,
                        };

                        context.Addresses.Add(newAddress);
                        context.SaveChanges();
                    }

                    using (var context = new DatabaseConnection())
                    {
                        // Replace this with the actual PID you want to update
                        string pidToUpdate = tbxIDcard.Text;

                        // Retrieve the existing record
                        var existingPatient = context.Patients.SingleOrDefault(p => p.PID == pidToUpdate);

                        if (existingPatient != null)
                        {

                            existingPatient.AddressCode = tbxAddressCode.Text;
                            existingPatient.AdmissionDate = DateTime.Now;
                            existingPatient.FullName = tbxFullName.Text;
                            existingPatient.MotherPID = tbxMotherPID.Text;
                            existingPatient.MotherName = tbxMotherName.Text;
                            existingPatient.FatherName = tbxFatherName.Text;
                            existingPatient.SpouseName = tbxSpouseName.Text;
                            existingPatient.Gender = (byte)selectedGender;
                            existingPatient.PhoneNumber = mtbxPhoneNumber.Text;
                            existingPatient.DOB = dtpDOB.Value;
                            existingPatient.AddressOther = tbxAddressOther.Text;
                            existingPatient.Note = tbxNote.Text;
                            existingPatient.SiteCode = tbxSiteCode.Text;
                            existingPatient.BloodGroup = tbxBloodGroup.Text;
                            existingPatient.G6PD = tbxG6PD.Text;
                            existingPatient.Allergy = tbxAllergy.Text;
                            existingPatient.CreatedDate = DateTime.Now;
                            context.SaveChanges();

                        } else
                        {
                            // Handle the case where the record was not found
                            MessageBox.Show("Patient record not found.");
                        }
                                               
                        
                    }

                    if (cbxPatientTransfer.SelectedIndex == 0) // OPD
                    {
                        // Save data into OPD table
                        using (var context = new DatabaseConnection())
                        {
                            var newPatient_OPD = new Patient_OPD_Model
                            {
                                Id = (context.Patient_OPD.Max(f => (int?)f.Id) ?? 0) + 1,
                                PID = tbxIDcard.Text,
                                Date = DateTime.Now,
                                SiteCode = tbxOPDSiteCode.Text,
                                ReasonVisit = tbxReasonVisit.Text,
                                Note = tbxNote.Text,
                                Status = "Active"

                            };

                            context.Patient_OPD.Add(newPatient_OPD);
                            context.SaveChanges();
                        }

                        // Save data into TransferTable
                        using (var context = new DatabaseConnection())
                        {
                            var newPatientTransfer = new Patient_Transfer_Model
                            {
                                Id = (context.Patient_Transfer.Max(f => (int?)f.Id) ?? 0) + 1,
                                PID = tbxIDcard.Text,
                                Date = DateTime.Now,
                                From = "ROG",
                                To = "OPD",
                            };

                            context.Patient_Transfer.Add(newPatientTransfer);
                            context.SaveChanges();
                        }

                    }
                    else if (cbxPatientTransfer.SelectedIndex == 1) // IPD
                    {
                        // SAve data into IPD table
                        using (var context = new DatabaseConnection())
                        {
                            var newPatient_IPD = new Patient_IPD_Model
                            {
                                AN = tbxIPDAN.Text,
                                PID = tbxIDcard.Text,
                                SiteCode = tbxIPDSiteCode.Text,
                                AdmitDate = DateTime.Now,
                                Status = "Active"
                            };

                            context.Patient_IPD.Add(newPatient_IPD);
                            context.SaveChanges();
                        }


                        // Save data into transfer table
                        using (var context = new DatabaseConnection())
                        {
                            var newPatientTransfer = new Patient_Transfer_Model
                            {
                                Id = (context.Patient_Transfer.Max(f => (int?)f.Id) ?? 0) + 1,
                                PID = tbxIDcard.Text,
                                Date = DateTime.Now,
                                From = "ROG",
                                To = "IPD",
                            };

                            context.Patient_Transfer.Add(newPatientTransfer);
                            context.SaveChanges();
                        }


                    }

                    MessageBox.Show("Patient data has been saved successfully!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Please fill the required fields!", "Complete the form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Format detailed error message
                var errorMessage = $"An error occurred while saving data:\n\n" +
                                   $"Message: {ex.Message}\n" +
                                   $"Source: {ex.Source}\n" +
                                   $"Stack Trace: {ex.StackTrace}\n" +
                                   $"Inner Exception: {ex.InnerException?.Message}";

                // Show detailed error message in a MessageBox
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void PatientFormDetail_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Now;  // Prevent future dates
            dtpAdmitDate.MaxDate = DateTime.Now;
        }

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dddd, dd MMMM,yyyy";
        }
    }
}
