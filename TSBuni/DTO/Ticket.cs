using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TSBuni.DTO
{
    class Ticket
    {
        private string from;
        private string to;
        private string trainid;
        private string traincar;
        private string seatno;
        private string departuretime;
        private string arrivaltime;
        private string date;
        private string price;

        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string TrainID { get => trainid; set => trainid = value; }
        public string TrainCar { get => traincar; set => traincar = value; }
        public string SeatNo { get => seatno; set => seatno = value; }
        public string Departure { get => departuretime; set => departuretime = value; }
        public string Date { get => date; set => date = value; }
        public string Arrivaltime { get => arrivaltime; set => arrivaltime = value; }
        public string Price { get => price; set => price = value; }

        public Ticket()
        {
        }
        public Ticket(string from, string to, string trainid, string traincar, string seatno, string departuretime, string arrivaltime, string date, string price)
        {
            this.from = from;
            this.to = to;
            this.trainid = trainid;
            this.traincar = traincar;
            this.seatno = seatno;
            this.departuretime = departuretime;
            this.arrivaltime = arrivaltime;
            this.date = date;
            this.price = price;
        }
        


    }
}
