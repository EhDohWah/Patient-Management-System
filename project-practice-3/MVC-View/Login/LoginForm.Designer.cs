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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.pbxPMS = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPMS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnRegister);
            this.gbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogin.Location = new System.Drawing.Point(3, 2);
            this.gbxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxLogin.Size = new System.Drawing.Size(441, 476);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login Here";
            // 
            // pbxPMS
            // 
            this.pbxPMS.Image = ((System.Drawing.Image)(resources.GetObject("pbxPMS.Image")));
            this.pbxPMS.Location = new System.Drawing.Point(449, 16);
            this.pbxPMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxPMS.Name = "pbxPMS";
            this.pbxPMS.Size = new System.Drawing.Size(413, 448);
            this.pbxPMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPMS.TabIndex = 1;
            this.pbxPMS.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(139, 133);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 59);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxPMS);
            this.Controls.Add(this.gbxLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(873, 481);
            this.gbxLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.PictureBox pbxPMS;
        private System.Windows.Forms.Button btnRegister;
    }
}
