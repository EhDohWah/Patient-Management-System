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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.gbxGenerateIDCard = new System.Windows.Forms.GroupBox();
            this.btnGenerateIDCard = new System.Windows.Forms.Button();
            this.gbxGeneratedIDCard = new System.Windows.Forms.GroupBox();
            this.pnltopColor = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.generatedID = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.gbxGenerateIDCard.SuspendLayout();
            this.gbxGeneratedIDCard.SuspendLayout();
            this.pnltopColor.SuspendLayout();
            this.generatedID.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 25);
            this.textBox1.TabIndex = 1;
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
            this.gbxGenerateIDCard.Controls.Add(this.textBox1);
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
            // 
            // gbxGeneratedIDCard
            // 
            this.gbxGeneratedIDCard.Controls.Add(this.btn);
            this.gbxGeneratedIDCard.Controls.Add(this.generatedID);
            this.gbxGeneratedIDCard.Location = new System.Drawing.Point(12, 121);
            this.gbxGeneratedIDCard.Name = "gbxGeneratedIDCard";
            this.gbxGeneratedIDCard.Size = new System.Drawing.Size(377, 317);
            this.gbxGeneratedIDCard.TabIndex = 3;
            this.gbxGeneratedIDCard.TabStop = false;
            this.gbxGeneratedIDCard.Text = "Generated ID Card";
            // 
            // pnltopColor
            // 
            this.pnltopColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnltopColor.Controls.Add(this.lblTitle);
            this.pnltopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltopColor.Location = new System.Drawing.Point(0, 0);
            this.pnltopColor.Name = "pnltopColor";
            this.pnltopColor.Size = new System.Drawing.Size(324, 35);
            this.pnltopColor.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(55, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PATIENT IDENTIFICATION CARD";
            // 
            // generatedID
            // 
            this.generatedID.Controls.Add(this.lblMobile);
            this.generatedID.Controls.Add(this.lblIDNo);
            this.generatedID.Controls.Add(this.lblName);
            this.generatedID.Controls.Add(this.pnltopColor);
            this.generatedID.Location = new System.Drawing.Point(23, 32);
            this.generatedID.Name = "generatedID";
            this.generatedID.Size = new System.Drawing.Size(324, 204);
            this.generatedID.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Location = new System.Drawing.Point(34, 96);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(61, 13);
            this.lblIDNo.TabIndex = 2;
            this.lblIDNo.Text = "ID Number:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(34, 126);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(272, 261);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "PRINT";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // IDCardPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.gbxGeneratedIDCard);
            this.Controls.Add(this.gbxGenerateIDCard);
            this.Name = "IDCardPrinting";
            this.Text = "IDCardPrinting";
            this.gbxGenerateIDCard.ResumeLayout(false);
            this.gbxGenerateIDCard.PerformLayout();
            this.gbxGeneratedIDCard.ResumeLayout(false);
            this.pnltopColor.ResumeLayout(false);
            this.pnltopColor.PerformLayout();
            this.generatedID.ResumeLayout(false);
            this.generatedID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
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
    }
}