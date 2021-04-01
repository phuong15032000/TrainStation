namespace TSBuni
{
    partial class frmSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgridviewSchedule = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbSelect = new System.Windows.Forms.Label();
            this.cbxSelectTrain = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewSchedule)).BeginInit();
            this.SuspendLayout();
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
            this.dtgridviewSchedule.Location = new System.Drawing.Point(12, 67);
            this.dtgridviewSchedule.Name = "dtgridviewSchedule";
            this.dtgridviewSchedule.ReadOnly = true;
            this.dtgridviewSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgridviewSchedule.RowHeadersVisible = false;
            this.dtgridviewSchedule.RowHeadersWidth = 51;
            this.dtgridviewSchedule.RowTemplate.DividerHeight = 3;
            this.dtgridviewSchedule.RowTemplate.Height = 30;
            this.dtgridviewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridviewSchedule.Size = new System.Drawing.Size(1094, 557);
            this.dtgridviewSchedule.TabIndex = 50;
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect.Location = new System.Drawing.Point(12, 20);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(173, 23);
            this.lbSelect.TabIndex = 49;
            this.lbSelect.Text = "Select your Train:";
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
            this.cbxSelectTrain.Location = new System.Drawing.Point(207, 17);
            this.cbxSelectTrain.Name = "cbxSelectTrain";
            this.cbxSelectTrain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxSelectTrain.Size = new System.Drawing.Size(129, 31);
            this.cbxSelectTrain.TabIndex = 48;
            this.cbxSelectTrain.Text = "SE1";
            this.cbxSelectTrain.TextChanged += new System.EventHandler(this.cbxSelectTrain_TextChanged);
            this.cbxSelectTrain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSelectTrain_KeyPress);
            this.cbxSelectTrain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxSelectTrain_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dtgridviewSchedule;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 637);
            this.Controls.Add(this.dtgridviewSchedule);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.cbxSelectTrain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgridviewSchedule;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.ComboBox cbxSelectTrain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}