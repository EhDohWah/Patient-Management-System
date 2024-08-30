namespace project_practice_3.MVC_View.Authenticate
{
    partial class Authentication
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
            this.gbxAuthenticate = new System.Windows.Forms.GroupBox();
            this.panelBarcode = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnFingerPrint = new System.Windows.Forms.Button();
            this.gbxAuthenticate.SuspendLayout();
            this.panelBarcode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAuthenticate
            // 
            this.gbxAuthenticate.Controls.Add(this.panel2);
            this.gbxAuthenticate.Controls.Add(this.panelBarcode);
            this.gbxAuthenticate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAuthenticate.Location = new System.Drawing.Point(12, 12);
            this.gbxAuthenticate.Name = "gbxAuthenticate";
            this.gbxAuthenticate.Size = new System.Drawing.Size(565, 255);
            this.gbxAuthenticate.TabIndex = 0;
            this.gbxAuthenticate.TabStop = false;
            this.gbxAuthenticate.Text = "Patient Authentication";
            // 
            // panelBarcode
            // 
            this.panelBarcode.Controls.Add(this.btnBarcode);
            this.panelBarcode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBarcode.Location = new System.Drawing.Point(6, 19);
            this.panelBarcode.Name = "panelBarcode";
            this.panelBarcode.Size = new System.Drawing.Size(276, 226);
            this.panelBarcode.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFingerPrint);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(285, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 226);
            this.panel2.TabIndex = 0;
            // 
            // btnBarcode
            // 
            this.btnBarcode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcode.Location = new System.Drawing.Point(3, 3);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(270, 220);
            this.btnBarcode.TabIndex = 0;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = true;
            // 
            // btnFingerPrint
            // 
            this.btnFingerPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFingerPrint.Location = new System.Drawing.Point(3, 3);
            this.btnFingerPrint.Name = "btnFingerPrint";
            this.btnFingerPrint.Size = new System.Drawing.Size(270, 220);
            this.btnFingerPrint.TabIndex = 0;
            this.btnFingerPrint.Text = "FingerPrint";
            this.btnFingerPrint.UseVisualStyleBackColor = true;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 272);
            this.Controls.Add(this.gbxAuthenticate);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.gbxAuthenticate.ResumeLayout(false);
            this.panelBarcode.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAuthenticate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFingerPrint;
        private System.Windows.Forms.Panel panelBarcode;
        private System.Windows.Forms.Button btnBarcode;
    }
}