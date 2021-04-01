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


namespace TSBuni
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
            set();
        }

        public void set()
        {
            string trainid = cbxSelectTrain.Text;
            List<Schedule> s = new List<Schedule>();
            ScheduleDAO.Instance.loadschedule(s, trainid);
            dtgridviewSchedule.DataSource = s;
        }
        private void cbxSelectTrain_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
        }

        private void cbxSelectTrain_TextChanged(object sender, EventArgs e)
        {
            set();
        }

        private void cbxSelectTrain_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
