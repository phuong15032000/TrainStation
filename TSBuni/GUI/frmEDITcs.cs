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

namespace TSBuni.GUI
{
    public partial class frmEDITcs : Form
    {
        public frmEDITcs()
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
        

        private void cbxSelectTrain_TextChanged(object sender, EventArgs e)
        {
            set();
        }

        private void dtgridviewSchedule_SelectionChanged(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.Trainid = cbxSelectTrain.Text;
            s.Stationid = dtgridviewSchedule.CurrentRow.Cells[1].Value.ToString();
            s.Arrivaltime = dtgridviewSchedule.CurrentRow.Cells[2].Value.ToString();
            s.Departuretime = dtgridviewSchedule.CurrentRow.Cells[3].Value.ToString();
            txbStation.Text = s.Stationid;
            txbArrivalTime.Text = s.Arrivaltime;
            txbDepartureTime.Text = s.Departuretime;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.Trainid = cbxSelectTrain.Text;
            s.Stationid = txbStation.Text;
            s.Arrivaltime = txbArrivalTime.Text;
            s.Departuretime = txbDepartureTime.Text;
            ScheduleDAO.Instance.updateschedule(s.Trainid, s.Stationid, s.Arrivaltime, s.Departuretime);
            set();
        }
    }
}
