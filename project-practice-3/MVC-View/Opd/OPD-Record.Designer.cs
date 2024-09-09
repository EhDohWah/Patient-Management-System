namespace project_practice_3.MVC_View.Opd
{
    partial class OPD_Record
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
            this.gbxPatientTransfer = new System.Windows.Forms.GroupBox();
            this.tclPatientTransfer = new System.Windows.Forms.TabControl();
            this.tabPageIPD = new System.Windows.Forms.TabPage();
            this.tbxIPDAN = new System.Windows.Forms.TextBox();
            this.lblSiteCodeIPD = new System.Windows.Forms.Label();
            this.dtpAdmitDate = new System.Windows.Forms.DateTimePicker();
            this.tbxIPDSiteCode = new System.Windows.Forms.TextBox();
            this.lblAadmitD = new System.Windows.Forms.Label();
            this.lblAN = new System.Windows.Forms.Label();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tabPageHospital = new System.Windows.Forms.TabPage();
            this.txbHospital = new System.Windows.Forms.TextBox();
            this.lblHospitalNote = new System.Windows.Forms.Label();
            this.btnTransferSave = new System.Windows.Forms.Button();
            this.cbxPatientTransfer = new System.Windows.Forms.ComboBox();
            this.lblPatientTransfer = new System.Windows.Forms.Label();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPIDValue = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.pnlPatientOPDDetail = new System.Windows.Forms.GroupBox();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.tbxReasonVisit = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblReasonVisit = new System.Windows.Forms.Label();
            this.lblAdmitDate = new System.Windows.Forms.Label();
            this.lblSiteCodeValue = new System.Windows.Forms.Label();
            this.lblSiteCode = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbxPatientTransfer.SuspendLayout();
            this.tclPatientTransfer.SuspendLayout();
            this.tabPageIPD.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageHospital.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            this.pnlPatientOPDDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPatientTransfer
            // 
            this.gbxPatientTransfer.Controls.Add(this.tclPatientTransfer);
            this.gbxPatientTransfer.Controls.Add(this.btnTransferSave);
            this.gbxPatientTransfer.Controls.Add(this.cbxPatientTransfer);
            this.gbxPatientTransfer.Controls.Add(this.lblPatientTransfer);
            this.gbxPatientTransfer.Location = new System.Drawing.Point(442, 12);
            this.gbxPatientTransfer.Name = "gbxPatientTransfer";
            this.gbxPatientTransfer.Size = new System.Drawing.Size(371, 426);
            this.gbxPatientTransfer.TabIndex = 0;
            this.gbxPatientTransfer.TabStop = false;
            this.gbxPatientTransfer.Text = "Patient Transfer Form";
            // 
            // tclPatientTransfer
            // 
            this.tclPatientTransfer.Controls.Add(this.tabPageIPD);
            this.tclPatientTransfer.Controls.Add(this.tabPageHome);
            this.tclPatientTransfer.Controls.Add(this.tabPageHospital);
            this.tclPatientTransfer.Location = new System.Drawing.Point(20, 71);
            this.tclPatientTransfer.Name = "tclPatientTransfer";
            this.tclPatientTransfer.SelectedIndex = 0;
            this.tclPatientTransfer.Size = new System.Drawing.Size(345, 283);
            this.tclPatientTransfer.TabIndex = 4;
            // 
            // tabPageIPD
            // 
            this.tabPageIPD.Controls.Add(this.tbxIPDAN);
            this.tabPageIPD.Controls.Add(this.lblSiteCodeIPD);
            this.tabPageIPD.Controls.Add(this.dtpAdmitDate);
            this.tabPageIPD.Controls.Add(this.tbxIPDSiteCode);
            this.tabPageIPD.Controls.Add(this.lblAadmitD);
            this.tabPageIPD.Controls.Add(this.lblAN);
            this.tabPageIPD.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPD.Name = "tabPageIPD";
            this.tabPageIPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPD.Size = new System.Drawing.Size(337, 257);
            this.tabPageIPD.TabIndex = 0;
            this.tabPageIPD.Text = "IPD";
            this.tabPageIPD.UseVisualStyleBackColor = true;
            // 
            // tbxIPDAN
            // 
            this.tbxIPDAN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIPDAN.Location = new System.Drawing.Point(72, 20);
            this.tbxIPDAN.Name = "tbxIPDAN";
            this.tbxIPDAN.Size = new System.Drawing.Size(115, 25);
            this.tbxIPDAN.TabIndex = 41;
            // 
            // lblSiteCodeIPD
            // 
            this.lblSiteCodeIPD.AutoSize = true;
            this.lblSiteCodeIPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteCodeIPD.Location = new System.Drawing.Point(6, 56);
            this.lblSiteCodeIPD.Name = "lblSiteCodeIPD";
            this.lblSiteCodeIPD.Size = new System.Drawing.Size(60, 15);
            this.lblSiteCodeIPD.TabIndex = 44;
            this.lblSiteCodeIPD.Text = "Site Code";
            // 
            // dtpAdmitDate
            // 
            this.dtpAdmitDate.Location = new System.Drawing.Point(72, 84);
            this.dtpAdmitDate.Name = "dtpAdmitDate";
            this.dtpAdmitDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAdmitDate.TabIndex = 43;
            // 
            // tbxIPDSiteCode
            // 
            this.tbxIPDSiteCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIPDSiteCode.Location = new System.Drawing.Point(72, 52);
            this.tbxIPDSiteCode.Name = "tbxIPDSiteCode";
            this.tbxIPDSiteCode.Size = new System.Drawing.Size(115, 25);
            this.tbxIPDSiteCode.TabIndex = 42;
            // 
            // lblAadmitD
            // 
            this.lblAadmitD.AutoSize = true;
            this.lblAadmitD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAadmitD.Location = new System.Drawing.Point(-1, 86);
            this.lblAadmitD.Name = "lblAadmitD";
            this.lblAadmitD.Size = new System.Drawing.Size(67, 15);
            this.lblAadmitD.TabIndex = 46;
            this.lblAadmitD.Text = "Admit Date";
            // 
            // lblAN
            // 
            this.lblAN.AutoSize = true;
            this.lblAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAN.Location = new System.Drawing.Point(43, 26);
            this.lblAN.Name = "lblAN";
            this.lblAN.Size = new System.Drawing.Size(23, 15);
            this.lblAN.TabIndex = 45;
            this.lblAN.Text = "AN";
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.tbxHome);
            this.tabPageHome.Controls.Add(this.lblNotes);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(337, 257);
            this.tabPageHome.TabIndex = 1;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tbxHome
            // 
            this.tbxHome.Location = new System.Drawing.Point(56, 37);
            this.tbxHome.Multiline = true;
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(268, 177);
            this.tbxHome.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(15, 40);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(30, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Note";
            // 
            // tabPageHospital
            // 
            this.tabPageHospital.Controls.Add(this.txbHospital);
            this.tabPageHospital.Controls.Add(this.lblHospitalNote);
            this.tabPageHospital.Location = new System.Drawing.Point(4, 22);
            this.tabPageHospital.Name = "tabPageHospital";
            this.tabPageHospital.Size = new System.Drawing.Size(337, 257);
            this.tabPageHospital.TabIndex = 2;
            this.tabPageHospital.Text = "Hospital";
            this.tabPageHospital.UseVisualStyleBackColor = true;
            // 
            // txbHospital
            // 
            this.txbHospital.Location = new System.Drawing.Point(55, 40);
            this.txbHospital.Multiline = true;
            this.txbHospital.Name = "txbHospital";
            this.txbHospital.Size = new System.Drawing.Size(268, 177);
            this.txbHospital.TabIndex = 3;
            // 
            // lblHospitalNote
            // 
            this.lblHospitalNote.AutoSize = true;
            this.lblHospitalNote.Location = new System.Drawing.Point(14, 43);
            this.lblHospitalNote.Name = "lblHospitalNote";
            this.lblHospitalNote.Size = new System.Drawing.Size(30, 13);
            this.lblHospitalNote.TabIndex = 2;
            this.lblHospitalNote.Text = "Note";
            // 
            // btnTransferSave
            // 
            this.btnTransferSave.Location = new System.Drawing.Point(252, 356);
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
            "IPD",
            "Home",
            "Hospital"});
            this.cbxPatientTransfer.Location = new System.Drawing.Point(125, 29);
            this.cbxPatientTransfer.Name = "cbxPatientTransfer";
            this.cbxPatientTransfer.Size = new System.Drawing.Size(86, 24);
            this.cbxPatientTransfer.TabIndex = 3;
            this.cbxPatientTransfer.SelectedIndexChanged += new System.EventHandler(this.CbxPatientTransfer_SelectedIndexChanged);
            // 
            // lblPatientTransfer
            // 
            this.lblPatientTransfer.AutoSize = true;
            this.lblPatientTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTransfer.Location = new System.Drawing.Point(17, 34);
            this.lblPatientTransfer.Name = "lblPatientTransfer";
            this.lblPatientTransfer.Size = new System.Drawing.Size(102, 13);
            this.lblPatientTransfer.TabIndex = 2;
            this.lblPatientTransfer.Text = "TRANSFER TO :";
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
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(91, 142);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(35, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Name";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(28, 142);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(57, 13);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Full Name:";
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
            // pnlPatientOPDDetail
            // 
            this.pnlPatientOPDDetail.Controls.Add(this.tbxNote);
            this.pnlPatientOPDDetail.Controls.Add(this.tbxReasonVisit);
            this.pnlPatientOPDDetail.Controls.Add(this.lblNote);
            this.pnlPatientOPDDetail.Controls.Add(this.lblDateValue);
            this.pnlPatientOPDDetail.Controls.Add(this.lblReasonVisit);
            this.pnlPatientOPDDetail.Controls.Add(this.lblAdmitDate);
            this.pnlPatientOPDDetail.Controls.Add(this.lblSiteCodeValue);
            this.pnlPatientOPDDetail.Controls.Add(this.lblSiteCode);
            this.pnlPatientOPDDetail.Controls.Add(this.lblPatientID);
            this.pnlPatientOPDDetail.Controls.Add(this.gbxStatus);
            this.pnlPatientOPDDetail.Controls.Add(this.lblPIDValue);
            this.pnlPatientOPDDetail.Controls.Add(this.lblPatientName);
            this.pnlPatientOPDDetail.Controls.Add(this.lblFullName);
            this.pnlPatientOPDDetail.Location = new System.Drawing.Point(12, 12);
            this.pnlPatientOPDDetail.Name = "pnlPatientOPDDetail";
            this.pnlPatientOPDDetail.Size = new System.Drawing.Size(424, 426);
            this.pnlPatientOPDDetail.TabIndex = 1;
            this.pnlPatientOPDDetail.TabStop = false;
            this.pnlPatientOPDDetail.Text = "OPD Detail";
            // 
            // tbxNote
            // 
            this.tbxNote.Location = new System.Drawing.Point(94, 322);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.ReadOnly = true;
            this.tbxNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxNote.Size = new System.Drawing.Size(307, 86);
            this.tbxNote.TabIndex = 6;
            // 
            // tbxReasonVisit
            // 
            this.tbxReasonVisit.Location = new System.Drawing.Point(94, 221);
            this.tbxReasonVisit.Multiline = true;
            this.tbxReasonVisit.Name = "tbxReasonVisit";
            this.tbxReasonVisit.ReadOnly = true;
            this.tbxReasonVisit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxReasonVisit.Size = new System.Drawing.Size(307, 86);
            this.tbxReasonVisit.TabIndex = 6;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(55, 325);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Location = new System.Drawing.Point(91, 193);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(30, 13);
            this.lblDateValue.TabIndex = 5;
            this.lblDateValue.Text = "Date";
            // 
            // lblReasonVisit
            // 
            this.lblReasonVisit.AutoSize = true;
            this.lblReasonVisit.Location = new System.Drawing.Point(16, 221);
            this.lblReasonVisit.Name = "lblReasonVisit";
            this.lblReasonVisit.Size = new System.Drawing.Size(66, 13);
            this.lblReasonVisit.TabIndex = 5;
            this.lblReasonVisit.Text = "Reason Visit";
            // 
            // lblAdmitDate
            // 
            this.lblAdmitDate.AutoSize = true;
            this.lblAdmitDate.Location = new System.Drawing.Point(23, 193);
            this.lblAdmitDate.Name = "lblAdmitDate";
            this.lblAdmitDate.Size = new System.Drawing.Size(62, 13);
            this.lblAdmitDate.TabIndex = 5;
            this.lblAdmitDate.Text = "Admit Date:";
            // 
            // lblSiteCodeValue
            // 
            this.lblSiteCodeValue.AutoSize = true;
            this.lblSiteCodeValue.Location = new System.Drawing.Point(91, 168);
            this.lblSiteCodeValue.Name = "lblSiteCodeValue";
            this.lblSiteCodeValue.Size = new System.Drawing.Size(50, 13);
            this.lblSiteCodeValue.TabIndex = 5;
            this.lblSiteCodeValue.Text = "SiteCode";
            // 
            // lblSiteCode
            // 
            this.lblSiteCode.AutoSize = true;
            this.lblSiteCode.Location = new System.Drawing.Point(32, 168);
            this.lblSiteCode.Name = "lblSiteCode";
            this.lblSiteCode.Size = new System.Drawing.Size(53, 13);
            this.lblSiteCode.TabIndex = 5;
            this.lblSiteCode.Text = "SiteCode:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // OPD_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.pnlPatientOPDDetail);
            this.Controls.Add(this.gbxPatientTransfer);
            this.Name = "OPD_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OPD_Record";
            this.gbxPatientTransfer.ResumeLayout(false);
            this.gbxPatientTransfer.PerformLayout();
            this.tclPatientTransfer.ResumeLayout(false);
            this.tabPageIPD.ResumeLayout(false);
            this.tabPageIPD.PerformLayout();
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageHospital.ResumeLayout(false);
            this.tabPageHospital.PerformLayout();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.pnlPatientOPDDetail.ResumeLayout(false);
            this.pnlPatientOPDDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPatientTransfer;
        private System.Windows.Forms.Button btnTransferSave;
        private System.Windows.Forms.Label lblPatientTransfer;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.ComboBox cbxPatientTransfer;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPIDValue;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.GroupBox pnlPatientOPDDetail;
        private System.Windows.Forms.Label lblAdmitDate;
        private System.Windows.Forms.Label lblSiteCodeValue;
        private System.Windows.Forms.Label lblSiteCode;
        private System.Windows.Forms.TextBox tbxReasonVisit;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblReasonVisit;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TabControl tclPatientTransfer;
        private System.Windows.Forms.TabPage tabPageIPD;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageHospital;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txbHospital;
        private System.Windows.Forms.Label lblHospitalNote;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxIPDAN;
        private System.Windows.Forms.Label lblSiteCodeIPD;
        private System.Windows.Forms.DateTimePicker dtpAdmitDate;
        private System.Windows.Forms.TextBox tbxIPDSiteCode;
        private System.Windows.Forms.Label lblAadmitD;
        private System.Windows.Forms.Label lblAN;
        private System.Windows.Forms.Timer timer;
    }
}