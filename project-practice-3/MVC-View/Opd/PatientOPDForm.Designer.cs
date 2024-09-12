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
            this.lblOPDActive = new System.Windows.Forms.Label();
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
            this.gbxOPD.Location = new System.Drawing.Point(16, 15);
            this.gbxOPD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxOPD.Name = "gbxOPD";
            this.gbxOPD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxOPD.Size = new System.Drawing.Size(1013, 597);
            this.gbxOPD.TabIndex = 0;
            this.gbxOPD.TabStop = false;
            this.gbxOPD.Text = "OPD Records";
            // 
            // gpxPatientList
            // 
            this.gpxPatientList.Controls.Add(this.dgvOPDLists);
            this.gpxPatientList.Location = new System.Drawing.Point(8, 217);
            this.gpxPatientList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxPatientList.Name = "gpxPatientList";
            this.gpxPatientList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxPatientList.Size = new System.Drawing.Size(997, 373);
            this.gpxPatientList.TabIndex = 5;
            this.gpxPatientList.TabStop = false;
            this.gpxPatientList.Text = "Patient List";
            // 
            // dgvOPDLists
            // 
            this.dgvOPDLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPDLists.Location = new System.Drawing.Point(8, 23);
            this.dgvOPDLists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOPDLists.Name = "dgvOPDLists";
            this.dgvOPDLists.RowHeadersWidth = 51;
            this.dgvOPDLists.Size = new System.Drawing.Size(981, 342);
            this.dgvOPDLists.TabIndex = 4;
            this.dgvOPDLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOPDLists_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.lblActiveNo);
            this.panel1.Controls.Add(this.lblOPDActive);
            this.panel1.Controls.Add(this.lblOPDTitle);
            this.panel1.Location = new System.Drawing.Point(8, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 186);
            this.panel1.TabIndex = 3;
            // 
            // lblActiveNo
            // 
            this.lblActiveNo.AutoSize = true;
            this.lblActiveNo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActiveNo.Location = new System.Drawing.Point(234, 67);
            this.lblActiveNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveNo.Name = "lblActiveNo";
            this.lblActiveNo.Size = new System.Drawing.Size(74, 50);
            this.lblActiveNo.TabIndex = 1;
            this.lblActiveNo.Text = "No";
            // 
            // lblOPDActive
            // 
            this.lblOPDActive.AutoSize = true;
            this.lblOPDActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDActive.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDActive.Location = new System.Drawing.Point(197, 126);
            this.lblOPDActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPDActive.Name = "lblOPDActive";
            this.lblOPDActive.Size = new System.Drawing.Size(188, 29);
            this.lblOPDActive.TabIndex = 1;
            this.lblOPDActive.Text = "ACTIVE PATIENTS";
            // 
            // lblOPDTitle
            // 
            this.lblOPDTitle.AutoSize = true;
            this.lblOPDTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPDTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOPDTitle.Location = new System.Drawing.Point(25, 39);
            this.lblOPDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPDTitle.Name = "lblOPDTitle";
            this.lblOPDTitle.Size = new System.Drawing.Size(92, 46);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 626);
            this.Controls.Add(this.gbxOPD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblOPDTitle;
        private System.Windows.Forms.Label lblActiveNo;
        private System.Windows.Forms.Label lblOPDActive;
        private System.Windows.Forms.GroupBox gpxPatientList;
        private System.Windows.Forms.Timer timer;
    }
}