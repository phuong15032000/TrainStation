namespace TSBuni
{
    partial class frmTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.cbxSeatNo = new System.Windows.Forms.ComboBox();
            this.dtgridviewListTicket = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbSeatNo = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.cbxTrainCar = new System.Windows.Forms.ComboBox();
            this.lbTrainCar = new System.Windows.Forms.Label();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.scheduleBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.txbDepatureTime = new System.Windows.Forms.TextBox();
            this.lbArrivalTime = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txbArrivaltime = new System.Windows.Forms.TextBox();
            this.scheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lbStation = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.scheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbPrice = new System.Windows.Forms.Label();
            this.scheduleBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBooking = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrain = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewListTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSeatNo
            // 
            this.cbxSeatNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSeatNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSeatNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeatNo.FormattingEnabled = true;
            this.cbxSeatNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxSeatNo.Location = new System.Drawing.Point(508, 102);
            this.cbxSeatNo.Name = "cbxSeatNo";
            this.cbxSeatNo.Size = new System.Drawing.Size(181, 31);
            this.cbxSeatNo.TabIndex = 51;
            this.cbxSeatNo.SelectedIndexChanged += new System.EventHandler(this.cbxSeatNo_SelectedIndexChanged);
            this.cbxSeatNo.TextChanged += new System.EventHandler(this.cbxSeatNo_TextChanged);
            // 
            // dtgridviewListTicket
            // 
            this.dtgridviewListTicket.AllowUserToAddRows = false;
            this.dtgridviewListTicket.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.dtgridviewListTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgridviewListTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridviewListTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridviewListTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.dtgridviewListTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgridviewListTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgridviewListTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridviewListTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgridviewListTicket.ColumnHeadersHeight = 60;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridviewListTicket.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgridviewListTicket.DoubleBuffered = true;
            this.dtgridviewListTicket.EnableHeadersVisualStyles = false;
            this.dtgridviewListTicket.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.dtgridviewListTicket.HeaderForeColor = System.Drawing.Color.White;
            this.dtgridviewListTicket.Location = new System.Drawing.Point(24, 242);
            this.dtgridviewListTicket.Name = "dtgridviewListTicket";
            this.dtgridviewListTicket.ReadOnly = true;
            this.dtgridviewListTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgridviewListTicket.RowHeadersVisible = false;
            this.dtgridviewListTicket.RowHeadersWidth = 51;
            this.dtgridviewListTicket.RowTemplate.DividerHeight = 3;
            this.dtgridviewListTicket.RowTemplate.Height = 30;
            this.dtgridviewListTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridviewListTicket.Size = new System.Drawing.Size(1094, 327);
            this.dtgridviewListTicket.TabIndex = 45;
            this.dtgridviewListTicket.SelectionChanged += new System.EventHandler(this.dtgridviewListTicket_SelectionChanged_1);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Enabled = false;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTicket.Location = new System.Drawing.Point(776, 585);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(152, 40);
            this.btnDeleteTicket.TabIndex = 42;
            this.btnDeleteTicket.Text = "Cancel Ticket";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dtgridviewListTicket;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(244, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Please check-in earlier 15 minutes before the Departure Time of the Train !";
            // 
            // lbSeatNo
            // 
            this.lbSeatNo.AutoSize = true;
            this.lbSeatNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatNo.Location = new System.Drawing.Point(394, 105);
            this.lbSeatNo.Name = "lbSeatNo";
            this.lbSeatNo.Size = new System.Drawing.Size(93, 23);
            this.lbSeatNo.TabIndex = 50;
            this.lbSeatNo.Text = "Seat No:";
            // 
            // btnPayment
            // 
            this.btnPayment.Enabled = false;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPayment.Location = new System.Drawing.Point(952, 585);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(152, 40);
            this.btnPayment.TabIndex = 49;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(912, 102);
            this.txbPrice.Multiline = true;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(181, 31);
            this.txbPrice.TabIndex = 47;
            this.txbPrice.Text = "0 VND";
            // 
            // cbxTrainCar
            // 
            this.cbxTrainCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTrainCar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTrainCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrainCar.FormattingEnabled = true;
            this.cbxTrainCar.Items.AddRange(new object[] {
            "Car 1",
            "Car 2",
            "Car 3",
            "Car 4",
            "Car 5",
            "Car 6",
            "Car 7",
            "Car 8"});
            this.cbxTrainCar.Location = new System.Drawing.Point(508, 60);
            this.cbxTrainCar.Name = "cbxTrainCar";
            this.cbxTrainCar.Size = new System.Drawing.Size(181, 31);
            this.cbxTrainCar.TabIndex = 44;
            // 
            // lbTrainCar
            // 
            this.lbTrainCar.AutoSize = true;
            this.lbTrainCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrainCar.Location = new System.Drawing.Point(387, 63);
            this.lbTrainCar.Name = "lbTrainCar";
            this.lbTrainCar.Size = new System.Drawing.Size(100, 23);
            this.lbTrainCar.TabIndex = 43;
            this.lbTrainCar.Text = "Train Car:";
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.AutoSize = true;
            this.lbDepartureTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureTime.Location = new System.Drawing.Point(737, 20);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(158, 23);
            this.lbDepartureTime.TabIndex = 34;
            this.lbDepartureTime.Text = "Depature Time:";
            // 
            // cbTo
            // 
            this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(121, 102);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(181, 31);
            this.cbTo.TabIndex = 32;
            this.cbTo.TextChanged += new System.EventHandler(this.cbTo_TextChanged_1);
            this.cbTo.Click += new System.EventHandler(this.cbTrip_Click);
            // 
            // scheduleBindingSource7
            // 
            this.scheduleBindingSource7.DataMember = "schedule";
            // 
            // tSDataSet2
            // 
            // 
            // scheduleBindingSource4
            // 
            this.scheduleBindingSource4.DataMember = "schedule";
            // 
            // tSDataSet
            // 
            // 
            // scheduleBindingSource3
            // 
            this.scheduleBindingSource3.DataMember = "schedule";
            // 
            // txbFrom
            // 
            this.txbFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrom.Location = new System.Drawing.Point(121, 17);
            this.txbFrom.Multiline = true;
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.ReadOnly = true;
            this.txbFrom.Size = new System.Drawing.Size(181, 31);
            this.txbFrom.TabIndex = 31;
            this.txbFrom.Text = "Da Nang";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 32);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(41, 149);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(64, 23);
            this.lbDate.TabIndex = 38;
            this.lbDate.Text = "Date:";
            // 
            // txbDepatureTime
            // 
            this.txbDepatureTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepatureTime.Location = new System.Drawing.Point(912, 17);
            this.txbDepatureTime.Multiline = true;
            this.txbDepatureTime.Name = "txbDepatureTime";
            this.txbDepatureTime.ReadOnly = true;
            this.txbDepatureTime.Size = new System.Drawing.Size(181, 31);
            this.txbDepatureTime.TabIndex = 37;
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.AutoSize = true;
            this.lbArrivalTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTime.Location = new System.Drawing.Point(769, 63);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(126, 23);
            this.lbArrivalTime.TabIndex = 36;
            this.lbArrivalTime.Text = "Arrival Time:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(20, 216);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(190, 23);
            this.lbResult.TabIndex = 40;
            this.lbResult.Text = "List Tickets Booked:";
            // 
            // txbArrivaltime
            // 
            this.txbArrivaltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArrivaltime.Location = new System.Drawing.Point(912, 60);
            this.txbArrivaltime.Multiline = true;
            this.txbArrivaltime.Name = "txbArrivaltime";
            this.txbArrivaltime.ReadOnly = true;
            this.txbArrivaltime.Size = new System.Drawing.Size(181, 31);
            this.txbArrivaltime.TabIndex = 35;
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStation.Location = new System.Drawing.Point(24, 105);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(81, 23);
            this.lbStation.TabIndex = 33;
            this.lbStation.Text = "Station:";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(41, 20);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(63, 23);
            this.lbFrom.TabIndex = 30;
            this.lbFrom.Text = "From:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(833, 105);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(62, 23);
            this.lbPrice.TabIndex = 46;
            this.lbPrice.Text = "Price:";
            // 
            // scheduleTableAdapter
            // 
            // 
            // btnBooking
            // 
            this.btnBooking.ActiveBorderThickness = 1;
            this.btnBooking.ActiveCornerRadius = 20;
            this.btnBooking.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(186)))), ((int)(((byte)(216)))));
            this.btnBooking.ActiveForecolor = System.Drawing.Color.Black;
            this.btnBooking.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(186)))), ((int)(((byte)(216)))));
            this.btnBooking.BackColor = System.Drawing.Color.White;
            this.btnBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBooking.BackgroundImage")));
            this.btnBooking.ButtonText = "Booking Now!";
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.IdleBorderThickness = 1;
            this.btnBooking.IdleCornerRadius = 20;
            this.btnBooking.IdleFillColor = System.Drawing.Color.White;
            this.btnBooking.IdleForecolor = System.Drawing.Color.Red;
            this.btnBooking.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.btnBooking.Location = new System.Drawing.Point(912, 141);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(5);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(181, 41);
            this.btnBooking.TabIndex = 41;
            this.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Train:";
            // 
            // cbTrain
            // 
            this.cbTrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrain.FormattingEnabled = true;
            this.cbTrain.Location = new System.Drawing.Point(508, 17);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(181, 31);
            this.cbTrain.TabIndex = 54;
            this.cbTrain.TextChanged += new System.EventHandler(this.cbTrain_TextChanged);
            this.cbTrain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTrain_KeyPress);
            // 
            // cbCity
            // 
            this.cbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(121, 60);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(181, 31);
            this.cbCity.TabIndex = 55;
            this.cbCity.TextChanged += new System.EventHandler(this.cbCity_TextChanged);
            this.cbCity.Click += new System.EventHandler(this.cbCity_Click);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(68, 63);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(36, 23);
            this.lbCity.TabIndex = 56;
            this.lbCity.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(582, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Note:";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.cbTrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSeatNo);
            this.Controls.Add(this.dtgridviewListTicket);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSeatNo);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.cbxTrainCar);
            this.Controls.Add(this.lbTrainCar);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lbDepartureTime);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.txbFrom);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txbDepatureTime);
            this.Controls.Add(this.lbArrivalTime);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txbArrivaltime);
            this.Controls.Add(this.lbStation);
            this.Controls.Add(this.lbFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewListTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSeatNo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgridviewListTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSeatNo;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.ComboBox cbxTrainCar;
        private System.Windows.Forms.Label lbTrainCar;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.BindingSource scheduleBindingSource3;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txbDepatureTime;
        private System.Windows.Forms.Label lbArrivalTime;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txbArrivaltime;
        private System.Windows.Forms.BindingSource scheduleBindingSource2;
        private System.Windows.Forms.Label lbStation;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.BindingSource scheduleBindingSource1;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource scheduleBindingSource4;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.BindingSource scheduleBindingSource5;
        private System.Windows.Forms.BindingSource scheduleBindingSource6;
        private System.Windows.Forms.BindingSource scheduleBindingSource7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrain;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label label3;
    }
}