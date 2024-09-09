namespace project_practice_3.MVC_View.Dashboard
{
    partial class Reg_Auth_Form
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
            this.gbxMenuTitle = new System.Windows.Forms.GroupBox();
            this.btnREG = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.gbxMenuTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMenuTitle
            // 
            this.gbxMenuTitle.Controls.Add(this.btnAuth);
            this.gbxMenuTitle.Controls.Add(this.btnREG);
            this.gbxMenuTitle.Location = new System.Drawing.Point(12, 12);
            this.gbxMenuTitle.Name = "gbxMenuTitle";
            this.gbxMenuTitle.Size = new System.Drawing.Size(507, 180);
            this.gbxMenuTitle.TabIndex = 0;
            this.gbxMenuTitle.TabStop = false;
            this.gbxMenuTitle.Text = "Patient Registration And Authentication";
            // 
            // btnREG
            // 
            this.btnREG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREG.Location = new System.Drawing.Point(6, 19);
            this.btnREG.Name = "btnREG";
            this.btnREG.Size = new System.Drawing.Size(242, 150);
            this.btnREG.TabIndex = 0;
            this.btnREG.Text = "REGISTRATION";
            this.btnREG.UseVisualStyleBackColor = true;
            this.btnREG.Click += new System.EventHandler(this.BtnREG_Click);
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuth.Location = new System.Drawing.Point(254, 19);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(242, 150);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "AUTHENTICATION";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.BtnAuth_Click);
            // 
            // Reg_Auth_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 196);
            this.Controls.Add(this.gbxMenuTitle);
            this.Name = "Reg_Auth_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration and Authentication";
            this.gbxMenuTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMenuTitle;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnREG;
    }
}