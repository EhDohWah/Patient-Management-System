namespace project_practice_3.MVC_View.ID_Printer
{
    partial class IDCardPrinting
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
            this.tbxPID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.gbxGenerateIDCard = new System.Windows.Forms.GroupBox();
            this.btnGenerateIDCard = new System.Windows.Forms.Button();
            this.gbxGeneratedIDCard = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.generatedID = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPIDValue = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnltopColor = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.pbxBarCode = new System.Windows.Forms.PictureBox();
            this.gbxGenerateIDCard.SuspendLayout();
            this.gbxGeneratedIDCard.SuspendLayout();
            this.generatedID.SuspendLayout();
            this.pnltopColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPID
            // 
            this.tbxPID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPID.Location = new System.Drawing.Point(81, 32);
            this.tbxPID.Name = "tbxPID";
            this.tbxPID.Size = new System.Drawing.Size(177, 25);
            this.tbxPID.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(20, 37);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Enter PID: ";
            // 
            // gbxGenerateIDCard
            // 
            this.gbxGenerateIDCard.Controls.Add(this.btnGenerateIDCard);
            this.gbxGenerateIDCard.Controls.Add(this.lbl);
            this.gbxGenerateIDCard.Controls.Add(this.tbxPID);
            this.gbxGenerateIDCard.Location = new System.Drawing.Point(12, 12);
            this.gbxGenerateIDCard.Name = "gbxGenerateIDCard";
            this.gbxGenerateIDCard.Size = new System.Drawing.Size(377, 103);
            this.gbxGenerateIDCard.TabIndex = 2;
            this.gbxGenerateIDCard.TabStop = false;
            this.gbxGenerateIDCard.Text = "Enter PID Here";
            // 
            // btnGenerateIDCard
            // 
            this.btnGenerateIDCard.Location = new System.Drawing.Point(264, 32);
            this.btnGenerateIDCard.Name = "btnGenerateIDCard";
            this.btnGenerateIDCard.Size = new System.Drawing.Size(107, 25);
            this.btnGenerateIDCard.TabIndex = 2;
            this.btnGenerateIDCard.Text = "Generate ID Card";
            this.btnGenerateIDCard.UseVisualStyleBackColor = true;
            this.btnGenerateIDCard.Click += new System.EventHandler(this.BtnGenerateIDCard_Click);
            // 
            // gbxGeneratedIDCard
            // 
            this.gbxGeneratedIDCard.Controls.Add(this.btnPrintPreview);
            this.gbxGeneratedIDCard.Controls.Add(this.btn);
            this.gbxGeneratedIDCard.Controls.Add(this.generatedID);
            this.gbxGeneratedIDCard.Location = new System.Drawing.Point(12, 121);
            this.gbxGeneratedIDCard.Name = "gbxGeneratedIDCard";
            this.gbxGeneratedIDCard.Size = new System.Drawing.Size(377, 317);
            this.gbxGeneratedIDCard.TabIndex = 3;
            this.gbxGeneratedIDCard.TabStop = false;
            this.gbxGeneratedIDCard.Text = "Generated ID Card";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(272, 261);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "PRINT";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // generatedID
            // 
            this.generatedID.BackColor = System.Drawing.Color.White;
            this.generatedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedID.Controls.Add(this.pbxBarCode);
            this.generatedID.Controls.Add(this.lblPhoneNumber);
            this.generatedID.Controls.Add(this.lblPIDValue);
            this.generatedID.Controls.Add(this.lblFullNameValue);
            this.generatedID.Controls.Add(this.lblMobile);
            this.generatedID.Controls.Add(this.lblIDNo);
            this.generatedID.Controls.Add(this.lblName);
            this.generatedID.Controls.Add(this.pnltopColor);
            this.generatedID.Location = new System.Drawing.Point(23, 32);
            this.generatedID.Name = "generatedID";
            this.generatedID.Size = new System.Drawing.Size(324, 204);
            this.generatedID.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(91, 127);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(92, 17);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblPIDValue
            // 
            this.lblPIDValue.AutoSize = true;
            this.lblPIDValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIDValue.Location = new System.Drawing.Point(114, 94);
            this.lblPIDValue.Name = "lblPIDValue";
            this.lblPIDValue.Size = new System.Drawing.Size(36, 19);
            this.lblPIDValue.TabIndex = 4;
            this.lblPIDValue.Text = "PID";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameValue.Location = new System.Drawing.Point(87, 63);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(62, 17);
            this.lblFullNameValue.TabIndex = 4;
            this.lblFullNameValue.Text = "FullName";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(34, 126);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(51, 16);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile:";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNo.Location = new System.Drawing.Point(34, 96);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(74, 16);
            this.lblIDNo.TabIndex = 2;
            this.lblIDNo.Text = "ID Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // pnltopColor
            // 
            this.pnltopColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnltopColor.Controls.Add(this.lblTitle);
            this.pnltopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltopColor.Location = new System.Drawing.Point(0, 0);
            this.pnltopColor.Name = "pnltopColor";
            this.pnltopColor.Size = new System.Drawing.Size(322, 35);
            this.pnltopColor.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(38, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PATIENT IDENTIFICATION CARD";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(191, 261);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPrintPreview.TabIndex = 1;
            this.btnPrintPreview.Text = "PREVIEW";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.BtnPrintPreview_Click);
            // 
            // pbxBarCode
            // 
            this.pbxBarCode.Location = new System.Drawing.Point(67, 158);
            this.pbxBarCode.Name = "pbxBarCode";
            this.pbxBarCode.Size = new System.Drawing.Size(194, 34);
            this.pbxBarCode.TabIndex = 5;
            this.pbxBarCode.TabStop = false;
            // 
            // IDCardPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.gbxGeneratedIDCard);
            this.Controls.Add(this.gbxGenerateIDCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IDCardPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IDCardPrinting";
            this.gbxGenerateIDCard.ResumeLayout(false);
            this.gbxGenerateIDCard.PerformLayout();
            this.gbxGeneratedIDCard.ResumeLayout(false);
            this.generatedID.ResumeLayout(false);
            this.generatedID.PerformLayout();
            this.pnltopColor.ResumeLayout(false);
            this.pnltopColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBarCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gbxGenerateIDCard;
        private System.Windows.Forms.Button btnGenerateIDCard;
        private System.Windows.Forms.GroupBox gbxGeneratedIDCard;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel generatedID;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnltopColor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPIDValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.PictureBox pbxBarCode;
    }
}