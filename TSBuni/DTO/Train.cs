using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSBuni.DTO
{
    class Train
    {
        private string trainid;

        public Train()
        {
            trainid = "";
        }
        public string Trainid { get => trainid; set => trainid = value; }
    }
}
