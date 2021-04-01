using TSBuni.DAO;
using TSBuni.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TSBuni
{
    public partial class frmTicket : Form
    {
        // Khai bao bien
        string strTrip = "", strDatepicker = "", strTo = "", strTrainCar = "", strSeatNo = "", strTrain = "";
        double strPrice = 0;

        public frmTicket()
        {
            InitializeComponent();            
            dateTimePicker1.MinDate = DateTime.Now;
            loadticket();
            lockControlDefault();
        }

        void unlockControlDefault()
        {
            dateTimePicker1.Enabled = true;
            cbTrain.Enabled = true;
            cbxTrainCar.Enabled = true;
            cbxSeatNo.Enabled = true;


            btnBooking.Visible = true;
            btnPayment.Enabled = true;
            btnDeleteTicket.Enabled = true;

        }
        void lockControlDefault()
        {

            cbCity.Text = "Mời chọn nơi đến";
            cbTo.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbTrain.Enabled = false;
            cbxTrainCar.Enabled = false;
            cbxSeatNo.Enabled = false;

            btnBooking.Visible = false;
            btnPayment.Enabled = false;
            btnDeleteTicket.Enabled = false;

        }
        
        void lockControl()
        {
            btnDeleteTicket.Enabled = false;
        }
        void unlockControl()
        {
            btnDeleteTicket.Enabled = true;
            
            btnPayment.Enabled = true;
        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            string username = frmLogin.loginaccount.Username;
            string noidi = txbFrom.Text;
            string noiden = cbTo.Text;
            string trainid = cbTrain.Text;
            string seatno = cbxSeatNo.Text;
            string traincar = cbxTrainCar.Text;
            string arrivaltime = txbArrivaltime.Text;
            string departuretime = txbDepatureTime.Text;
            string price = txbPrice.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            Ticket t = new Ticket(noidi,noiden,trainid,traincar,seatno,departuretime,arrivaltime,date,price);
            if (isRightInput())
            {
                if (trungve(t.SeatNo, t.TrainCar, t.Date, t.TrainID) == false)
                {
                    if (checkdangkyve(username, t.From, t.To, t.TrainID, t.SeatNo, t.TrainCar, t.Departure, t.Arrivaltime, t.Price, t.Date) == "thanh cong")
                    {
                        MessageBox.Show("Đăng ký vé thành công!\n\nYour ticket has been successfully registered!");
                        if (getInfoTicket())
                        {
                            loadticket();
                        };
                    }
                }
                else MessageBox.Show("Chỗ ngồi đã có người đặt\n\nSeat already reserved");
            }
            else MessageBox.Show("Nhập không hợp lệ, vui lòng kiểm tra lại\n\nInvalid input, please check again");
        }
        private void btnDeleteTicket_Click_1(object sender, EventArgs e)
        {
           
            string from = dtgridviewListTicket.SelectedRows[0].Cells[0].Value.ToString();
            string to = dtgridviewListTicket.SelectedRows[0].Cells[1].Value.ToString();
            string trainid = dtgridviewListTicket.SelectedRows[0].Cells[2].Value.ToString();
            string traincar = dtgridviewListTicket.SelectedRows[0].Cells[3].Value.ToString();
            string seatno = dtgridviewListTicket.SelectedRows[0].Cells[4].Value.ToString();
            string departure = dtgridviewListTicket.SelectedRows[0].Cells[5].Value.ToString();
            string date = dtgridviewListTicket.SelectedRows[0].Cells[6].Value.ToString();
            string price = dtgridviewListTicket.SelectedRows[0].Cells[7].Value.ToString();
            Ticket ticketdelete = new Ticket(from, to, trainid, traincar, seatno, departure,"", date, price) ;
            TicketDAO.Instance.deleteticket(ticketdelete);
            
            loadticket();
        }
        private void cbTrip_Click(object sender, EventArgs e)
        {
            Station s = new Station();
            s.City = cbCity.Text;
            //string city = cbCity.Text;
            List<Station> stations = new List<Station>();
            StationDAO.Instance.setstation(stations,s.City);
            cbTo.DataSource = stations;
            cbTo.DisplayMember = "stationid";
            unlockControlDefault();
        }
        private void cbCity_Click(object sender, EventArgs e)
        {
            List<Station> stations = new List<Station>();
            StationDAO.Instance.setcity(stations);
            cbCity.DataSource = stations;
            cbCity.DisplayMember = "city";
            cbTo.Text = "Mời chọn ga";
            cbTo.Enabled = true;
        }
        private void dtgridviewListTicket_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dtgridviewListTicket.ColumnCount > 0)
                unlockControl();
            if (dtgridviewListTicket.ColumnCount == 0)
                lockControl();
        }
        private void cbTrain_TextChanged(object sender, EventArgs e)
        {
            Schedule sche = new Schedule();
            sche.Stationid = cbTo.Text;
            sche.Trainid = cbTrain.Text;
            //string stationid = cbTo.Text;
            txbDepatureTime.Text = TicketDAO.Instance.setarrivaltime(sche.Trainid);
            txbArrivaltime.Text = TicketDAO.Instance.setdeparturetime(sche.Trainid,sche.Stationid);
        }
        void settrain(string to)
        {
            List<Train> trains = new List<Train>();
            TrainDAO.Instance.settrain(trains, to);
            cbTrain.DataSource = trains;
            cbTrain.DisplayMember = "trainid";
        }
        private void cbTo_TextChanged_1(object sender, EventArgs e)
        {
            Station st = new Station();
            st.City = cbTo.Text;
            //string to = cbTo.Text;
            settrain(st.City);
        }

        private void cbTrain_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxSeatNo_TextChanged(object sender, EventArgs e)
        {
            setPrice();
        }


        bool getInfoTicket()
        {
            try
            {
                strDatepicker = dateTimePicker1.Value.ToShortDateString();

                strTrip = cbTo.GetItemText(cbTo.SelectedItem); // bien tam de luu Trip

                strTrain = strTrip.Substring(strTrip.Length - 4);

                strTo = strTrip.Substring(0, strTrip.Length - 4);

                strPrice = Double.Parse(txbPrice.Text);

                strSeatNo = cbxSeatNo.SelectedItem.ToString();

                strTrainCar = cbxTrainCar.SelectedItem.ToString();

                
                return true;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment obj = new frmPayment();
            obj.setPrice("999 000 000 VND");
            obj.ShowDialog();
        }

        void loadticket()
        {
            List<Ticket> tickets = new List<Ticket>();
            TicketDAO.Instance.setticketlist(tickets);
            dtgridviewListTicket.DataSource = tickets;
        }

        Boolean isRightInput()
        {
            Boolean condi1 = false, condi2 = false, condi3 = false;

            int indexOfTo = cbTo.SelectedIndex;
            if (cbxSeatNo.Items.Contains(cbxSeatNo.Text)) condi1 = true;
            if (cbxTrainCar.Items.Contains(cbxTrainCar.Text)) condi2 = true;
            if (cbTo.GetItemText(cbTo.SelectedItem) == cbTo.Text) condi3 = true;
            if (condi1 == true && condi2 == true && condi3 == true) return true;
            return false;
        }

        private void cbCity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxSeatNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void setPrice()
        {
            try
            {
                strSeatNo = cbxSeatNo.SelectedItem.ToString();

                strTrainCar = cbxTrainCar.SelectedItem.ToString();
            }
            catch
            {
                txbPrice.Text = "0";
            }

            int intSeatNo = 0;

            try { 
            intSeatNo = Int32.Parse(strSeatNo);
            }
            catch
            {
                intSeatNo = 0;
            }
            switch (intSeatNo)
            {
                case 1:
                    strPrice = 699000;
                    break;
                case 2:
                    strPrice = 890000;
                    break;
                case 3:
                    strPrice = 630000;
                    break;
                case 4:
                    strPrice = 720000;
                    break;
                case 5:
                case 6:
                    strPrice = 890000;
                    break;
                case 7:
                    strPrice = 639000;
                    break;
                case 8:
                    strPrice = 399000;
                    break;
                case 9:
                case 10:
                    strPrice = 639000;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    strPrice = 420000;
                    break;
                case 15:
                    strPrice = 620000;
                    break;
                case 16:
                case 17:
                case 18:
                    strPrice = 1399000;
                    break;
                case 19:
                    strPrice = 1399000;
                    break;
                case 20:
                    strPrice = 999000;
                    break;
                default:
                    strPrice = 0;
                    break;
            }
            txbPrice.Text = strPrice.ToString();
        }
        string checkdangkyve(string username,
            string noidi,
            string noiden,
            string trainid,
            string seatno,
            string traincar,
            string departuretime,
            string arrivaltime,
            string price,
            string date)
        {

            if (TicketDAO.Instance.dangkyve(username, noidi, noiden, trainid, seatno, traincar, departuretime, arrivaltime, price, date) == "thanh cong") return "thanh cong";
            if (TicketDAO.Instance.dangkyve(username, noidi, noiden, trainid, seatno, traincar, departuretime, arrivaltime, price, date) == "loi sql") return "loi sql";
            return "";
        }
        bool trungve(string seatno, string traincar, string date, string trainid)
        {
            //trung ve tren DB
            return (TicketDAO.Instance.trungve(seatno, traincar, date,trainid));
        }
        string TotalPrice()
        {
            string price="";

            return price;
        }
        bool trungveDataGrid()
        {
            string datepicker = dateTimePicker1.Value.ToShortDateString();
            string seatno = cbxSeatNo.Text;
            string traincar = cbxTrainCar.Text;
            string train;
            try {
                string trip = cbTo.GetItemText(cbTo.SelectedItem);
                train = trip.Substring(trip.Length - 4);
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return false;
            }
            string temptocompare1 = datepicker + train + traincar + seatno;
            string temptocompare2 = "";
            int countrow = dtgridviewListTicket.RowCount;
            for (int i = 0; i < countrow; i++)
            {
                temptocompare2 = dtgridviewListTicket.Rows[i].Cells[0].Value.ToString() + dtgridviewListTicket.Rows[i].Cells[4].Value.ToString() + dtgridviewListTicket.Rows[i].Cells[5].Value.ToString() + dtgridviewListTicket.Rows[i].Cells[6].Value.ToString();
                if (String.Equals(temptocompare1, temptocompare2)) return true;
            }
            return false;
        }
    }
}
