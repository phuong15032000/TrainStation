using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSBuni.DTO
{
    class Station
    {
        private string stationid;
        private string city;
        public Station()
        {
            stationid = "";
            city = "";
        }
        public string Stationid { get => stationid; set => stationid = value; }
        public string City { get => city; set => city = value; }
    }
}
