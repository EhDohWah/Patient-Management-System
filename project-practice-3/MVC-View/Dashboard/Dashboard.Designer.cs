namespace project_practice_3.MVC_View.Dashboard
{
    partial class Dashboard
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
            this.lblOPDTitle = new System.Windows.Forms.Label();
            this.pnlOPD = new System.Windows.Forms.Panel();
            this.lblOPDNO = new System.Windows.Forms.Label();
            this.lblPatientOPD = new System.Windows.Forms.Label();
            this.btnROG = new System.Windows.Forms.Button();
            this.pnlIPD = new System.Windows.Forms.Panel();
            this.lblIPDNo = new System.Windows.Forms.Label();
            this.lblIPDPatients = new System.Windows.Forms.Label();
            this.lblIPDTitle = new System.Windows.Forms.Label();
            this.btnOPD = new System.Windows.Forms.Button();
            this.btnIPD = new System.Windows.Forms.Button();
            this.gbxReport = new System.Windows.Forms.GroupBox();
            this.gbxbtns = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnGenerateIDCard = new System.Windows.Forms.Button();
            this.pnlOPD.SuspendLayout();
            this.pnlIPD.SuspendLayout();
            this.gbxReport.SuspendLayout();
            this.gbxbtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOPDTitle
            // 
            this.lblOPDTitle.AutoSize = true;
            this.lblOPDTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDTitle.Location = new System.Drawing.Point(22, 16);
            this.lblOPDTitle.Name = "lblOPDTitle";
            this.lblOPDTitle.Size = new System.Drawing.Size(74, 37);
            this.lblOPDTitle.TabIndex = 0;
            this.lblOPDTitle.Text = "OPD";
            // 
            // pnlOPD
            // 
            this.pnlOPD.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlOPD.Controls.Add(this.lblOPDNO);
            this.pnlOPD.Controls.Add(this.lblPatientOPD);
            this.pnlOPD.Controls.Add(this.lblOPDTitle);
            this.pnlOPD.Location = new System.Drawing.Point(25, 24);
            this.pnlOPD.Name = "pnlOPD";
            this.pnlOPD.Size = new System.Drawing.Size(234, 129);
            this.pnlOPD.TabIndex = 2;
            // 
            // lblOPDNO
            // 
            this.lblOPDNO.AutoSize = true;
            this.lblOPDNO.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDNO.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDNO.Location = new System.Drawing.Point(124, 40);
            this.lblOPDNO.Name = "lblOPDNO";
            this.lblOPDNO.Size = new System.Drawing.Size(60, 41);
            this.lblOPDNO.TabIndex = 1;
            this.lblOPDNO.Text = "No";
            // 
            // lblPatientOPD
            // 
            this.lblPatientOPD.AutoSize = true;
            this.lblPatientOPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientOPD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPatientOPD.Location = new System.Drawing.Point(128, 80);
            this.lblPatientOPD.Name = "lblPatientOPD";
            this.lblPatientOPD.Size = new System.Drawing.Size(83, 17);
            this.lblPatientOPD.TabIndex = 1;
            this.lblPatientOPD.Text = "PATIENTS";
            // 
            // btnROG
            // 
            this.btnROG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnROG.Location = new System.Drawing.Point(20, 19);
            this.btnROG.Name = "btnROG";
            this.btnROG.Size = new System.Drawing.Size(103, 33);
            this.btnROG.TabIndex = 0;
            this.btnROG.Text = "ROG";
            this.btnROG.UseVisualStyleBackColor = true;
            this.btnROG.Click += new System.EventHandler(this.BtnROG_Click);
            // 
            // pnlIPD
            // 
            this.pnlIPD.BackColor = System.Drawing.Color.LightCoral;
            this.pnlIPD.Controls.Add(this.lblIPDNo);
            this.pnlIPD.Controls.Add(this.lblIPDPatients);
            this.pnlIPD.Controls.Add(this.lblIPDTitle);
            this.pnlIPD.Location = new System.Drawing.Point(282, 24);
            this.pnlIPD.Name = "pnlIPD";
            this.pnlIPD.Size = new System.Drawing.Size(234, 129);
            this.pnlIPD.TabIndex = 2;
            // 
            // lblIPDNo
            // 
            this.lblIPDNo.AutoSize = true;
            this.lblIPDNo.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDNo.Location = new System.Drawing.Point(122, 40);
            this.lblIPDNo.Name = "lblIPDNo";
            this.lblIPDNo.Size = new System.Drawing.Size(60, 41);
            this.lblIPDNo.TabIndex = 1;
            this.lblIPDNo.Text = "No";
            // 
            // lblIPDPatients
            // 
            this.lblIPDPatients.AutoSize = true;
            this.lblIPDPatients.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDPatients.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDPatients.Location = new System.Drawing.Point(125, 79);
            this.lblIPDPatients.Name = "lblIPDPatients";
            this.lblIPDPatients.Size = new System.Drawing.Size(72, 19);
            this.lblIPDPatients.TabIndex = 1;
            this.lblIPDPatients.Text = "PATIENTS";
            // 
            // lblIPDTitle
            // 
            this.lblIPDTitle.AutoSize = true;
            this.lblIPDTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDTitle.Location = new System.Drawing.Point(22, 16);
            this.lblIPDTitle.Name = "lblIPDTitle";
            this.lblIPDTitle.Size = new System.Drawing.Size(63, 37);
            this.lblIPDTitle.TabIndex = 0;
            this.lblIPDTitle.Text = "IPD";
            // 
            // btnOPD
            // 
            this.btnOPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPD.Location = new System.Drawing.Point(146, 19);
            this.btnOPD.Name = "btnOPD";
            this.btnOPD.Size = new System.Drawing.Size(103, 33);
            this.btnOPD.TabIndex = 1;
            this.btnOPD.Text = "OPD";
            this.btnOPD.UseVisualStyleBackColor = true;
            this.btnOPD.Click += new System.EventHandler(this.BtnOPD_Click);
            // 
            // btnIPD
            // 
            this.btnIPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPD.Location = new System.Drawing.Point(272, 19);
            this.btnIPD.Name = "btnIPD";
            this.btnIPD.Size = new System.Drawing.Size(103, 33);
            this.btnIPD.TabIndex = 2;
            this.btnIPD.Text = "IPD";
            this.btnIPD.UseVisualStyleBackColor = true;
            this.btnIPD.Click += new System.EventHandler(this.BtnIPD_Click);
            // 
            // gbxReport
            // 
            this.gbxReport.Controls.Add(this.gbxbtns);
            this.gbxReport.Controls.Add(this.pnlIPD);
            this.gbxReport.Controls.Add(this.pnlOPD);
            this.gbxReport.Location = new System.Drawing.Point(12, 12);
            this.gbxReport.Name = "gbxReport";
            this.gbxReport.Size = new System.Drawing.Size(638, 266);
            this.gbxReport.TabIndex = 5;
            this.gbxReport.TabStop = false;
            this.gbxReport.Text = "Report";
            // 
            // gbxbtns
            // 
            this.gbxbtns.Controls.Add(this.btnGenerateIDCard);
            this.gbxbtns.Controls.Add(this.btnIPD);
            this.gbxbtns.Controls.Add(this.btnOPD);
            this.gbxbtns.Controls.Add(this.btnROG);
            this.gbxbtns.Location = new System.Drawing.Point(25, 172);
            this.gbxbtns.Name = "gbxbtns";
            this.gbxbtns.Size = new System.Drawing.Size(594, 67);
            this.gbxbtns.TabIndex = 6;
            this.gbxbtns.TabStop = false;
            this.gbxbtns.Text = "Menu";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnGenerateIDCard
            // 
            this.btnGenerateIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateIDCard.Location = new System.Drawing.Point(401, 19);
            this.btnGenerateIDCard.Name = "btnGenerateIDCard";
            this.btnGenerateIDCard.Size = new System.Drawing.Size(170, 33);
            this.btnGenerateIDCard.TabIndex = 2;
            this.btnGenerateIDCard.Text = "Generate ID Card";
            this.btnGenerateIDCard.UseVisualStyleBackColor = true;
            this.btnGenerateIDCard.Click += new System.EventHandler(this.BtnGenerateIDCard_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 289);
            this.Controls.Add(this.gbxReport);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnlOPD.ResumeLayout(false);
            this.pnlOPD.PerformLayout();
            this.pnlIPD.ResumeLayout(false);
            this.pnlIPD.PerformLayout();
            this.gbxReport.ResumeLayout(false);
            this.gbxbtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOPDTitle;
        private System.Windows.Forms.Panel pnlOPD;
        private System.Windows.Forms.Button btnROG;
        private System.Windows.Forms.Label lblPatientOPD;
        private System.Windows.Forms.Panel pnlIPD;
        private System.Windows.Forms.Label lblIPDNo;
        private System.Windows.Forms.Label lblIPDPatients;
        private System.Windows.Forms.Label lblIPDTitle;
        private System.Windows.Forms.Button btnOPD;
        private System.Windows.Forms.Button btnIPD;
        private System.Windows.Forms.Label lblOPDNO;
        private System.Windows.Forms.GroupBox gbxReport;
        private System.Windows.Forms.GroupBox gbxbtns;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnGenerateIDCard;
    }
}