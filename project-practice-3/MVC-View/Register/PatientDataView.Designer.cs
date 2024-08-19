namespace project_practice_3.MVC_View.Register
{
    partial class PatientRecordForm
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
            this.gbxRecordDetail = new System.Windows.Forms.GroupBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIDcard = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.gbxOpdFindings = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.gbxRecordDetail.SuspendLayout();
            this.gbxOpdFindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRecordDetail
            // 
            this.gbxRecordDetail.Controls.Add(this.lblPhoneNum);
            this.gbxRecordDetail.Controls.Add(this.lblDOB);
            this.gbxRecordDetail.Controls.Add(this.lblGender);
            this.gbxRecordDetail.Controls.Add(this.lblIDcard);
            this.gbxRecordDetail.Controls.Add(this.lblFullName);
            this.gbxRecordDetail.Location = new System.Drawing.Point(12, 12);
            this.gbxRecordDetail.Name = "gbxRecordDetail";
            this.gbxRecordDetail.Size = new System.Drawing.Size(340, 187);
            this.gbxRecordDetail.TabIndex = 0;
            this.gbxRecordDetail.TabStop = false;
            this.gbxRecordDetail.Text = "Record Detail";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(0, 141);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(88, 15);
            this.lblPhoneNum.TabIndex = 44;
            this.lblPhoneNum.Text = "PhoneNumber";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(14, 114);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(74, 15);
            this.lblDOB.TabIndex = 43;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(40, 87);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 42;
            this.lblGender.Text = "Gender";
            // 
            // lblIDcard
            // 
            this.lblIDcard.AutoSize = true;
            this.lblIDcard.Location = new System.Drawing.Point(48, 35);
            this.lblIDcard.Name = "lblIDcard";
            this.lblIDcard.Size = new System.Drawing.Size(40, 13);
            this.lblIDcard.TabIndex = 41;
            this.lblIDcard.Text = "IDCard";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(24, 60);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 15);
            this.lblFullName.TabIndex = 38;
            this.lblFullName.Text = "Full Name";
            // 
            // gbxOpdFindings
            // 
            this.gbxOpdFindings.Controls.Add(this.dataGridView1);
            this.gbxOpdFindings.Location = new System.Drawing.Point(12, 205);
            this.gbxOpdFindings.Name = "gbxOpdFindings";
            this.gbxOpdFindings.Size = new System.Drawing.Size(761, 282);
            this.gbxOpdFindings.TabIndex = 2;
            this.gbxOpdFindings.TabStop = false;
            this.gbxOpdFindings.Text = "OPD Findings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(749, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCheckin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.Color.Black;
            this.btnCheckin.Location = new System.Drawing.Point(358, 18);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(103, 42);
            this.btnCheckin.TabIndex = 3;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.BtnCheckin_Click);
            // 
            // PatientRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 499);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.gbxOpdFindings);
            this.Controls.Add(this.gbxRecordDetail);
            this.Name = "PatientRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Record";
            this.gbxRecordDetail.ResumeLayout(false);
            this.gbxRecordDetail.PerformLayout();
            this.gbxOpdFindings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRecordDetail;
        private System.Windows.Forms.Label lblIDcard;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox gbxOpdFindings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCheckin;
    }
}