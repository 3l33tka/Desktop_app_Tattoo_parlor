using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    { 
        public Menu()
        {
            InitializeComponent();
            Animator.Start();
        }

        private void design1_Click(object sender, EventArgs e)
        {
            Requests rq = new Requests();
            rq.Show();
        }

        private void design3_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
        }

        private void design2_Click(object sender, EventArgs e)
        {
            Schedules schedule = new Schedules();
            schedule.Show();
        }

        private void design4_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.Show();
        }

        private void design5_Click(object sender, EventArgs e)
        {
            ServiceForm services = new ServiceForm();
            services.Show();
        }
       
    }
}
