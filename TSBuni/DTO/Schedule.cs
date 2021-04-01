using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSBuni.DTO
{
    class Schedule
    {
        private string trainid;
        private string stationid;
        private string arrivaltime;
        private string departuretime;

        public Schedule() { }
        public Schedule(string trainid, string stationid, string arrivaltime, string departuretime)
        {
            this.trainid = trainid;
            this.stationid = stationid;
            this.arrivaltime = arrivaltime;
            this.departuretime = departuretime;
        }
        public string Trainid { get => trainid; set => trainid = value; }
        public string Stationid { get => stationid; set => stationid = value; }
        public string Arrivaltime { get => arrivaltime; set => arrivaltime = value; }
        public string Departuretime { get => departuretime; set => departuretime = value; }
        
    }
}
