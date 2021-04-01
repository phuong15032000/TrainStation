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
    class TrainDAO
    {
        private static TrainDAO instance;
        public static TrainDAO Instance
        {
            get { if (instance == null) instance = new TrainDAO(); return TrainDAO.instance; }
            private set { TrainDAO.instance = value; }
        }
        public void settrain(List<Train> trains, string to)
        {
            Station s = new Station();
            s.City = to;
            string query2 = "select trainid from dbo.schedule where stationid='" + to + "';";
            DataTable dataChuyentau = DataProvider.Instance.ExecuteQuery(query2);
            for (int i = 0; i < dataChuyentau.Rows.Count; i++)
            {
                Train train = new Train();
                train.Trainid = dataChuyentau.Rows[i][0].ToString();
                trains.Add(train);
            }
        }
    }
}
