using TSBuni.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace TSBuni.DAO
{
    class TicketDAO
    {
        private static TicketDAO instance;
        public static TicketDAO Instance
        {
            get { if (instance == null) instance = new TicketDAO(); return TicketDAO.instance; }
            private set { TicketDAO.instance = value; }
        }
        /*public Account GetTicketByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where username = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
*/
        public string dangkyve(string username, 
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
            SqlConnection con = new SqlConnection(DataProvider.Instance.connectString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                Ticket t = new Ticket(noidi,noiden,trainid,traincar,seatno,departuretime,arrivaltime,date,price);
                string query = "insert into ticket(codeticket, username, noidi, noiden, trainid, seatno, traincar, departuretime, arrivaltime, price, date ) values (" 
                    + "(CONCAT( CHAR(FLOOR(65 + (RAND() * 25))), FLOOR(RAND() * 9 + 1), CHAR(FLOOR(65 + (RAND() * 25))), CHAR(FLOOR(65 + (RAND() * 25))), CHAR(FLOOR(65 + (RAND() * 25))), FLOOR(RAND() * 9 + 1), CHAR(FLOOR(65 + (RAND() * 25))), CHAR(FLOOR(65 + (RAND() * 25))) )),'"
                    + username + "','"
                    + t.From + "','"
                    + t.To + "','"
                    + t.TrainID + "','"
                    + t.SeatNo + "','"
                    + t.TrainCar + "','"
                    + t.Departure + "','"
                    + t.Arrivaltime + "','"
                    + t.Price + "','"
                    + t.Date+"');";
                SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        return "thanh cong";
            }
            return "";
        }
        public bool trungve(string seatno,string traincar,string date,string trainid)
        {
            Ticket t = new Ticket("","",trainid,traincar,seatno,"","",date,"");
            SqlConnection con = new SqlConnection(DataProvider.Instance.connectString);
            con.Open();
            String query1 = "select * from ticket where seatno='" + t.SeatNo + "' and traincar='"+ t.TrainCar+ "' and date='"+ t.Date + "' and trainid='" + t.TrainID +"'";
            DataTable dtb1 = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query1, con);
            sda.Fill(dtb1);
            if (dtb1.Rows.Count != 0) return true;
            else return false;
        }
        public string setarrivaltime(string trainid)
        {
            Train t = new Train();
            t.Trainid = trainid;
            SqlConnection Conn = new SqlConnection(DataProvider.Instance.connectString);
            string query = "select arrivaltime from schedule where stationid='Da Nang' and trainid='" + t.Trainid + "';";
            SqlCommand Comm1 = new SqlCommand(query, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                return  DR1.GetValue(0).ToString();
            }
            Conn.Close();
            return "";
        }
        public string setdeparturetime(string trainid, string stationid)
        {
            Train t = new Train();
            t.Trainid = trainid;
            SqlConnection Conn = new SqlConnection(DataProvider.Instance.connectString);
            string query = "select arrivaltime from schedule where stationid='"+stationid+"' and trainid='" + t.Trainid + "';";
            SqlCommand Comm1 = new SqlCommand(query, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                return DR1.GetValue(0).ToString();
            }
            Conn.Close();
            return "";
        }

        public void setticketlist(List<Ticket> tickets)
        {
            string query = "select date as Date, noidi as 'From', noiden as 'To', departuretime as 'Departure Time', arrivaltime as 'Arrival Time', trainid as 'Train ID', traincar as 'Train Car', seatno as 'Seat No', price as 'Price' from ticket where username = '" + frmLogin.loginaccount.Username + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Date = dt.Rows[i]["Date"].ToString();
                ticket.From = dt.Rows[i]["From"].ToString();
                ticket.To = dt.Rows[i]["To"].ToString();
                ticket.Departure = dt.Rows[i]["Departure Time"].ToString();
                ticket.Arrivaltime = dt.Rows[i]["Arrival Time"].ToString();
                ticket.TrainID = dt.Rows[i]["Train ID"].ToString();
                ticket.TrainCar = dt.Rows[i]["Train Car"].ToString();
                ticket.SeatNo = dt.Rows[i]["Seat No"].ToString();
                ticket.Price = dt.Rows[i]["Price"].ToString();
                tickets.Add(ticket);
            }
        }

        public double setbill()
        {
            SqlConnection Conn = new SqlConnection(DataProvider.Instance.connectString);
            string query = "select sum(price) from ticket where username='" + frmLogin.loginaccount.Username + "';";
            SqlCommand Comm1 = new SqlCommand(query, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                return Double.Parse(DR1.GetValue(0).ToString());
            }
            Conn.Close();
            return 0;
        }

        public void deleteticket(Ticket ticket)
        {
            string query = "delete from ticket where username='"
                + frmLogin.loginaccount.Username + "' and trainid='"
                + ticket.TrainID + "' and traincar='"
                + ticket.TrainCar + "' and seatno='"
                + ticket.SeatNo + "' and date='"
                + ticket.Date + "';";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
