namespace TSBuni
{
    partial class frmMainhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainhome));
            this.pnMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbCool = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnLogo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnClose = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMinisize = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlShowChild = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenu.BackgroundImage")));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenu.Controls.Add(this.btn4);
            this.pnMenu.Controls.Add(this.lbCool);
            this.pnMenu.Controls.Add(this.btn3);
            this.pnMenu.Controls.Add(this.btn2);
            this.pnMenu.Controls.Add(this.btn1);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.pnMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.pnMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.pnMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Quality = 10;
            this.pnMenu.Size = new System.Drawing.Size(258, 740);
            this.pnMenu.TabIndex = 0;
            // 
            // btn4
            // 
            this.btn4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.BorderRadius = 0;
            this.btn4.ButtonText = "Log-out";
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.DisabledColor = System.Drawing.Color.Gray;
            this.btn4.Iconcolor = System.Drawing.Color.Transparent;
            this.btn4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn4.Iconimage")));
            this.btn4.Iconimage_right = null;
            this.btn4.Iconimage_right_Selected = null;
            this.btn4.Iconimage_Selected = null;
            this.btn4.IconMarginLeft = 0;
            this.btn4.IconMarginRight = 0;
            this.btn4.IconRightVisible = true;
            this.btn4.IconRightZoom = 0D;
            this.btn4.IconVisible = true;
            this.btn4.IconZoom = 70D;
            this.btn4.IsTab = true;
            this.btn4.Location = new System.Drawing.Point(4, 585);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn4.OnHoverTextColor = System.Drawing.Color.White;
            this.btn4.selected = false;
            this.btn4.Size = new System.Drawing.Size(258, 59);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Log-out";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn4.Textcolor = System.Drawing.Color.White;
            this.btn4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbCool
            // 
            this.lbCool.AutoSize = true;
            this.lbCool.BackColor = System.Drawing.Color.Transparent;
            this.lbCool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbCool.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCool.Location = new System.Drawing.Point(0, 723);
            this.lbCool.Name = "lbCool";
            this.lbCool.Size = new System.Drawing.Size(80, 17);
            this.lbCool.TabIndex = 3;
            this.lbCool.Text = "About us @";
            // 
            // btn3
            // 
            this.btn3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.BorderRadius = 0;
            this.btn3.ButtonText = "Profile";
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.DisabledColor = System.Drawing.Color.Gray;
            this.btn3.Iconcolor = System.Drawing.Color.Transparent;
            this.btn3.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn3.Iconimage")));
            this.btn3.Iconimage_right = null;
            this.btn3.Iconimage_right_Selected = null;
            this.btn3.Iconimage_Selected = null;
            this.btn3.IconMarginLeft = 0;
            this.btn3.IconMarginRight = 0;
            this.btn3.IconRightVisible = true;
            this.btn3.IconRightZoom = 0D;
            this.btn3.IconVisible = true;
            this.btn3.IconZoom = 70D;
            this.btn3.IsTab = true;
            this.btn3.Location = new System.Drawing.Point(4, 451);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn3.OnHoverTextColor = System.Drawing.Color.White;
            this.btn3.selected = false;
            this.btn3.Size = new System.Drawing.Size(258, 59);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Profile";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn3.Textcolor = System.Drawing.Color.White;
            this.btn3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.BorderRadius = 0;
            this.btn2.ButtonText = "Ticket Booking";
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.DisabledColor = System.Drawing.Color.Gray;
            this.btn2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn2.Iconimage")));
            this.btn2.Iconimage_right = null;
            this.btn2.Iconimage_right_Selected = null;
            this.btn2.Iconimage_Selected = null;
            this.btn2.IconMarginLeft = 0;
            this.btn2.IconMarginRight = 0;
            this.btn2.IconRightVisible = true;
            this.btn2.IconRightZoom = 0D;
            this.btn2.IconVisible = true;
            this.btn2.IconZoom = 70D;
            this.btn2.IsTab = true;
            this.btn2.Location = new System.Drawing.Point(4, 316);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn2.selected = false;
            this.btn2.Size = new System.Drawing.Size(258, 59);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Ticket Booking";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.Textcolor = System.Drawing.Color.White;
            this.btn2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.BorderRadius = 0;
            this.btn1.ButtonText = "Schedule";
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.DisabledColor = System.Drawing.Color.Gray;
            this.btn1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn1.Iconimage")));
            this.btn1.Iconimage_right = null;
            this.btn1.Iconimage_right_Selected = null;
            this.btn1.Iconimage_Selected = null;
            this.btn1.IconMarginLeft = 0;
            this.btn1.IconMarginRight = 0;
            this.btn1.IconRightVisible = true;
            this.btn1.IconRightZoom = 0D;
            this.btn1.IconVisible = true;
            this.btn1.IconZoom = 70D;
            this.btn1.IsTab = true;
            this.btn1.Location = new System.Drawing.Point(4, 182);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(199)))));
            this.btn1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn1.selected = true;
            this.btn1.Size = new System.Drawing.Size(258, 59);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Schedule";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Textcolor = System.Drawing.Color.White;
            this.btn1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLogo.BackgroundImage")));
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogo.Controls.Add(this.panel6);
            this.pnLogo.Controls.Add(this.panel2);
            this.pnLogo.Controls.Add(this.lbLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(44)))), ((int)(((byte)(241)))));
            this.pnLogo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.pnLogo.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.pnLogo.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(44)))), ((int)(((byte)(241)))));
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Quality = 10;
            this.pnLogo.Size = new System.Drawing.Size(258, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 97);
            this.panel6.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 3);
            this.panel2.TabIndex = 3;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            this.lbLogo.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Location = new System.Drawing.Point(57, 20);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(135, 58);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "Train";
            // 
            // pnTop
            // 
            this.pnTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTop.BackgroundImage")));
            this.pnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTop.Controls.Add(this.panel4);
            this.pnTop.Controls.Add(this.pnClose);
            this.pnTop.Controls.Add(this.pnMinisize);
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.GradientBottomLeft = System.Drawing.Color.White;
            this.pnTop.GradientBottomRight = System.Drawing.Color.White;
            this.pnTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(52)))), ((int)(((byte)(243)))));
            this.pnTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(72)))), ((int)(((byte)(248)))));
            this.pnTop.Location = new System.Drawing.Point(258, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Quality = 10;
            this.pnTop.Size = new System.Drawing.Size(1121, 100);
            this.pnTop.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1118, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 97);
            this.panel4.TabIndex = 4;
            // 
            // pnClose
            // 
            this.pnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnClose.BackgroundImage")));
            this.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose.Location = new System.Drawing.Point(1070, 11);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(40, 40);
            this.pnClose.TabIndex = 0;
            this.pnClose.Click += new System.EventHandler(this.pnClose_Click);
            // 
            // pnMinisize
            // 
            this.pnMinisize.BackColor = System.Drawing.Color.Transparent;
            this.pnMinisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMinisize.BackgroundImage")));
            this.pnMinisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMinisize.Location = new System.Drawing.Point(1024, 11);
            this.pnMinisize.Name = "pnMinisize";
            this.pnMinisize.Size = new System.Drawing.Size(40, 40);
            this.pnMinisize.TabIndex = 2;
            this.pnMinisize.Click += new System.EventHandler(this.pnMinisize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 3);
            this.panel1.TabIndex = 2;
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
            this.bunifuDragControl1.TargetControl = this.pnLogo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnTop;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1376, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 640);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(258, 737);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1118, 3);
            this.panel5.TabIndex = 4;
            // 
            // pnlShowChild
            // 
            this.pnlShowChild.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlShowChild.Location = new System.Drawing.Point(258, 100);
            this.pnlShowChild.Name = "pnlShowChild";
            this.pnlShowChild.Size = new System.Drawing.Size(1118, 637);
            this.pnlShowChild.TabIndex = 5;
            // 
            // frmMainhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 740);
            this.Controls.Add(this.pnlShowChild);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainHome";
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel pnLogo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnTop;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btn1;
        private Bunifu.Framework.UI.BunifuFlatButton btn3;
        private Bunifu.Framework.UI.BunifuFlatButton btn2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCool;
        private System.Windows.Forms.FlowLayoutPanel pnMinisize;
        private System.Windows.Forms.FlowLayoutPanel pnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btn4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlShowChild;
    }
}