namespace project_practice_3.MVC_View.Ipd
{
    partial class IPD_Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPatientIPDDetail = new System.Windows.Forms.GroupBox();
            this.gbxDischargeDate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDischargeDate = new System.Windows.Forms.Label();
            this.dtpDischargeDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblAdmitDate = new System.Windows.Forms.Label();
            this.lblSiteCodeValue = new System.Windows.Forms.Label();
            this.lblSiteCode = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblPIDValue = new System.Windows.Forms.Label();
            this.lblAN1 = new System.Windows.Forms.Label();
            this.lblPatientName1 = new System.Windows.Forms.Label();
            this.lblANValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.gbxPatientTransfer = new System.Windows.Forms.GroupBox();
            this.tclPatientTransfer = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tbxIPD2Home = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tabPageHospital = new System.Windows.Forms.TabPage();
            this.tbxIPD2Hospital = new System.Windows.Forms.TextBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.btnTransferSave = new System.Windows.Forms.Button();
            this.cbxPatientTransfer = new System.Windows.Forms.ComboBox();
            this.lblPatientTransfer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlPatientIPDDetail.SuspendLayout();
            this.gbxDischargeDate.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            this.gbxPatientTransfer.SuspendLayout();
            this.tclPatientTransfer.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageHospital.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientIPDDetail
            // 
            this.pnlPatientIPDDetail.Controls.Add(this.gbxDischargeDate);
            this.pnlPatientIPDDetail.Controls.Add(this.lblDateValue);
            this.pnlPatientIPDDetail.Controls.Add(this.lblAdmitDate);
            this.pnlPatientIPDDetail.Controls.Add(this.lblSiteCodeValue);
            this.pnlPatientIPDDetail.Controls.Add(this.lblSiteCode);
            this.pnlPatientIPDDetail.Controls.Add(this.lblPatientID);
            this.pnlPatientIPDDetail.Controls.Add(this.gbxStatus);
            this.pnlPatientIPDDetail.Controls.Add(this.lblPIDValue);
            this.pnlPatientIPDDetail.Controls.Add(this.lblAN1);
            this.pnlPatientIPDDetail.Controls.Add(this.lblPatientName1);
            this.pnlPatientIPDDetail.Controls.Add(this.lblANValue);
            this.pnlPatientIPDDetail.Controls.Add(this.lblFullName);
            this.pnlPatientIPDDetail.Location = new System.Drawing.Point(12, 12);
            this.pnlPatientIPDDetail.Name = "pnlPatientIPDDetail";
            this.pnlPatientIPDDetail.Size = new System.Drawing.Size(358, 390);
            this.pnlPatientIPDDetail.TabIndex = 4;
            this.pnlPatientIPDDetail.TabStop = false;
            this.pnlPatientIPDDetail.Text = "IPD Detail";
            // 
            // gbxDischargeDate
            // 
            this.gbxDischargeDate.Controls.Add(this.btnUpdate);
            this.gbxDischargeDate.Controls.Add(this.lblDischargeDate);
            this.gbxDischargeDate.Controls.Add(this.dtpDischargeDate);
            this.gbxDischargeDate.Location = new System.Drawing.Point(25, 266);
            this.gbxDischargeDate.Name = "gbxDischargeDate";
            this.gbxDischargeDate.Size = new System.Drawing.Size(324, 112);
            this.gbxDischargeDate.TabIndex = 8;
            this.gbxDischargeDate.TabStop = false;
            this.gbxDischargeDate.Text = "Set Discharge Date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblDischargeDate
            // 
            this.lblDischargeDate.AutoSize = true;
            this.lblDischargeDate.Location = new System.Drawing.Point(10, 37);
            this.lblDischargeDate.Name = "lblDischargeDate";
            this.lblDischargeDate.Size = new System.Drawing.Size(81, 13);
            this.lblDischargeDate.TabIndex = 6;
            this.lblDischargeDate.Text = "Discharge Date";
            // 
            // dtpDischargeDate
            // 
            this.dtpDischargeDate.Location = new System.Drawing.Point(95, 37);
            this.dtpDischargeDate.Name = "dtpDischargeDate";
            this.dtpDischargeDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDischargeDate.TabIndex = 7;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Location = new System.Drawing.Point(91, 223);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(30, 13);
            this.lblDateValue.TabIndex = 5;
            this.lblDateValue.Text = "Date";
            // 
            // lblAdmitDate
            // 
            this.lblAdmitDate.AutoSize = true;
            this.lblAdmitDate.Location = new System.Drawing.Point(23, 223);
            this.lblAdmitDate.Name = "lblAdmitDate";
            this.lblAdmitDate.Size = new System.Drawing.Size(62, 13);
            this.lblAdmitDate.TabIndex = 5;
            this.lblAdmitDate.Text = "Admit Date:";
            // 
            // lblSiteCodeValue
            // 
            this.lblSiteCodeValue.AutoSize = true;
            this.lblSiteCodeValue.Location = new System.Drawing.Point(91, 198);
            this.lblSiteCodeValue.Name = "lblSiteCodeValue";
            this.lblSiteCodeValue.Size = new System.Drawing.Size(50, 13);
            this.lblSiteCodeValue.TabIndex = 5;
            this.lblSiteCodeValue.Text = "SiteCode";
            // 
            // lblSiteCode
            // 
            this.lblSiteCode.AutoSize = true;
            this.lblSiteCode.Location = new System.Drawing.Point(32, 198);
            this.lblSiteCode.Name = "lblSiteCode";
            this.lblSiteCode.Size = new System.Drawing.Size(53, 13);
            this.lblSiteCode.TabIndex = 5;
            this.lblSiteCode.Text = "SiteCode:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(55, 113);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(36, 19);
            this.lblPatientID.TabIndex = 0;
            this.lblPatientID.Text = "PID";
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.lblStatusValue);
            this.gbxStatus.Location = new System.Drawing.Point(25, 34);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(148, 65);
            this.gbxStatus.TabIndex = 4;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "Status";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.Location = new System.Drawing.Point(3, 16);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(78, 32);
            this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "Status";
            // 
            // lblPIDValue
            // 
            this.lblPIDValue.AutoSize = true;
            this.lblPIDValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIDValue.Location = new System.Drawing.Point(91, 113);
            this.lblPIDValue.Name = "lblPIDValue";
            this.lblPIDValue.Size = new System.Drawing.Size(27, 19);
            this.lblPIDValue.TabIndex = 0;
            this.lblPIDValue.Text = "NO";
            // 
            // lblAN1
            // 
            this.lblAN1.AutoSize = true;
            this.lblAN1.Location = new System.Drawing.Point(63, 148);
            this.lblAN1.Name = "lblAN1";
            this.lblAN1.Size = new System.Drawing.Size(22, 13);
            this.lblAN1.TabIndex = 1;
            this.lblAN1.Text = "AN";
            // 
            // lblPatientName1
            // 
            this.lblPatientName1.AutoSize = true;
            this.lblPatientName1.Location = new System.Drawing.Point(28, 173);
            this.lblPatientName1.Name = "lblPatientName1";
            this.lblPatientName1.Size = new System.Drawing.Size(57, 13);
            this.lblPatientName1.TabIndex = 1;
            this.lblPatientName1.Text = "Full Name:";
            // 
            // lblANValue
            // 
            this.lblANValue.AutoSize = true;
            this.lblANValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANValue.Location = new System.Drawing.Point(92, 148);
            this.lblANValue.Name = "lblANValue";
            this.lblANValue.Size = new System.Drawing.Size(24, 13);
            this.lblANValue.TabIndex = 1;
            this.lblANValue.Text = "AN";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(91, 173);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // gbxPatientTransfer
            // 
            this.gbxPatientTransfer.Controls.Add(this.tclPatientTransfer);
            this.gbxPatientTransfer.Controls.Add(this.btnTransferSave);
            this.gbxPatientTransfer.Controls.Add(this.cbxPatientTransfer);
            this.gbxPatientTransfer.Controls.Add(this.lblPatientTransfer);
            this.gbxPatientTransfer.Location = new System.Drawing.Point(376, 12);
            this.gbxPatientTransfer.Name = "gbxPatientTransfer";
            this.gbxPatientTransfer.Size = new System.Drawing.Size(469, 390);
            this.gbxPatientTransfer.TabIndex = 5;
            this.gbxPatientTransfer.TabStop = false;
            this.gbxPatientTransfer.Text = "Patient Transfer Form";
            // 
            // tclPatientTransfer
            // 
            this.tclPatientTransfer.Controls.Add(this.tabPageHome);
            this.tclPatientTransfer.Controls.Add(this.tabPageHospital);
            this.tclPatientTransfer.Location = new System.Drawing.Point(15, 84);
            this.tclPatientTransfer.Name = "tclPatientTransfer";
            this.tclPatientTransfer.SelectedIndex = 0;
            this.tclPatientTransfer.Size = new System.Drawing.Size(437, 249);
            this.tclPatientTransfer.TabIndex = 4;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.tbxIPD2Home);
            this.tabPageHome.Controls.Add(this.lblNote);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(429, 223);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tbxIPD2Home
            // 
            this.tbxIPD2Home.Location = new System.Drawing.Point(49, 20);
            this.tbxIPD2Home.Multiline = true;
            this.tbxIPD2Home.Name = "tbxIPD2Home";
            this.tbxIPD2Home.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxIPD2Home.Size = new System.Drawing.Size(361, 182);
            this.tbxIPD2Home.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(15, 23);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Note";
            // 
            // tabPageHospital
            // 
            this.tabPageHospital.Controls.Add(this.tbxIPD2Hospital);
            this.tabPageHospital.Controls.Add(this.lblHospital);
            this.tabPageHospital.Location = new System.Drawing.Point(4, 22);
            this.tabPageHospital.Name = "tabPageHospital";
            this.tabPageHospital.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHospital.Size = new System.Drawing.Size(429, 223);
            this.tabPageHospital.TabIndex = 1;
            this.tabPageHospital.Text = "Hospital";
            this.tabPageHospital.UseVisualStyleBackColor = true;
            // 
            // tbxIPD2Hospital
            // 
            this.tbxIPD2Hospital.Location = new System.Drawing.Point(51, 20);
            this.tbxIPD2Hospital.Multiline = true;
            this.tbxIPD2Hospital.Name = "tbxIPD2Hospital";
            this.tbxIPD2Hospital.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxIPD2Hospital.Size = new System.Drawing.Size(361, 182);
            this.tbxIPD2Hospital.TabIndex = 3;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Location = new System.Drawing.Point(17, 23);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(30, 13);
            this.lblHospital.TabIndex = 2;
            this.lblHospital.Text = "Note";
            // 
            // btnTransferSave
            // 
            this.btnTransferSave.Location = new System.Drawing.Point(335, 34);
            this.btnTransferSave.Name = "btnTransferSave";
            this.btnTransferSave.Size = new System.Drawing.Size(113, 44);
            this.btnTransferSave.TabIndex = 1;
            this.btnTransferSave.Text = "Transfer";
            this.btnTransferSave.UseVisualStyleBackColor = true;
            this.btnTransferSave.Click += new System.EventHandler(this.BtnTransferSave_Click);
            // 
            // cbxPatientTransfer
            // 
            this.cbxPatientTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPatientTransfer.FormattingEnabled = true;
            this.cbxPatientTransfer.Items.AddRange(new object[] {
            "Home",
            "Hospital"});
            this.cbxPatientTransfer.Location = new System.Drawing.Point(120, 34);
            this.cbxPatientTransfer.Name = "cbxPatientTransfer";
            this.cbxPatientTransfer.Size = new System.Drawing.Size(86, 24);
            this.cbxPatientTransfer.TabIndex = 3;
            this.cbxPatientTransfer.SelectedIndexChanged += new System.EventHandler(this.CbxPatientTransfer_SelectedIndexChanged);
            // 
            // lblPatientTransfer
            // 
            this.lblPatientTransfer.AutoSize = true;
            this.lblPatientTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTransfer.Location = new System.Drawing.Point(12, 39);
            this.lblPatientTransfer.Name = "lblPatientTransfer";
            this.lblPatientTransfer.Size = new System.Drawing.Size(102, 13);
            this.lblPatientTransfer.TabIndex = 2;
            this.lblPatientTransfer.Text = "TRANSFER TO :";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // IPD_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 412);
            this.Controls.Add(this.gbxPatientTransfer);
            this.Controls.Add(this.pnlPatientIPDDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IPD_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPD_Record";
            this.pnlPatientIPDDetail.ResumeLayout(false);
            this.pnlPatientIPDDetail.PerformLayout();
            this.gbxDischargeDate.ResumeLayout(false);
            this.gbxDischargeDate.PerformLayout();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.gbxPatientTransfer.ResumeLayout(false);
            this.gbxPatientTransfer.PerformLayout();
            this.tclPatientTransfer.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageHospital.ResumeLayout(false);
            this.tabPageHospital.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox pnlPatientIPDDetail;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblAdmitDate;
        private System.Windows.Forms.Label lblSiteCodeValue;
        private System.Windows.Forms.Label lblSiteCode;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblPIDValue;
        private System.Windows.Forms.Label lblPatientName1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox gbxPatientTransfer;
        private System.Windows.Forms.Button btnTransferSave;
        private System.Windows.Forms.ComboBox cbxPatientTransfer;
        private System.Windows.Forms.Label lblPatientTransfer;
        private System.Windows.Forms.Label lblAN1;
        private System.Windows.Forms.Label lblANValue;
        private System.Windows.Forms.GroupBox gbxDischargeDate;
        private System.Windows.Forms.DateTimePicker dtpDischargeDate;
        private System.Windows.Forms.Label lblDischargeDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tclPatientTransfer;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageHospital;
        private System.Windows.Forms.TextBox tbxIPD2Home;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbxIPD2Hospital;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Timer timer;
    }
}