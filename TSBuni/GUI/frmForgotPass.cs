using System;
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
    public partial class frmForgotPass : Form
    {
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi yêu cầu đến Email của bạn, vui lòng kiểm tra");
        }
    }
}
