using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSBuni.DAO;

namespace TSBuni
{
    public partial class frmPayment : Form
    {
        //string s="0 VND";
        public frmPayment()
        {
            InitializeComponent();
            setDefault();
        }
        public void setPrice(string price)
        {
            price = TicketDAO.Instance.setbill().ToString();
            txbPRICE.Text = price + " VND";
        }
        void setDefault()
        {
            
            lbtype.Text = "Transfering your total money to under \n\n      Bank Number with message: \n\n   ''<<username>> Payment Ticket''";
            lbEx.Text = "Ex: mtr123 Payment Ticket";
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
