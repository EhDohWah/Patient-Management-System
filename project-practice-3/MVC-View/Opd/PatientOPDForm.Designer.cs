﻿namespace project_practice_3.MVC_View.Opd
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
            this.lblTitleOPD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleOPD
            // 
            this.lblTitleOPD.AutoSize = true;
            this.lblTitleOPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOPD.Location = new System.Drawing.Point(235, 94);
            this.lblTitleOPD.Name = "lblTitleOPD";
            this.lblTitleOPD.Size = new System.Drawing.Size(80, 20);
            this.lblTitleOPD.TabIndex = 0;
            this.lblTitleOPD.Text = "OPDForm";
            // 
            // PatientOPDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitleOPD);
            this.Name = "PatientOPDForm";
            this.Text = "PatientOPDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleOPD;
    }
}