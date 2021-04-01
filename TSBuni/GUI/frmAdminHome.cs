using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSBuni.GUI
{
    public partial class frmAdminHome : Form
    {
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlShowChild.Controls.Add(childForm);
            pnlShowChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEDITcs());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProfile());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure to Log out?";
            const string caption = "Note:";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin objfrmLogin = new frmLogin();
                this.Hide();
                objfrmLogin.ShowDialog();

            }
        }

        

       

        private void pnMinisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
