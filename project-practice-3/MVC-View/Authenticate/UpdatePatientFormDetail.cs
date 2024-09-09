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

namespace project_practice_3.MVC_View.Authenticate
{
    public partial class UpdatePatientFormDetail : Form
    {
        string PID;

        public UpdatePatientFormDetail(string pid)
        {
            InitializeComponent();
            this.PID = pid;

            // Clear any items set in the designer
            cbxGender.Items.Clear();

            // Add items with text and value (Male -> 0, Female -> 1)
            cbxGender.Items.Add(new { Text = "Male", Value = 0 });
            cbxGender.Items.Add(new { Text = "Female", Value = 1 });

            // Set how the ComboBox displays the text and stores the value
            cbxGender.DisplayMember = "Text";
            cbxGender.ValueMember = "Value";
            loadData();


            // Show empty DateTimePicker
            dtpDeathDate.CustomFormat = " "; // Set custom format to empty space
            dtpDeathDate.Format = DateTimePickerFormat.Custom; // Use custom format
        }

        // First page next click
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

        // Second page next click
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

        // Second page back click
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

        // third page back click
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

        // Load data based on the PID
        private void loadData()
        {
            // Retrieve patient data based on PID 
            using (var context = new DatabaseConnection())
            {

                // Retrieve the entire patient record based on the PID
                var patientDetail = context.Patients
                                           .Where(ipd => ipd.PID == PID)
                                           .SingleOrDefault();

                // Retrieve the entire patient record based on the PID
                var addressDetail = context.Addresses
                                           .Where(address => address.AddressCode == patientDetail.AddressCode)
                                           .SingleOrDefault();

                // Bind the retrieved records to the DataGridView
                if (patientDetail != null && addressDetail != null)
                {
                    tbxIDcard.Text = patientDetail.PID;
                    tbxFullName.Text = patientDetail.FullName;
                    // Mother PID
                    if (patientDetail.MotherPID == null)
                    {
                        tbxMotherPID.Text = "N/A";
                    } else
                    {
                        tbxMotherPID.Text = patientDetail.MotherPID;
                    }

                    // Mother Name
                    if (patientDetail.MotherName == null)
                    {
                        tbxMotherName.Text = "N/A";
                    }
                    else
                    {
                        tbxMotherName.Text = patientDetail.MotherName;
                    }

                    // Father Name
                    if (patientDetail.FatherName == null)
                    {
                        tbxFatherName.Text = "N/A";
                    }
                    else
                    {
                        tbxFatherName.Text = patientDetail.FatherName;
                    }

                    // Spouse Name
                    if (patientDetail.SpouseName == null)
                    {
                        tbxSpouseName.Text = "N/A";
                    } else
                    {
                        tbxSpouseName.Text = patientDetail.SpouseName;
                    }

                    // Gender
                    cbxGender.SelectedIndex = patientDetail.Gender.Value;
                    cbxGender.Enabled = false;
                    //Date
                    dtpDOB.Value = patientDetail.DOB.Value;
                    dtpDOB.Enabled = false;

                    //Phone
                    mtbxPhoneNumber.Text = patientDetail.PhoneNumber;

                    //other address
                    if (patientDetail.AddressOther == null)
                    {
                        tbxAddressOther.Text = "N/A";
                    } else
                    {
                        tbxAddressOther.Text = patientDetail.AddressOther;

                    }

                    // Note
                    if (patientDetail.Note == null)
                    {
                        tbxNote.Text = "N/A";
                    } else
                    {
                        tbxNote.Text = patientDetail.Note;
                    }

                    // SiteCode
                    tbxSiteCode.Text = patientDetail.SiteCode;

                    tbxBloodGroup.Text = patientDetail.BloodGroup;
                    tbxG6PD.Text = patientDetail.G6PD;
                    tbxAllergy.Text = patientDetail.Allergy;


                    // Address details
                    tbxAddressCode.Text = addressDetail.AddressCode;
                    tbxAddressCode.ReadOnly = true;
                    tbxSectionName.Text = addressDetail.SectionName_EN;
                    tbxVillageCode.Text = addressDetail.VillageCode;
                    tbxVillageNEn.Text  = addressDetail.VillageName_EN;
                    tbxVillageNMM.Text = addressDetail.VillageName_MM;
                    tbxVillageNKaren.Text = addressDetail.VillageName_KAREN;
                    tbxVGPSLat.Text = addressDetail.VillageGPSLat;
                    tbxVGPSLong.Text = addressDetail.VillageGPSLong;
                    tbxSubDCode.Text = addressDetail.SubdistrictCode;
                    tbxSubDNameEN.Text = addressDetail.SubdistrictName_EN;
                    tbxDistrictCode.Text = addressDetail.DistrictCode;
                    tbxDistrictNEN.Text = addressDetail.DistrictName_EN;
                    tbxProvinceCode.Text = addressDetail.ProvinceCode;
                    tbxProvinceNameEN.Text= addressDetail.ProvinceName_EN;
                    tbxRegionCode.Text = addressDetail.RegionCode;
                    tbxRegionNEN.Text = addressDetail.RegionName_EN;
                    tbxCountryCode.Text = addressDetail.CountryCode;    
                    tbxCountryNameEN.Text = addressDetail.CountryName_EN;


                }
            }

            

        }

        private void DtpDeathDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDeathDate.CustomFormat = "dddd, dd MMMM,yyyy";
        }


        private bool validatePatientForm()
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

            // Site Code (Validation) 
            if (string.IsNullOrEmpty(tbxSiteCode.Text))
            {
                errorProvider.SetError(tbxSiteCode, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxSiteCode, string.Empty);
            }

            if (string.IsNullOrEmpty(tbxBloodGroup.Text))
            {
                errorProvider.SetError(tbxBloodGroup, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxBloodGroup, string.Empty);
            }


            if (string.IsNullOrEmpty(tbxG6PD.Text))
            {
                errorProvider.SetError(tbxG6PD, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxG6PD, string.Empty);
            }



            return isValid;
        }


        private void saveData()
        {
            try
            {
                if (validatePatientForm())
                {
                    MessageBox.Show("All required fields have been successfully filled!",
                                     "Fields Completed",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                    // Retrieve the selected gender as TINYINT (0 for Male, 1 for Female)
                    var selectedGender = cbxGender.SelectedIndex;
                                   

                    using (var context = new DatabaseConnection())
                    {
                        // Replace this with the actual PID you want to update
                        string pidToUpdate = tbxIDcard.Text;

                        // Retrieve the existing record
                        var existingPatient = context.Patients.SingleOrDefault(p => p.PID == pidToUpdate);

                        if (existingPatient != null)
                        {
                                                        
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

                            MessageBox.Show("The patient data has been saved successfully. You can now proceed with other tasks.",
                                  "Record Saved",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                        }
                        else
                        {
                            // Handle the case where the record was not found
                            MessageBox.Show("Patient record not found.");
                        }


                    }                              
                                      

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            saveData();
            loadData();
        }

        // Validate Address Form
        private bool validateAddressForm()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(tbxAddressCode.Text))
            {
                errorProvider.SetError(tbxAddressCode, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxAddressCode, string.Empty); // Clear error
            }


            if (string.IsNullOrEmpty(tbxSectionName.Text))
            {
                errorProvider.SetError(tbxSectionName, "This field is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbxSectionName, string.Empty); // Clear error
            }

            return isValid;
        }

        private void BtnUpdateAddress_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateAddressForm())
                {
                    using (var context = new DatabaseConnection())
                    {
                        // Replace this with the actual PID you want to update
                        string addressCodeToUpdate = tbxAddressCode.Text;

                        // Retrieve the existing record
                        var existingAddress = context.Addresses
                                                     .SingleOrDefault(p => p.AddressCode == addressCodeToUpdate);


                        if (existingAddress != null)
                        {
                            existingAddress.AddressCode = tbxAddressCode.Text;
                            existingAddress.SectionName_EN = tbxSectionName.Text;
                            existingAddress.VillageCode = tbxVillageCode.Text;
                            existingAddress.VillageName_EN = tbxVillageNEn.Text;
                            existingAddress.VillageName_MM = tbxVillageNMM.Text;
                            existingAddress.VillageName_KAREN = tbxVillageNKaren.Text;
                            existingAddress.VillageGPSLat = tbxVGPSLat.Text;
                            existingAddress.VillageGPSLong = tbxVGPSLong.Text;
                            existingAddress.SubdistrictCode = tbxSubDCode.Text;
                            existingAddress.SubdistrictName_EN = tbxSubDCode.Text;
                            existingAddress.DistrictCode = tbxDistrictCode.Text;
                            existingAddress.DistrictName_EN = tbxDistrictNEN.Text;
                            existingAddress.ProvinceCode = tbxProvinceCode.Text;
                            existingAddress.ProvinceName_EN = tbxProvinceNameEN.Text;
                            existingAddress.RegionCode = tbxRegionCode.Text;
                            existingAddress.RegionName_EN = tbxRegionNEN.Text;
                            existingAddress.CountryCode = tbxCountryCode.Text;
                            existingAddress.CountryName_EN = tbxCountryNameEN.Text;
                            context.SaveChanges();
                            MessageBox.Show("The patient's Address data has been saved successfully.",
                                  "Record Saved",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Handle the case where the record was not found
                            MessageBox.Show("Patient record not found.");
                        }

                    }
                                      
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
    }
}
