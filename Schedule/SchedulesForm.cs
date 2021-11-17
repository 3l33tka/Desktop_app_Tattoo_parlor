using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Project1
{
    public partial class Schedules : MetroFramework.Forms.MetroForm
    {
        public Schedules()
        {
            InitializeComponent();
            numericUpDown1.Value = currentcountonpage;
        }
        #region
        public int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int feedbackforpat;
        public int ClientID
        {
            get { return feedbackforpat; }
            set { feedbackforpat = value; }
        }
        private int Status;
        public int stat
        {
            get { return Status; }
            set { Status = value; }
        }

        public int backid;
        public int feedbackid
        {
            get { return backid; }
            set { backid = value; }
        }

        private int chid;

        public int choosenid
        {
            get { return chid; }
            set { chid = value; }
        }
        private int maxpage;
        private int currentpage;
        private int currentcountonpage = 10;
        #endregion

        private void FillSchedule(int page, int countonpage)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                dataGridView1.Rows.Clear();
                var groupbyname = from w in db.Schedule
                                  group w by w.Employee.FIO;
                foreach (var g in groupbyname)
                {
                    dataGridView1.Rows.Add(g.Key);
                    maxpage = g.Count() / countonpage;
                    if (g.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Schedule sched in g.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        DateTime s = Convert.ToDateTime(sched.DateStart);
                        DateTime e = Convert.ToDateTime(sched.DateFinish);
                        dataGridView1.Rows.Add(sched.ID, sched.Employee.FIO, sched.Employee.Post,Convert.ToString(s.ToShortDateString()), Convert.ToString(s.ToShortTimeString()), Convert.ToString(e.ToShortTimeString()));
                    }
                }
            }
        }
      
        private void FormSchedule(object sender, EventArgs e)
        {
            currentpage = 1;
            FillSchedule(currentpage, currentcountonpage);
            back.Enabled = false;
            metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { next.Enabled = false; }
            else
            { next.Enabled = true; }
        }
        private void Schedules_Load(object sender, EventArgs e)
        {
            FillSchedule(currentpage, currentcountonpage);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ScheduleCard formcard = new ScheduleCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Schedule p = db.Schedule.Find(id);
                formcard.Currentid = id;
                formcard.ShowDialog();
                FillSchedule(currentpage, currentcountonpage);
                metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { next.Enabled = false; }
                else
                { next.Enabled = true; }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) //Добавить новую запись расписания 
        {
            ScheduleEdit se = new ScheduleEdit();
            se.Text = "Новая запись расписания";
            se.ShowDialog();
            FillSchedule(currentpage, currentcountonpage);
        }

        private void next_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                next.Enabled = false;
            }
            FillSchedule(currentpage, currentcountonpage);
            metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void back_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                back.Enabled = false;
            }
            FillSchedule(currentpage, currentcountonpage);
            metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentcountonpage = Convert.ToInt32(numericUpDown1.Value);
            FormSchedule(numericUpDown1, e);
        }

        private void metroButton2_Click(object sender, EventArgs e) //обновить форму
        {
            FillSchedule(currentpage, currentcountonpage);
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            if(FIOSEARCH.Text != "")
            {
                List<Schedule> schedulist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Schedule.Where(x => x.Employee.FIO == FIOSEARCH.Text);
                    schedulist = temp1.ToList();
                    foreach (Schedule sched in schedulist)
                    {
                        DateTime s = Convert.ToDateTime(sched.DateStart);
                        DateTime end = Convert.ToDateTime(sched.DateFinish);
                        dataGridView1.Rows.Add(sched.ID, sched.Employee.FIO, sched.Employee.Post, Convert.ToString(s.ToShortDateString()), Convert.ToString(s.ToShortTimeString()), Convert.ToString(end.ToShortTimeString()));
                    }
                }
            }

        }
    }
}
