using TSBuni.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSBuni.DAO
{
    class ScheduleDAO
    {
        private static ScheduleDAO instance;
        public static ScheduleDAO Instance
        {
            get { if (instance == null) instance = new ScheduleDAO(); return ScheduleDAO.instance; }
            private set { ScheduleDAO.instance = value; }
        }

        public void loadschedule(List<Schedule> s, string trainid)
        {
            Schedule sche = new Schedule();
            sche.Trainid = trainid;
            string query = "select stationid,arrivaltime,departuretime from schedule where trainid='" + sche.Trainid + "' order by i;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Schedule schedule = new Schedule();
                schedule.Trainid = sche.Trainid;
                schedule.Stationid = dt.Rows[i]["stationid"].ToString();
                schedule.Arrivaltime = dt.Rows[i]["arrivaltime"].ToString();
                schedule.Departuretime = dt.Rows[i]["departuretime"].ToString();
                s.Add(schedule);
            }
        }

        public void updateschedule(string trainid, string stationid, string arrivaltime, string departuretime)

        {
            try 
            {
            Schedule s = new Schedule(trainid, stationid, arrivaltime, departuretime);
            DataProvider.Instance.ExecuteNonQuery("update schedule set arrivaltime = '" + s.Arrivaltime + "', departuretime = '" + s.Departuretime + "' where trainid='" + s.Trainid + "' and stationid='" + s.Stationid + "'");
            }

           catch (SqlException) { MessageBox.Show("Error");}
            }
        }
    
}
