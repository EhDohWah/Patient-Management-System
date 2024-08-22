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
            this.lblTitleIPD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleIPD
            // 
            this.lblTitleIPD.AutoSize = true;
            this.lblTitleIPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIPD.Location = new System.Drawing.Point(344, 118);
            this.lblTitleIPD.Name = "lblTitleIPD";
            this.lblTitleIPD.Size = new System.Drawing.Size(73, 20);
            this.lblTitleIPD.TabIndex = 0;
            this.lblTitleIPD.Text = "IPDForm";
            // 
            // PatientIPDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitleIPD);
            this.Name = "PatientIPDForm";
            this.Text = "PatientIPDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleIPD;
    }
}