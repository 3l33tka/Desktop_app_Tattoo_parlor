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
    public partial class ScheduleCard : MetroFramework.Forms.MetroForm
    {
        public ScheduleCard()
        {
            InitializeComponent();
        }
        #region
        public int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
        private void Reload(int id)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Schedule temp = db.Schedule.Where(x => x.ID == id).FirstOrDefault<Schedule>();
                metroLink1.Text = temp.Employee.FIO;
                TimeStart.Text = Convert.ToString(temp.DateStart);
                FinishTime.Text = Convert.ToString(temp.DateFinish);
                Post.Text = temp.Employee.Post;
            }
        }

        private void ScheduleCard_Load(object sender, EventArgs e)
        {
            Reload(this.id);
        }

        private void metroButton1_Click(object sender, EventArgs e) //кнопка "Редактирование"
        {
            ScheduleEdit s = new ScheduleEdit();
            s.Currentid = id;
            s.ShowDialog();
            Reload(id);
        }

        private void metroLink1_Click(object sender, EventArgs e) //ссылка на карточку сотрудника
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Employee cl = db.Employee.Where(x => x.FIO == metroLink1.Text).FirstOrDefault<Employee>();
                EmployeeCard ec = new EmployeeCard();
                ec.Currentid = cl.ID;
                ec.ShowDialog();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e) //кнопка закрыть
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e) //кнопка удаления карточки формы "Расписания"
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Schedule sche = db.Schedule.Where(x => x.ID == id).FirstOrDefault<Schedule>();
                db.Schedule.Remove(sche);
                MessageBox.Show("Запись расписания успешно удалена!", "Тату-салон");
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
