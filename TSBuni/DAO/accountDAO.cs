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

    public class AccountDAO

    {
       
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }
        
        public string register(string username, string password, string fullname, string email, string phonenumber)
        {
            SqlConnection con = new SqlConnection(DataProvider.Instance.connectString);
            con.Open();
            Account a = new Account(username,password,fullname,email,phonenumber);
            
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "insert into account( username, pass, fullname, Email, phonenumber, permissionid ) values('"
                    + a.Username + "','"
                    + a.Pass + "','"
                    + a.Fullname + "','"
                    + a.Email + "','"
                    + a.Phonenumber + "','member');";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    
                    {
                        if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(fullname) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(phonenumber))
                        {
                            return "chua dien"; ;
                        }

                        else
                        {
                            cmd.ExecuteNonQuery();
                            return "thanh cong";
                        }
                    }
                    
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    /*"loi sql";*/
                    return "loi sql";
                }
            }
            return "";
        }
        public bool trungten(string username)
        {
            Account a = new Account(username, "", "", "", "");
            DataTable dtb1 = new DataTable();
            dtb1 = DataProvider.Instance.ExecuteQuery("select username from account where username='" + a.Username + "';");
            if (dtb1.Rows.Count != 0) return true;
            else return false;
        }
        public bool UpdateAccount(string userName, string fullName, string phonenumber, string email)
        {
            Account a = new Account(userName,"",fullName,phonenumber,email);
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE account set fullname='"+a.Fullname+"', Email='"+a.Email+"',phonenumber='"+a.Phonenumber+"' where username='"+a.Username+"'");
            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            Account a = new Account(userName, "", "", "", "");
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where username = '" + a.Username + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool ChangePass(string userName, string pass, string newPass)
        {   

            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_ChangePass @userName , @password , @newPassword", new object[] { userName, pass, newPass });

            return result > 0;
        }
        public string login(string username, string password)
        {
            Account a = new Account();
            a.Username = username;
            a.Pass = password;
            DataTable dtb1 = DataProvider.Instance.ExecuteQuery("select username, pass from account where username='" + a.Username + "' and pass='" + a.Pass + "' and permissionid='admin';");
            if (dtb1.Rows.Count == 1)
            {
                return "admin";
            }
                DataTable dtb2 = DataProvider.Instance.ExecuteQuery("select username, pass from account where username='" + a.Username + "' and pass='" + a.Pass + "' and permissionid='member';");

                if (dtb2.Rows.Count == 1)
                {
                    return "member";
                }
            
            else
            {
                return "false";
            }
        }

    }
}

