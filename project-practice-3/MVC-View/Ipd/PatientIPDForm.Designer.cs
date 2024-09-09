namespace project_practice_3.MVC_View.Ipd
{
    partial class PatientIPDForm
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
            this.gbxIPD = new System.Windows.Forms.GroupBox();
            this.pnlIPD = new System.Windows.Forms.Panel();
            this.lblIPDActiveNo = new System.Windows.Forms.Label();
            this.lblIPDNO = new System.Windows.Forms.Label();
            this.lblIPDActive = new System.Windows.Forms.Label();
            this.lblPatientIPD = new System.Windows.Forms.Label();
            this.lblIPDTitle = new System.Windows.Forms.Label();
            this.dgvIPDLists = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbxIPD.SuspendLayout();
            this.pnlIPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPDLists)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxIPD
            // 
            this.gbxIPD.Controls.Add(this.pnlIPD);
            this.gbxIPD.Controls.Add(this.dgvIPDLists);
            this.gbxIPD.Location = new System.Drawing.Point(12, 12);
            this.gbxIPD.Name = "gbxIPD";
            this.gbxIPD.Size = new System.Drawing.Size(653, 465);
            this.gbxIPD.TabIndex = 1;
            this.gbxIPD.TabStop = false;
            this.gbxIPD.Text = "IPD Records";
            // 
            // pnlIPD
            // 
            this.pnlIPD.BackColor = System.Drawing.Color.LightCoral;
            this.pnlIPD.Controls.Add(this.lblIPDActiveNo);
            this.pnlIPD.Controls.Add(this.lblIPDNO);
            this.pnlIPD.Controls.Add(this.lblIPDActive);
            this.pnlIPD.Controls.Add(this.lblPatientIPD);
            this.pnlIPD.Controls.Add(this.lblIPDTitle);
            this.pnlIPD.Location = new System.Drawing.Point(6, 19);
            this.pnlIPD.Name = "pnlIPD";
            this.pnlIPD.Size = new System.Drawing.Size(297, 151);
            this.pnlIPD.TabIndex = 5;
            // 
            // lblIPDActiveNo
            // 
            this.lblIPDActiveNo.AutoSize = true;
            this.lblIPDActiveNo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDActiveNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDActiveNo.Location = new System.Drawing.Point(236, 58);
            this.lblIPDActiveNo.Name = "lblIPDActiveNo";
            this.lblIPDActiveNo.Size = new System.Drawing.Size(58, 40);
            this.lblIPDActiveNo.TabIndex = 1;
            this.lblIPDActiveNo.Text = "No";
            // 
            // lblIPDNO
            // 
            this.lblIPDNO.AutoSize = true;
            this.lblIPDNO.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDNO.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDNO.Location = new System.Drawing.Point(129, 58);
            this.lblIPDNO.Name = "lblIPDNO";
            this.lblIPDNO.Size = new System.Drawing.Size(58, 40);
            this.lblIPDNO.TabIndex = 1;
            this.lblIPDNO.Text = "No";
            // 
            // lblIPDActive
            // 
            this.lblIPDActive.AutoSize = true;
            this.lblIPDActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDActive.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDActive.Location = new System.Drawing.Point(221, 104);
            this.lblIPDActive.Name = "lblIPDActive";
            this.lblIPDActive.Size = new System.Drawing.Size(53, 17);
            this.lblIPDActive.TabIndex = 1;
            this.lblIPDActive.Text = "ACTIVE";
            // 
            // lblPatientIPD
            // 
            this.lblPatientIPD.AutoSize = true;
            this.lblPatientIPD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientIPD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPatientIPD.Location = new System.Drawing.Point(122, 104);
            this.lblPatientIPD.Name = "lblPatientIPD";
            this.lblPatientIPD.Size = new System.Drawing.Size(48, 17);
            this.lblPatientIPD.TabIndex = 1;
            this.lblPatientIPD.Text = "TOTAL";
            // 
            // lblIPDTitle
            // 
            this.lblIPDTitle.AutoSize = true;
            this.lblIPDTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPDTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPDTitle.Location = new System.Drawing.Point(19, 32);
            this.lblIPDTitle.Name = "lblIPDTitle";
            this.lblIPDTitle.Size = new System.Drawing.Size(63, 37);
            this.lblIPDTitle.TabIndex = 0;
            this.lblIPDTitle.Text = "IPD";
            // 
            // dgvIPDLists
            // 
            this.dgvIPDLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIPDLists.Location = new System.Drawing.Point(6, 176);
            this.dgvIPDLists.Name = "dgvIPDLists";
            this.dgvIPDLists.Size = new System.Drawing.Size(637, 278);
            this.dgvIPDLists.TabIndex = 4;
            this.dgvIPDLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIPDLists_CellClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PatientIPDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 485);
            this.Controls.Add(this.gbxIPD);
            this.Name = "PatientIPDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientIPDForm";
            this.gbxIPD.ResumeLayout(false);
            this.pnlIPD.ResumeLayout(false);
            this.pnlIPD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPDLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIPD;
        private System.Windows.Forms.DataGridView dgvIPDLists;
        private System.Windows.Forms.Panel pnlIPD;
        private System.Windows.Forms.Label lblIPDActiveNo;
        private System.Windows.Forms.Label lblIPDNO;
        private System.Windows.Forms.Label lblIPDActive;
        private System.Windows.Forms.Label lblPatientIPD;
        private System.Windows.Forms.Label lblIPDTitle;
        private System.Windows.Forms.Timer timer;
    }
}