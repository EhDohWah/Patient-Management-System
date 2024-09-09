namespace project_practice_3.MVC_View.Opd
{
    partial class PatientOPDForm
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
            this.gbxOPD = new System.Windows.Forms.GroupBox();
            this.gpxPatientList = new System.Windows.Forms.GroupBox();
            this.dgvOPDLists = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActiveNo = new System.Windows.Forms.Label();
            this.lblOPDNO = new System.Windows.Forms.Label();
            this.lblOPDActive = new System.Windows.Forms.Label();
            this.lblPatientOPD = new System.Windows.Forms.Label();
            this.lblOPDTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbxOPD.SuspendLayout();
            this.gpxPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPDLists)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOPD
            // 
            this.gbxOPD.Controls.Add(this.gpxPatientList);
            this.gbxOPD.Controls.Add(this.panel1);
            this.gbxOPD.Location = new System.Drawing.Point(12, 12);
            this.gbxOPD.Name = "gbxOPD";
            this.gbxOPD.Size = new System.Drawing.Size(760, 485);
            this.gbxOPD.TabIndex = 0;
            this.gbxOPD.TabStop = false;
            this.gbxOPD.Text = "OPD Records";
            // 
            // gpxPatientList
            // 
            this.gpxPatientList.Controls.Add(this.dgvOPDLists);
            this.gpxPatientList.Location = new System.Drawing.Point(6, 176);
            this.gpxPatientList.Name = "gpxPatientList";
            this.gpxPatientList.Size = new System.Drawing.Size(748, 303);
            this.gpxPatientList.TabIndex = 5;
            this.gpxPatientList.TabStop = false;
            this.gpxPatientList.Text = "Patient List";
            // 
            // dgvOPDLists
            // 
            this.dgvOPDLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPDLists.Location = new System.Drawing.Point(6, 19);
            this.dgvOPDLists.Name = "dgvOPDLists";
            this.dgvOPDLists.Size = new System.Drawing.Size(736, 278);
            this.dgvOPDLists.TabIndex = 4;
            this.dgvOPDLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOPDLists_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.lblActiveNo);
            this.panel1.Controls.Add(this.lblOPDNO);
            this.panel1.Controls.Add(this.lblOPDActive);
            this.panel1.Controls.Add(this.lblPatientOPD);
            this.panel1.Controls.Add(this.lblOPDTitle);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 151);
            this.panel1.TabIndex = 3;
            // 
            // lblActiveNo
            // 
            this.lblActiveNo.AutoSize = true;
            this.lblActiveNo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActiveNo.Location = new System.Drawing.Point(236, 58);
            this.lblActiveNo.Name = "lblActiveNo";
            this.lblActiveNo.Size = new System.Drawing.Size(58, 40);
            this.lblActiveNo.TabIndex = 1;
            this.lblActiveNo.Text = "No";
            // 
            // lblOPDNO
            // 
            this.lblOPDNO.AutoSize = true;
            this.lblOPDNO.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDNO.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDNO.Location = new System.Drawing.Point(129, 58);
            this.lblOPDNO.Name = "lblOPDNO";
            this.lblOPDNO.Size = new System.Drawing.Size(58, 40);
            this.lblOPDNO.TabIndex = 1;
            this.lblOPDNO.Text = "No";
            // 
            // lblOPDActive
            // 
            this.lblOPDActive.AutoSize = true;
            this.lblOPDActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDActive.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDActive.Location = new System.Drawing.Point(221, 104);
            this.lblOPDActive.Name = "lblOPDActive";
            this.lblOPDActive.Size = new System.Drawing.Size(53, 17);
            this.lblOPDActive.TabIndex = 1;
            this.lblOPDActive.Text = "ACTIVE";
            // 
            // lblPatientOPD
            // 
            this.lblPatientOPD.AutoSize = true;
            this.lblPatientOPD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientOPD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPatientOPD.Location = new System.Drawing.Point(122, 104);
            this.lblPatientOPD.Name = "lblPatientOPD";
            this.lblPatientOPD.Size = new System.Drawing.Size(48, 17);
            this.lblPatientOPD.TabIndex = 1;
            this.lblPatientOPD.Text = "TOTAL";
            // 
            // lblOPDTitle
            // 
            this.lblOPDTitle.AutoSize = true;
            this.lblOPDTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDTitle.Location = new System.Drawing.Point(19, 32);
            this.lblOPDTitle.Name = "lblOPDTitle";
            this.lblOPDTitle.Size = new System.Drawing.Size(74, 37);
            this.lblOPDTitle.TabIndex = 0;
            this.lblOPDTitle.Text = "OPD";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PatientOPDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 509);
            this.Controls.Add(this.gbxOPD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PatientOPDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient-OPD-Form";
            this.gbxOPD.ResumeLayout(false);
            this.gpxPatientList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPDLists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOPD;
        private System.Windows.Forms.DataGridView dgvOPDLists;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOPDNO;
        private System.Windows.Forms.Label lblPatientOPD;
        private System.Windows.Forms.Label lblOPDTitle;
        private System.Windows.Forms.Label lblActiveNo;
        private System.Windows.Forms.Label lblOPDActive;
        private System.Windows.Forms.GroupBox gpxPatientList;
        private System.Windows.Forms.Timer timer;
    }
}