namespace project_practice_3.MVC_View.Login
{
    partial class LoginForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbxPMS = new System.Windows.Forms.PictureBox();
            this.gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPMS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogin.Location = new System.Drawing.Point(2, 2);
            this.gbxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxLogin.Size = new System.Drawing.Size(331, 387);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login Here";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(111, 136);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pbxPMS
            // 
            this.pbxPMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPMS.Image = global::project_practice_3.Properties.Resources.logo;
            this.pbxPMS.Location = new System.Drawing.Point(337, 10);
            this.pbxPMS.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPMS.Name = "pbxPMS";
            this.pbxPMS.Size = new System.Drawing.Size(318, 379);
            this.pbxPMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPMS.TabIndex = 1;
            this.pbxPMS.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxPMS);
            this.Controls.Add(this.gbxLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(655, 391);
            this.gbxLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.PictureBox pbxPMS;
        private System.Windows.Forms.Button btnLogin;
    }
}
