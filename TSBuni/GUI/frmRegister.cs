using TSBuni.DAO;
using TSBuni.DTO;
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
using System.Runtime.InteropServices.WindowsRuntime;

namespace TSBuni
{
    public partial class frmRegister : Form
    { 

        public frmRegister()
        {
            InitializeComponent();
        }
        
        private void picMinisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txbPassword_OnValueChanged(object sender, EventArgs e)
        {
            txbPassword.isPassword = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.Show();
            this.Close();

        }

        private void txbFullname_OnValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnRegister_Click(object sender, EventArgs e)

        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            string fullname = txbFullname.Text;
            string email = txbEmail.Text;
            string phonenumber = txbPhone.Text;

            if (trungten(userName)==false)
            {
                if (checkregister(userName, passWord, fullname, email, phonenumber) == "chua dien") MessageBox.Show("Xin điền đủ thông tin\n\nPlease fill in all information");
                else if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay không?\n\nSign Up Successfully! Would you like to log in now?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.Show();
                    this.Close();
                }
                else
                {
                    txbFullname.Text = "";
                    txbPassword.Text = "";
                    txbEmail.Text = "";
                    txbUsername.Text = "";
                    txbPhone.Text = "";
                }
            } else MessageBox.Show("Tài khoản đã có người sử dụng\n\nPlease choose another Username");
            //if (checkregister(userName, passWord, fullname, email, fullname) == "loi sql") MessageBox.Show("Xin kiểm tra lại thông tin");
            /*if (checkregister(userName, passWord, fullname, email, fullname) == "chua dien") MessageBox.Show("Xin điền đủ thông tin"); else 
            if (checkregister(userName, passWord, fullname, email, fullname) == "loi sql") MessageBox.Show("Xin kiểm tra lại thông tin"); else
            if (checkregister(userName, passWord, fullname, email, fullname) == "thanh cong")
            {
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay không?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.Show();
                    this.Close();
                }
                else
                {
                    txbFullname.Text = "";
                    txbPassword.Text = "";
                    txbEmail.Text = "";
                    txbUsername.Text = "";
                    txbPhone.Text = "";
                }
            }     */
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {

                string userName = txbUsername.Text;
                string passWord = txbPassword.Text;
                string fullname = txbFullname.Text;
                string email = txbEmail.Text;
                string phonenumber = txbPhone.Text;

                if (trungten(userName) == false)
                {
                    if (checkregister(userName, passWord, fullname, email, phonenumber) == "chua dien") MessageBox.Show("Xin điền đủ thông tin");
                    else if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay không?\n\nSign Up Successfully! Would you like to log in now?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmLogin objfrmLogin = new frmLogin();
                        objfrmLogin.Show();
                        this.Close();
                    }
                    else
                    {
                        txbFullname.Text = "";
                        txbPassword.Text = "";
                        txbEmail.Text = "";
                        txbUsername.Text = "";
                        txbPhone.Text = "";
                    }
                }
                else MessageBox.Show("Tài khoản đã có người sử dụng\n\nPlease choose another Username");
            }
        }
        /*bool Kiemtratrung(string userName)
        {
            return AccountDAO.Instance.trungten(userName);
        }*/
        string checkregister(string username, string password, string fullname, string email, string phonenumber)
        {
            if (AccountDAO.Instance.register(username, password, fullname, email, phonenumber) == "chua dien") return "chua dien";
            if (AccountDAO.Instance.register(username, password, fullname, email, phonenumber) == "thanh cong") return "thanh cong";
            if (AccountDAO.Instance.register(username, password, fullname, email, phonenumber) == "trung ten") return "trung ten";
            if (AccountDAO.Instance.register(username, password, fullname, email, phonenumber) == "loi sql") return "loi sql";
            return "";
        }
        bool trungten(string username)
        {
            return AccountDAO.Instance.trungten(username);
        }
    }
    }

