namespace project_practice_3.MVC_View.Register
{
    partial class RegisterForm
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
            this.btnIDcard = new System.Windows.Forms.GroupBox();
            this.gpxGeneratedPID = new System.Windows.Forms.GroupBox();
            this.btnPID = new System.Windows.Forms.Button();
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnStartReg = new System.Windows.Forms.Button();
            this.gbxConnectionStatus = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.tbxDeviceInfo = new System.Windows.Forms.TextBox();
            this.gbxPatientFP = new System.Windows.Forms.GroupBox();
            this.tclFingerPrintControl = new System.Windows.Forms.TabControl();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.gbxFingers = new System.Windows.Forms.GroupBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.btnLP = new System.Windows.Forms.Button();
            this.btnRP = new System.Windows.Forms.Button();
            this.btnLR = new System.Windows.Forms.Button();
            this.btnRR = new System.Windows.Forms.Button();
            this.btnLM = new System.Windows.Forms.Button();
            this.btnRM = new System.Windows.Forms.Button();
            this.btnLI = new System.Windows.Forms.Button();
            this.btnRI = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            this.btnRT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxFingerPrintStatus = new System.Windows.Forms.GroupBox();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblFingerPrintCount = new System.Windows.Forms.Label();
            this.btnIDcard.SuspendLayout();
            this.gpxGeneratedPID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.gbxControl.SuspendLayout();
            this.gbxConnectionStatus.SuspendLayout();
            this.gbxConnection.SuspendLayout();
            this.gbxPatientFP.SuspendLayout();
            this.tclFingerPrintControl.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.gbxFingers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxFingerPrintStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIDcard
            // 
            this.btnIDcard.Controls.Add(this.gpxGeneratedPID);
            this.btnIDcard.Controls.Add(this.picFPImg);
            this.btnIDcard.Controls.Add(this.gbxControl);
            this.btnIDcard.Controls.Add(this.gbxConnectionStatus);
            this.btnIDcard.Controls.Add(this.gbxConnection);
            this.btnIDcard.Controls.Add(this.lblDeviceName);
            this.btnIDcard.Controls.Add(this.tbxDeviceInfo);
            this.btnIDcard.Controls.Add(this.gbxPatientFP);
            this.btnIDcard.Controls.Add(this.gbxFingerPrintStatus);
            this.btnIDcard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDcard.Location = new System.Drawing.Point(13, 12);
            this.btnIDcard.Name = "btnIDcard";
            this.btnIDcard.Size = new System.Drawing.Size(988, 562);
            this.btnIDcard.TabIndex = 14;
            this.btnIDcard.TabStop = false;
            this.btnIDcard.Text = "Device";
            // 
            // gpxGeneratedPID
            // 
            this.gpxGeneratedPID.Controls.Add(this.btnPID);
            this.gpxGeneratedPID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxGeneratedPID.Location = new System.Drawing.Point(769, 15);
            this.gpxGeneratedPID.Name = "gpxGeneratedPID";
            this.gpxGeneratedPID.Size = new System.Drawing.Size(202, 159);
            this.gpxGeneratedPID.TabIndex = 21;
            this.gpxGeneratedPID.TabStop = false;
            this.gpxGeneratedPID.Text = "Generated PID";
            // 
            // btnPID
            // 
            this.btnPID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPID.Location = new System.Drawing.Point(6, 47);
            this.btnPID.Name = "btnPID";
            this.btnPID.Size = new System.Drawing.Size(190, 62);
            this.btnPID.TabIndex = 0;
            this.btnPID.Text = "PID";
            this.btnPID.UseVisualStyleBackColor = true;
            this.btnPID.Click += new System.EventHandler(this.BtnPID_Click);
            // 
            // picFPImg
            // 
            this.picFPImg.BackColor = System.Drawing.Color.Transparent;
            this.picFPImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFPImg.Location = new System.Drawing.Point(582, 225);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(230, 262);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 15;
            this.picFPImg.TabStop = false;
            // 
            // gbxControl
            // 
            this.gbxControl.Controls.Add(this.btnStartReg);
            this.gbxControl.Location = new System.Drawing.Point(558, 15);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(205, 159);
            this.gbxControl.TabIndex = 20;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Control";
            // 
            // btnStartReg
            // 
            this.btnStartReg.BackColor = System.Drawing.Color.Aqua;
            this.btnStartReg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartReg.Location = new System.Drawing.Point(6, 47);
            this.btnStartReg.Name = "btnStartReg";
            this.btnStartReg.Size = new System.Drawing.Size(190, 62);
            this.btnStartReg.TabIndex = 20;
            this.btnStartReg.Text = "NEW REGISTRATION";
            this.btnStartReg.UseVisualStyleBackColor = false;
            this.btnStartReg.Click += new System.EventHandler(this.BtnStartReg_Click);
            // 
            // gbxConnectionStatus
            // 
            this.gbxConnectionStatus.Controls.Add(this.lblConnectionStatus);
            this.gbxConnectionStatus.Location = new System.Drawing.Point(332, 15);
            this.gbxConnectionStatus.Name = "gbxConnectionStatus";
            this.gbxConnectionStatus.Size = new System.Drawing.Size(220, 86);
            this.gbxConnectionStatus.TabIndex = 17;
            this.gbxConnectionStatus.TabStop = false;
            this.gbxConnectionStatus.Text = "Connection Status";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblConnectionStatus.Location = new System.Drawing.Point(43, 34);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(128, 25);
            this.lblConnectionStatus.TabIndex = 16;
            this.lblConnectionStatus.Text = "Disconnected";
            // 
            // gbxConnection
            // 
            this.gbxConnection.Controls.Add(this.btnDisconnect);
            this.gbxConnection.Controls.Add(this.btnConnect);
            this.gbxConnection.Location = new System.Drawing.Point(6, 107);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(546, 67);
            this.gbxConnection.TabIndex = 15;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Tomato;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(278, 21);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(260, 40);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            this.btnDisconnect.MouseLeave += new System.EventHandler(this.BtnDisconnect_MouseLeave);
            this.btnDisconnect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnDisconnect_MouseMove);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightGreen;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(6, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(266, 40);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            this.btnConnect.MouseLeave += new System.EventHandler(this.BtnConnect_MouseLeave);
            this.btnConnect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnConnect_MouseMove);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(14, 28);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(66, 15);
            this.lblDeviceName.TabIndex = 13;
            this.lblDeviceName.Text = "Device Info";
            // 
            // tbxDeviceInfo
            // 
            this.tbxDeviceInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDeviceInfo.Location = new System.Drawing.Point(86, 25);
            this.tbxDeviceInfo.Multiline = true;
            this.tbxDeviceInfo.Name = "tbxDeviceInfo";
            this.tbxDeviceInfo.ReadOnly = true;
            this.tbxDeviceInfo.Size = new System.Drawing.Size(240, 26);
            this.tbxDeviceInfo.TabIndex = 12;
            // 
            // gbxPatientFP
            // 
            this.gbxPatientFP.Controls.Add(this.tclFingerPrintControl);
            this.gbxPatientFP.Location = new System.Drawing.Point(6, 192);
            this.gbxPatientFP.Name = "gbxPatientFP";
            this.gbxPatientFP.Size = new System.Drawing.Size(546, 380);
            this.gbxPatientFP.TabIndex = 18;
            this.gbxPatientFP.TabStop = false;
            this.gbxPatientFP.Text = "Finger-Prints";
            // 
            // tclFingerPrintControl
            // 
            this.tclFingerPrintControl.Controls.Add(this.tabPageRegister);
            this.tclFingerPrintControl.Location = new System.Drawing.Point(6, 18);
            this.tclFingerPrintControl.Name = "tclFingerPrintControl";
            this.tclFingerPrintControl.SelectedIndex = 0;
            this.tclFingerPrintControl.Size = new System.Drawing.Size(534, 352);
            this.tclFingerPrintControl.TabIndex = 10;
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.Controls.Add(this.gbxFingers);
            this.tabPageRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRegister.Location = new System.Drawing.Point(4, 24);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(526, 324);
            this.tabPageRegister.TabIndex = 0;
            this.tabPageRegister.Text = "Register";
            this.tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // gbxFingers
            // 
            this.gbxFingers.Controls.Add(this.lblRight);
            this.gbxFingers.Controls.Add(this.lblLeft);
            this.gbxFingers.Controls.Add(this.btnLP);
            this.gbxFingers.Controls.Add(this.btnRP);
            this.gbxFingers.Controls.Add(this.btnLR);
            this.gbxFingers.Controls.Add(this.btnRR);
            this.gbxFingers.Controls.Add(this.btnLM);
            this.gbxFingers.Controls.Add(this.btnRM);
            this.gbxFingers.Controls.Add(this.btnLI);
            this.gbxFingers.Controls.Add(this.btnRI);
            this.gbxFingers.Controls.Add(this.btnLT);
            this.gbxFingers.Controls.Add(this.btnRT);
            this.gbxFingers.Controls.Add(this.pictureBox1);
            this.gbxFingers.Controls.Add(this.pictureBox2);
            this.gbxFingers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFingers.Location = new System.Drawing.Point(6, 6);
            this.gbxFingers.Name = "gbxFingers";
            this.gbxFingers.Size = new System.Drawing.Size(522, 309);
            this.gbxFingers.TabIndex = 5;
            this.gbxFingers.TabStop = false;
            this.gbxFingers.Text = "Finger Print Scanner";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.LightGray;
            this.lblRight.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(370, 194);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(40, 17);
            this.lblRight.TabIndex = 6;
            this.lblRight.Text = "Right";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.LightGray;
            this.lblLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.Location = new System.Drawing.Point(96, 194);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(30, 17);
            this.lblLeft.TabIndex = 6;
            this.lblLeft.Text = "Left";
            // 
            // btnLP
            // 
            this.btnLP.Location = new System.Drawing.Point(10, 107);
            this.btnLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLP.Name = "btnLP";
            this.btnLP.Size = new System.Drawing.Size(33, 23);
            this.btnLP.TabIndex = 4;
            this.btnLP.Text = "LP";
            this.btnLP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLP.UseVisualStyleBackColor = true;
            this.btnLP.Click += new System.EventHandler(this.BtnLP_Click);
            // 
            // btnRP
            // 
            this.btnRP.Location = new System.Drawing.Point(474, 108);
            this.btnRP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRP.Name = "btnRP";
            this.btnRP.Size = new System.Drawing.Size(33, 23);
            this.btnRP.TabIndex = 4;
            this.btnRP.Text = "RP";
            this.btnRP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRP.UseVisualStyleBackColor = true;
            this.btnRP.Click += new System.EventHandler(this.BtnRP_Click);
            // 
            // btnLR
            // 
            this.btnLR.Location = new System.Drawing.Point(33, 54);
            this.btnLR.Margin = new System.Windows.Forms.Padding(2);
            this.btnLR.Name = "btnLR";
            this.btnLR.Size = new System.Drawing.Size(33, 23);
            this.btnLR.TabIndex = 4;
            this.btnLR.Text = "LR";
            this.btnLR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLR.UseVisualStyleBackColor = true;
            this.btnLR.Click += new System.EventHandler(this.BtnLR_Click);
            // 
            // btnRR
            // 
            this.btnRR.Location = new System.Drawing.Point(446, 54);
            this.btnRR.Margin = new System.Windows.Forms.Padding(2);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(33, 23);
            this.btnRR.TabIndex = 4;
            this.btnRR.Text = "RR";
            this.btnRR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRR.UseVisualStyleBackColor = true;
            this.btnRR.Click += new System.EventHandler(this.BtnRR_Click);
            // 
            // btnLM
            // 
            this.btnLM.Location = new System.Drawing.Point(64, 30);
            this.btnLM.Margin = new System.Windows.Forms.Padding(2);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(33, 23);
            this.btnLM.TabIndex = 4;
            this.btnLM.Text = "LM";
            this.btnLM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLM.UseVisualStyleBackColor = true;
            this.btnLM.Click += new System.EventHandler(this.BtnLM_Click);
            // 
            // btnRM
            // 
            this.btnRM.Location = new System.Drawing.Point(408, 30);
            this.btnRM.Margin = new System.Windows.Forms.Padding(2);
            this.btnRM.Name = "btnRM";
            this.btnRM.Size = new System.Drawing.Size(33, 23);
            this.btnRM.TabIndex = 4;
            this.btnRM.Text = "RM";
            this.btnRM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRM.UseVisualStyleBackColor = true;
            this.btnRM.Click += new System.EventHandler(this.BtnRM_Click);
            // 
            // btnLI
            // 
            this.btnLI.Location = new System.Drawing.Point(130, 30);
            this.btnLI.Margin = new System.Windows.Forms.Padding(2);
            this.btnLI.Name = "btnLI";
            this.btnLI.Size = new System.Drawing.Size(33, 23);
            this.btnLI.TabIndex = 4;
            this.btnLI.Text = "LI";
            this.btnLI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLI.UseVisualStyleBackColor = true;
            this.btnLI.Click += new System.EventHandler(this.BtnLI_Click);
            // 
            // btnRI
            // 
            this.btnRI.Location = new System.Drawing.Point(356, 35);
            this.btnRI.Margin = new System.Windows.Forms.Padding(2);
            this.btnRI.Name = "btnRI";
            this.btnRI.Size = new System.Drawing.Size(33, 23);
            this.btnRI.TabIndex = 4;
            this.btnRI.Text = "RI";
            this.btnRI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRI.UseVisualStyleBackColor = true;
            this.btnRI.Click += new System.EventHandler(this.BtnRI_Click);
            // 
            // btnLT
            // 
            this.btnLT.Location = new System.Drawing.Point(215, 140);
            this.btnLT.Margin = new System.Windows.Forms.Padding(2);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(33, 23);
            this.btnLT.TabIndex = 4;
            this.btnLT.Text = "LT";
            this.btnLT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLT.UseVisualStyleBackColor = true;
            this.btnLT.Click += new System.EventHandler(this.BtnLT_Click);
            // 
            // btnRT
            // 
            this.btnRT.Location = new System.Drawing.Point(271, 140);
            this.btnRT.Margin = new System.Windows.Forms.Padding(2);
            this.btnRT.Name = "btnRT";
            this.btnRT.Size = new System.Drawing.Size(33, 23);
            this.btnRT.TabIndex = 4;
            this.btnRT.Text = "RT";
            this.btnRT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRT.UseVisualStyleBackColor = true;
            this.btnRT.Click += new System.EventHandler(this.BtnRT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::project_practice_3.Properties.Resources.right_hand;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(261, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::project_practice_3.Properties.Resources.left_hand;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 280);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // gbxFingerPrintStatus
            // 
            this.gbxFingerPrintStatus.Controls.Add(this.lblStatusLabel);
            this.gbxFingerPrintStatus.Controls.Add(this.lblFingerPrintCount);
            this.gbxFingerPrintStatus.Location = new System.Drawing.Point(558, 192);
            this.gbxFingerPrintStatus.Name = "gbxFingerPrintStatus";
            this.gbxFingerPrintStatus.Size = new System.Drawing.Size(413, 367);
            this.gbxFingerPrintStatus.TabIndex = 22;
            this.gbxFingerPrintStatus.TabStop = false;
            this.gbxFingerPrintStatus.Text = "Finger-Print Status";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLabel.Location = new System.Drawing.Point(20, 315);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(24, 20);
            this.lblStatusLabel.TabIndex = 21;
            this.lblStatusLabel.Text = ".....";
            // 
            // lblFingerPrintCount
            // 
            this.lblFingerPrintCount.AutoSize = true;
            this.lblFingerPrintCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFingerPrintCount.Location = new System.Drawing.Point(308, 123);
            this.lblFingerPrintCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFingerPrintCount.Name = "lblFingerPrintCount";
            this.lblFingerPrintCount.Size = new System.Drawing.Size(51, 55);
            this.lblFingerPrintCount.TabIndex = 20;
            this.lblFingerPrintCount.Text = "3";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 586);
            this.Controls.Add(this.btnIDcard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.btnIDcard.ResumeLayout(false);
            this.btnIDcard.PerformLayout();
            this.gpxGeneratedPID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.gbxControl.ResumeLayout(false);
            this.gbxConnectionStatus.ResumeLayout(false);
            this.gbxConnectionStatus.PerformLayout();
            this.gbxConnection.ResumeLayout(false);
            this.gbxPatientFP.ResumeLayout(false);
            this.tclFingerPrintControl.ResumeLayout(false);
            this.tabPageRegister.ResumeLayout(false);
            this.gbxFingers.ResumeLayout(false);
            this.gbxFingers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxFingerPrintStatus.ResumeLayout(false);
            this.gbxFingerPrintStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btnIDcard;
        private System.Windows.Forms.GroupBox gbxConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox tbxDeviceInfo;
        private System.Windows.Forms.TabControl tclFingerPrintControl;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.GroupBox gbxFingers;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Button btnLP;
        private System.Windows.Forms.Button btnRP;
        private System.Windows.Forms.Button btnLR;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.Button btnRM;
        private System.Windows.Forms.Button btnLI;
        private System.Windows.Forms.Button btnRI;
        private System.Windows.Forms.Button btnLT;
        private System.Windows.Forms.Button btnRT;
        private System.Windows.Forms.GroupBox gbxPatientFP;
        private System.Windows.Forms.Label lblFingerPrintCount;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbxFingerPrintStatus;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnStartReg;
        private System.Windows.Forms.GroupBox gpxGeneratedPID;
        private System.Windows.Forms.Button btnPID;
    }
}