namespace TSBuni
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinisize = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.lbRegister = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txbFullname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txbPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbSource = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(458, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinisize
            // 
            this.picMinisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinisize.BackgroundImage")));
            this.picMinisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinisize.Location = new System.Drawing.Point(417, 12);
            this.picMinisize.Name = "picMinisize";
            this.picMinisize.Size = new System.Drawing.Size(30, 30);
            this.picMinisize.TabIndex = 3;
            this.picMinisize.TabStop = false;
            this.picMinisize.Click += new System.EventHandler(this.picMinisize_Click);
            // 
            // picBack
            // 
            this.picBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBack.BackgroundImage")));
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Location = new System.Drawing.Point(12, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.TabIndex = 4;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.White;
            this.lbRegister.Location = new System.Drawing.Point(12, 76);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(476, 45);
            this.lbRegister.TabIndex = 5;
            this.lbRegister.Text = "Register New Account";
            this.lbRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbFullname
            // 
            this.txbFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFullname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbFullname.ForeColor = System.Drawing.Color.White;
            this.txbFullname.HintForeColor = System.Drawing.Color.Gray;
            this.txbFullname.HintText = "Fullname";
            this.txbFullname.isPassword = false;
            this.txbFullname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbFullname.LineIdleColor = System.Drawing.Color.Gray;
            this.txbFullname.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbFullname.LineThickness = 3;
            this.txbFullname.Location = new System.Drawing.Point(155, 184);
            this.txbFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(292, 44);
            this.txbFullname.TabIndex = 1;
            this.txbFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbFullname.OnValueChanged += new System.EventHandler(this.txbFullname_OnValueChanged);
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.ForeColor = System.Drawing.Color.White;
            this.lbFullname.Location = new System.Drawing.Point(43, 207);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(95, 21);
            this.lbFullname.TabIndex = 9;
            this.lbFullname.Text = "Full Name:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(45, 323);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(67, 21);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "Phone:";
            // 
            // txbPhone
            // 
            this.txbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPhone.ForeColor = System.Drawing.Color.White;
            this.txbPhone.HintForeColor = System.Drawing.Color.Gray;
            this.txbPhone.HintText = "Phone";
            this.txbPhone.isPassword = false;
            this.txbPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txbPhone.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbPhone.LineThickness = 3;
            this.txbPhone.Location = new System.Drawing.Point(155, 310);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(292, 44);
            this.txbPhone.TabIndex = 3;
            this.txbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(43, 270);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 21);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbEmail.ForeColor = System.Drawing.Color.White;
            this.txbEmail.HintForeColor = System.Drawing.Color.Gray;
            this.txbEmail.HintText = "Email";
            this.txbEmail.isPassword = false;
            this.txbEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txbEmail.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbEmail.LineThickness = 3;
            this.txbEmail.Location = new System.Drawing.Point(155, 247);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(292, 44);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(45, 386);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(112, 21);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "User Name*:";
            // 
            // txbUsername
            // 
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbUsername.ForeColor = System.Drawing.Color.White;
            this.txbUsername.HintForeColor = System.Drawing.Color.Gray;
            this.txbUsername.HintText = "Username";
            this.txbUsername.isPassword = false;
            this.txbUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txbUsername.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbUsername.LineThickness = 3;
            this.txbUsername.Location = new System.Drawing.Point(155, 373);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(292, 44);
            this.txbUsername.TabIndex = 4;
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(45, 449);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(99, 21);
            this.lbPassword.TabIndex = 17;
            this.lbPassword.Text = "Password*:";
            // 
            // txbPassword
            // 
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPassword.ForeColor = System.Drawing.Color.White;
            this.txbPassword.HintForeColor = System.Drawing.Color.Gray;
            this.txbPassword.HintText = "Password";
            this.txbPassword.isPassword = true;
            this.txbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txbPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbPassword.LineThickness = 3;
            this.txbPassword.Location = new System.Drawing.Point(155, 436);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(292, 44);
            this.txbPassword.TabIndex = 5;
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPassword.OnValueChanged += new System.EventHandler(this.txbPassword_OnValueChanged);
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 10;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.White;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 10;
            this.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnRegister.Location = new System.Drawing.Point(155, 558);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 60);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.TabStop = false;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbSource
            // 
            this.lbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSource.Location = new System.Drawing.Point(411, 681);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(87, 13);
            this.lbSource.TabIndex = 19;
            this.lbSource.Text = "Term @Mtr.Dph";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.txbFullname);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMinisize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinisize;
        private System.Windows.Forms.PictureBox picBack;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbFullname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPhone;
        private System.Windows.Forms.Label lbEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbEmail;
        private System.Windows.Forms.Label lbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUsername;
        private System.Windows.Forms.Label lbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSource;
    }
}