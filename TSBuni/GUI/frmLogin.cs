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
using TSBuni.GUI;

namespace TSBuni
{

    public partial class frmLogin : Form
    {   

        public static Account loginaccount ;
        
        public frmLogin()
        {
            InitializeComponent();
       
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txbPass_OnValueChanged(object sender, EventArgs e)
        {
            txbPass.isPassword = true;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string userName = txbUser.Text;
            string passWord = txbPass.Text;
            Account a = new Account();
            a.Username = txbUser.Text;
            a.Pass = txbPass.Text;
            if (Login(a.Username, a.Pass).Equals("member"))
            {
                loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                frmMainhome objfrmMainhome = new frmMainhome();
                this.Hide();
                objfrmMainhome.ShowDialog();
            }
            else
            if (Login(a.Username, a.Pass).Equals("admin"))
            {
                loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                frmAdminHome objfrmAdminhome = new frmAdminHome();
                this.Hide();
                objfrmAdminhome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu! \n\nUsername or Password is uncorrect!");
            }
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister objfrmRegister = new frmRegister();
            objfrmRegister.Show();
        }

        private void txbUser_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string userName = txbUser.Text;
                string passWord = txbPass.Text;
                Account a = new Account();
                a.Username = txbUser.Text;
                a.Pass = txbPass.Text;
                if (Login(a.Username, a.Pass).Equals("member"))
                {
                    loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    frmMainhome objfrmMainhome = new frmMainhome();
                    this.Hide();
                    objfrmMainhome.ShowDialog();
                }
                else
                if (Login(a.Username, a.Pass).Equals("admin"))
                {
                    loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    frmAdminHome objfrmAdminhome = new frmAdminHome();
                    this.Hide();
                    objfrmAdminhome.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!\n\nUsername or Password is uncorrect!");
                }
            }
        }
       
        string Login(string userName, string passWord)
        {
            return AccountDAO.Instance.login(userName, passWord);
        }
        
        private void txbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string userName = txbUser.Text;
                string passWord = txbPass.Text;
                Account a = new Account();
                a.Username = txbUser.Text;
                a.Pass = txbPass.Text;
                if (Login(a.Username, a.Pass).Equals("member"))
                {
                    loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    frmMainhome objfrmMainhome = new frmMainhome();
                    this.Hide();
                    objfrmMainhome.ShowDialog();
                }
                else
                if (Login(a.Username, a.Pass).Equals("admin"))
                {
                    loginaccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    frmAdminHome objfrmAdminhome = new frmAdminHome();
                    this.Hide();
                    objfrmAdminhome.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!\n\nUsername or Password is uncorrect!");
                }
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotPass obj = new frmForgotPass();
            obj.Show();
        }
    }
}
