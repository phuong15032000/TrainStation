namespace TSBuni.GUI
{
    partial class frmEDITcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEDITcs));
            this.lbSelect = new System.Windows.Forms.Label();
            this.cbxSelectTrain = new System.Windows.Forms.ComboBox();
            this.dtgridviewSchedule = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStation = new System.Windows.Forms.TextBox();
            this.txbArrivalTime = new System.Windows.Forms.TextBox();
            this.txbDepartureTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect.Location = new System.Drawing.Point(46, 9);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(58, 23);
            this.lbSelect.TabIndex = 51;
            this.lbSelect.Text = "Train:";
            // 
            // cbxSelectTrain
            // 
            this.cbxSelectTrain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSelectTrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectTrain.Items.AddRange(new object[] {
            "SE1",
            "SE2",
            "SE3",
            "SE4",
            "SE5",
            "SE6",
            "SE7",
            "SE8",
            "SE9",
            "SE10"});
            this.cbxSelectTrain.Location = new System.Drawing.Point(110, 6);
            this.cbxSelectTrain.Name = "cbxSelectTrain";
            this.cbxSelectTrain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxSelectTrain.Size = new System.Drawing.Size(181, 31);
            this.cbxSelectTrain.TabIndex = 50;
            this.cbxSelectTrain.Text = "SE1";
            this.cbxSelectTrain.TextChanged += new System.EventHandler(this.cbxSelectTrain_TextChanged);
            // 
            // dtgridviewSchedule
            // 
            this.dtgridviewSchedule.AllowUserToAddRows = false;
            this.dtgridviewSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.dtgridviewSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridviewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridviewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridviewSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.dtgridviewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgridviewSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgridviewSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridviewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgridviewSchedule.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridviewSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgridviewSchedule.DoubleBuffered = true;
            this.dtgridviewSchedule.EnableHeadersVisualStyles = false;
            this.dtgridviewSchedule.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.dtgridviewSchedule.HeaderForeColor = System.Drawing.Color.White;
            this.dtgridviewSchedule.Location = new System.Drawing.Point(16, 137);
            this.dtgridviewSchedule.Name = "dtgridviewSchedule";
            this.dtgridviewSchedule.ReadOnly = true;
            this.dtgridviewSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgridviewSchedule.RowHeadersVisible = false;
            this.dtgridviewSchedule.RowHeadersWidth = 51;
            this.dtgridviewSchedule.RowTemplate.DividerHeight = 3;
            this.dtgridviewSchedule.RowTemplate.Height = 30;
            this.dtgridviewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridviewSchedule.Size = new System.Drawing.Size(1072, 351);
            this.dtgridviewSchedule.TabIndex = 52;
            this.dtgridviewSchedule.SelectionChanged += new System.EventHandler(this.dtgridviewSchedule_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.btnUpdate.Location = new System.Drawing.Point(960, 545);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 41);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Arrival Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Departure Time:";
            // 
            // txbStation
            // 
            this.txbStation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStation.Location = new System.Drawing.Point(110, 62);
            this.txbStation.Name = "txbStation";
            this.txbStation.ReadOnly = true;
            this.txbStation.Size = new System.Drawing.Size(181, 32);
            this.txbStation.TabIndex = 57;
            // 
            // txbArrivalTime
            // 
            this.txbArrivalTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArrivalTime.Location = new System.Drawing.Point(493, 62);
            this.txbArrivalTime.Name = "txbArrivalTime";
            this.txbArrivalTime.Size = new System.Drawing.Size(181, 32);
            this.txbArrivalTime.TabIndex = 58;
            // 
            // txbDepartureTime
            // 
            this.txbDepartureTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepartureTime.Location = new System.Drawing.Point(894, 62);
            this.txbDepartureTime.Name = "txbDepartureTime";
            this.txbDepartureTime.Size = new System.Drawing.Size(181, 32);
            this.txbDepartureTime.TabIndex = 59;
            // 
            // frmEDITcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 590);
            this.Controls.Add(this.txbDepartureTime);
            this.Controls.Add(this.txbArrivalTime);
            this.Controls.Add(this.txbStation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtgridviewSchedule);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.cbxSelectTrain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEDITcs";
            this.Text = "frmEDITcs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.ComboBox cbxSelectTrain;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgridviewSchedule;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStation;
        private System.Windows.Forms.TextBox txbArrivalTime;
        private System.Windows.Forms.TextBox txbDepartureTime;
    }
}