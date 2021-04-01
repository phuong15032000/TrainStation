namespace TSBuni
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lbToTal = new System.Windows.Forms.Label();
            this.btnSignin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEx = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.txbPRICE = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbToTal
            // 
            this.lbToTal.AutoSize = true;
            this.lbToTal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToTal.ForeColor = System.Drawing.Color.White;
            this.lbToTal.Location = new System.Drawing.Point(25, 9);
            this.lbToTal.Name = "lbToTal";
            this.lbToTal.Size = new System.Drawing.Size(201, 37);
            this.lbToTal.TabIndex = 0;
            this.lbToTal.Text = "Total Money:";
            // 
            // btnSignin
            // 
            this.btnSignin.ActiveBorderThickness = 1;
            this.btnSignin.ActiveCornerRadius = 10;
            this.btnSignin.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSignin.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnSignin.ActiveLineColor = System.Drawing.Color.Black;
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnSignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignin.BackgroundImage")));
            this.btnSignin.ButtonText = "OK";
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignin.IdleBorderThickness = 2;
            this.btnSignin.IdleCornerRadius = 1;
            this.btnSignin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.btnSignin.IdleForecolor = System.Drawing.Color.White;
            this.btnSignin.IdleLineColor = System.Drawing.Color.Black;
            this.btnSignin.Location = new System.Drawing.Point(194, 606);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(136, 60);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.TabStop = false;
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(26, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bank Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "1234.xxxx.xxxxx.xxxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Contact:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(302, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "038.xxx.xxxx";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEx);
            this.groupBox1.Controls.Add(this.lbtype);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 252);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note";
            // 
            // lbEx
            // 
            this.lbEx.AutoSize = true;
            this.lbEx.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEx.ForeColor = System.Drawing.Color.White;
            this.lbEx.Location = new System.Drawing.Point(9, 217);
            this.lbEx.Name = "lbEx";
            this.lbEx.Size = new System.Drawing.Size(32, 21);
            this.lbEx.TabIndex = 16;
            this.lbEx.Text = "Ex:";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.ForeColor = System.Drawing.Color.White;
            this.lbtype.Location = new System.Drawing.Point(49, 58);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(99, 23);
            this.lbtype.TabIndex = 15;
            this.lbtype.Text = "typehere";
            // 
            // txbPRICE
            // 
            this.txbPRICE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.txbPRICE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPRICE.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(116)))), ((int)(((byte)(107)))));
            this.txbPRICE.Location = new System.Drawing.Point(19, 71);
            this.txbPRICE.Name = "txbPRICE";
            this.txbPRICE.ReadOnly = true;
            this.txbPRICE.Size = new System.Drawing.Size(497, 58);
            this.txbPRICE.TabIndex = 19;
            this.txbPRICE.TabStop = false;
            this.txbPRICE.Text = "0 VND";
            this.txbPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(535, 692);
            this.Controls.Add(this.txbPRICE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.lbToTal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbToTal;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEx;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.TextBox txbPRICE;
    }
}