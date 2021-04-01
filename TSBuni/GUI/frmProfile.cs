using System;
using TSBuni.DAO;
using TSBuni.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSBuni
{
    public partial class frmProfile : Form
    {
       
        public frmProfile()
        {
            InitializeComponent();
            lockControl();
            set();
        }
        public void set()
        {
            txbUsername.Text = frmLogin.loginaccount.Username;
            txbFullname.Text = frmLogin.loginaccount.Fullname;
            txbNumberPhone.Text = frmLogin.loginaccount.Phonenumber;
           // txbPassword.Text = frmLogin.loginaccount.Pass;
            txbEmail.Text = frmLogin.loginaccount.Email;
        }
        /*void ChangeAccount(Account acc)
        {
            txbUsername.Text = LoginAccount.Username;
            txbFullname.Text = LoginAccount.Fullname;
            txbNumberPhone.Text = LoginAccount.Phonenumber;
            txbPassword.Text = LoginAccount.Pass;
            txbEmail.Text = LoginAccount.Email;
        }*/
        
        void UpdateAccountInfo()
        {
            string userName = txbUsername.Text;
            string fullname = txbFullname.Text;
            string phonenumber = txbNumberPhone.Text;
            string email = txbEmail.Text;
            //txbUsername.Text = LoginAccount.Username;
            if(String.IsNullOrWhiteSpace(txbUsername.Text) || String.IsNullOrWhiteSpace(txbFullname.Text) || String.IsNullOrWhiteSpace(txbNumberPhone.Text) || String.IsNullOrWhiteSpace(txbEmail.Text) ) MessageBox.Show("Vui lòng nhập đủ thông tin");
            else if (AccountDAO.Instance.UpdateAccount(userName, fullname, phonenumber, email))
                {
                    MessageBox.Show("Cập nhật thành công\n\nUpdate Successfully");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        // private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //   UpdateAccountInfo();
        //}
        private event EventHandler<AccountEvent> changePass;
        public event EventHandler<AccountEvent> ChangePass
        {
            add { changePass += value; }
            remove { changePass -= value; }
        }
        void ChangePassword()
        {
            string userName = txbUsername.Text;
            string password = txbPassword.Text;
            string newpass = txbNewPassword.Text;
            string reenterPass = txbTypeAgain.Text;
            if (String.IsNullOrWhiteSpace(txbPassword.Text) || String.IsNullOrWhiteSpace(txbNewPassword.Text) || String.IsNullOrWhiteSpace(txbNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ\n\nPlease fill in all information");
                unlocktoChangePass();
            }
            else if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!\n\nPlease reconfirm your new password!");
                unlocktoChangePass();
            }
            else
            {
                if (AccountDAO.Instance.ChangePass(userName, password, newpass))
                {
                    if (!newpass.Equals(reenterPass))
                    {
                        
                        MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!\n\nPlease reconfirm your new password!");
                        unlocktoChangePass();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công\n\nUpdate Successfully");
                        if (changePass != null)
                        changePass(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                        txbPassword.Text = "";
                        txbNewPassword.Text = "";
                        txbTypeAgain.Text = "";
                        lockControl();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu hiện tại!\n\nYour current password is uncorrect!");
                    unlocktoChangePass();
                }
            }
            
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }
        private void lockControl()
        {
            txbUsername.ReadOnly = true;
            txbFullname.ReadOnly = true;
            txbEmail.ReadOnly = true;
            txbNumberPhone.ReadOnly = true;

            txbPassword.ReadOnly = true;
            txbNewPassword.ReadOnly = true;
            txbTypeAgain.ReadOnly = true;

            btnUpdate.Visible = true;
            btnChangePass.Visible = true;
            btnsaveforUpdate.Visible = false;
            btnsaveforChangePass.Visible = false;
        }
        private void unlocktoUpdate()
        {
            txbUsername.ReadOnly = true;
            txbFullname.ReadOnly = false;
            txbEmail.ReadOnly = false;
            txbNumberPhone.ReadOnly = false;

            txbPassword.ReadOnly = true;
            txbNewPassword.ReadOnly = true;
            txbTypeAgain.ReadOnly = true;

            btnUpdate.Visible = false;
            btnChangePass.Visible = false;
            btnsaveforUpdate.Visible = true;
            btnsaveforChangePass.Visible = false;
        }
        private void unlocktoChangePass()
        {
            txbUsername.ReadOnly = true;
            txbFullname.ReadOnly = true;
            txbEmail.ReadOnly = true;
            txbNumberPhone.ReadOnly = true;

            txbPassword.ReadOnly = false;
            txbNewPassword.ReadOnly = false;
            txbTypeAgain.ReadOnly = false;

            btnUpdate.Visible = false;
            btnChangePass.Visible = false;
            btnsaveforUpdate.Visible = false;
            btnsaveforChangePass.Visible = true;
        }
        private void txbUsername_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlocktoUpdate();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            unlocktoChangePass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangePassword();
            frmLogin.loginaccount = AccountDAO.Instance.GetAccountByUserName(txbUsername.Text);
            //lockControl();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
            frmLogin.loginaccount = AccountDAO.Instance.GetAccountByUserName(txbUsername.Text);
            lockControl();
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
        }
        
    }
}
