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

namespace TSBuni.DTO
{
    public class Account
    {
        private string username;
        private string pass;
        private string fullname;
        private string email;
        private string phonenumber;
        public Account(string username, string pass, string fullname, string email, string phonenumber)
        {
            this.username = username;
            this.pass = pass;
            this.fullname = fullname;
            this.email = email;
            this.phonenumber = phonenumber;
        }
        public Account()
        { }
        public Account(DataRow row)
        {
            this.username = row["username"].ToString();
            this.pass = row["pass"].ToString();
            this.fullname = row["fullname"].ToString();
            this.email = row["email"].ToString();
            this.phonenumber = row["phonenumber"].ToString();
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }

        }
        
    }
}