namespace TSBuni
{
    partial class frmForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPass));
            this.lbUsername = new System.Windows.Forms.Label();
            this.txbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbSource = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(33, 125);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(106, 21);
            this.lbUsername.TabIndex = 17;
            this.lbUsername.Text = "User Name:";
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
            this.txbUsername.Location = new System.Drawing.Point(144, 109);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(292, 44);
            this.txbUsername.TabIndex = 16;
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(33, 258);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 21);
            this.lbEmail.TabIndex = 19;
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
            this.txbEmail.Location = new System.Drawing.Point(145, 239);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(292, 44);
            this.txbEmail.TabIndex = 18;
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbUsername);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 398);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Username and Email";
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 10;
            this.btnReset.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.ActiveLineColor = System.Drawing.Color.White;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset Password";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 10;
            this.btnReset.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnReset.IdleForecolor = System.Drawing.Color.White;
            this.btnReset.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnReset.Location = new System.Drawing.Point(141, 540);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 60);
            this.btnReset.TabIndex = 21;
            this.btnReset.TabStop = false;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbSource
            // 
            this.lbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSource.Location = new System.Drawing.Point(393, 637);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(87, 13);
            this.lbSource.TabIndex = 22;
            this.lbSource.Text = "Term @Mtr.Dph";
            // 
            // picBack
            // 
            this.picBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBack.BackgroundImage")));
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Location = new System.Drawing.Point(12, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.TabIndex = 23;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // frmForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPass";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUsername;
        private System.Windows.Forms.Label lbEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSource;
        private System.Windows.Forms.PictureBox picBack;
    }
}