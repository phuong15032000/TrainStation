namespace TSBuni
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinisize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.txbUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSignin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbSource = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picMinisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(200, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            // 
            // picMinisize
            // 
            this.picMinisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinisize.BackgroundImage")));
            this.picMinisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinisize.Location = new System.Drawing.Point(417, 12);
            this.picMinisize.Name = "picMinisize";
            this.picMinisize.Size = new System.Drawing.Size(30, 30);
            this.picMinisize.TabIndex = 1;
            this.picMinisize.TabStop = false;
            this.picMinisize.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(458, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txbUser
            // 
            this.txbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbUser.ForeColor = System.Drawing.Color.White;
            this.txbUser.HintForeColor = System.Drawing.Color.White;
            this.txbUser.HintText = "Username";
            this.txbUser.isPassword = false;
            this.txbUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txbUser.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbUser.LineThickness = 3;
            this.txbUser.Location = new System.Drawing.Point(109, 253);
            this.txbUser.Margin = new System.Windows.Forms.Padding(4);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(320, 44);
            this.txbUser.TabIndex = 3;
            this.txbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbUser.OnValueChanged += new System.EventHandler(this.txbUser_OnValueChanged);
            this.txbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUser_KeyDown);
            // 
            // txbPass
            // 
            this.txbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPass.ForeColor = System.Drawing.Color.White;
            this.txbPass.HintForeColor = System.Drawing.Color.White;
            this.txbPass.HintText = "Password";
            this.txbPass.isPassword = false;
            this.txbPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.txbPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txbPass.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txbPass.LineThickness = 3;
            this.txbPass.Location = new System.Drawing.Point(109, 345);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(320, 44);
            this.txbPass.TabIndex = 4;
            this.txbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPass.OnValueChanged += new System.EventHandler(this.txbPass_OnValueChanged);
            this.txbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPass_KeyDown);
            // 
            // btnSignin
            // 
            this.btnSignin.ActiveBorderThickness = 1;
            this.btnSignin.ActiveCornerRadius = 10;
            this.btnSignin.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSignin.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnSignin.ActiveLineColor = System.Drawing.Color.White;
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnSignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignin.BackgroundImage")));
            this.btnSignin.ButtonText = "Sign-In";
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignin.IdleBorderThickness = 1;
            this.btnSignin.IdleCornerRadius = 10;
            this.btnSignin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnSignin.IdleForecolor = System.Drawing.Color.White;
            this.btnSignin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnSignin.Location = new System.Drawing.Point(150, 499);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(200, 60);
            this.btnSignin.TabIndex = 1;
            this.btnSignin.TabStop = false;
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.Location = new System.Drawing.Point(59, 264);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(35, 35);
            this.picUser.TabIndex = 4;
            this.picUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(59, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 10;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
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
            this.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(153, 592);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 60);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.TabStop = false;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbSource
            // 
            this.lbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSource.Location = new System.Drawing.Point(411, 680);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(87, 13);
            this.lbSource.TabIndex = 6;
            this.lbSource.Text = "Term @Mtr.Dph";
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.ActiveLinkColor = System.Drawing.Color.White;
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(139)))), ((int)(((byte)(179)))));
            this.linkForgotPass.Location = new System.Drawing.Point(302, 414);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(127, 19);
            this.linkForgotPass.TabIndex = 7;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "Forgot Password?";
            this.linkForgotPass.VisitedLinkColor = System.Drawing.Color.White;
            this.linkForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPass_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.linkForgotPass);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMinisize);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginTrain";
            ((System.ComponentModel.ISupportInitialize)(this.picMinisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignin;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private System.Windows.Forms.PictureBox picMinisize;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkForgotPass;
    }
}

