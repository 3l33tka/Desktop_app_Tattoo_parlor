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
    public partial class ScheduleEdit : MetroFramework.Forms.MetroForm
    {
        public ScheduleEdit()
        {
            InitializeComponent();
        }
        #region ---переменные---
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
        private void ScheduleEdit_Load(object sender, EventArgs e)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Schedule.Find(id) != null)
                {
                    Schedule temp = db.Schedule.Where(x => x.ID == id).FirstOrDefault<Schedule>();
                    Fiotx.Text = temp.Employee.FIO;
                    datetx.Text = Convert.ToString(temp.DateStart);
                    dateftx.Text = Convert.ToString(temp.DateFinish);
                    posttx.Text = temp.Employee.Post;
                    
                }
                if (db.Schedule.Find(id) == null)
                {
                    Schedule sched= new Schedule();
                    sched.ID = db.Schedule.Count() + 1;
                    Currentid = Convert.ToInt32(sched.ID);
                }
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            Schedule temp = new Schedule ();
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Schedule.Find(id) == null)
                {
                    Schedule tenp  = new Schedule();
                    temp.ID = id;
                    temp.EmployeeID = db.Employee.Where(x => x.FIO == Fiotx.Text).FirstOrDefault<Employee>().ID;
                    temp.DateFinish = Convert.ToDateTime(dateftx.Text);
                    temp.DateStart = Convert.ToDateTime(datetx.Text);
                    db.Schedule.Add(temp);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.Schedule.Where(x => x.ID == id).FirstOrDefault<Schedule>();
                    temp = temp1;
                    temp.EmployeeID = db.Employee.Where(x => x.FIO == Fiotx.Text).FirstOrDefault<Employee>().ID;
                    temp.DateFinish = Convert.ToDateTime(dateftx.Text);
                    temp.DateStart = Convert.ToDateTime(datetx.Text);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();
                }
            }
        }
       
        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e) //Добавить сотрудника
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Employees AddEmployee = new Employees();
                AddEmployee.Text = "Выбрать сотрудника";
                AddEmployee.feedbackid = id;
                AddEmployee.stat = 4;
                AddEmployee.ShowDialog();
                Fiotx.Text = db.Employee.Find(AddEmployee.choosenid).FIO;
                posttx.Text = db.Employee.Find(AddEmployee.choosenid).Post;
            }
        }
    }
}
