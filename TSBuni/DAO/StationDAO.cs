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
    class StationDAO
    {
        private static StationDAO instance;
        public static StationDAO Instance
        {
            get { if (instance == null) instance = new StationDAO(); return StationDAO.instance; }
            private set { StationDAO.instance = value; }
        }
        public void setstation(List<Station> stations, string city)
        {
            Station s = new Station();
            s.City = city;
            string query = "SELECT DISTINCT stationid FROM dbo.stations where city='"+s.City+"';";
            DataTable dataNoiden = DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dataNoiden.Rows.Count; i++)
            {
                Station station = new Station();
                station.Stationid = dataNoiden.Rows[i][0].ToString();
                stations.Add(station);
            }
        }

        public void setcity(List<Station> stations)
        {
            string query = "select DISTINCT city from stations where city!='Da Nang' order by city;";
            DataTable dataCity = DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dataCity.Rows.Count; i++)
            {
                Station station = new Station();
                station.City = dataCity.Rows[i][0].ToString();
                stations.Add(station);
            }
        }
    }
}
