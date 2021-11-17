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
    public partial class EmployeeCard : MetroFramework.Forms.MetroForm
    {
        public EmployeeCard()
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
                Employee temp = db.Employee.Where(x => x.ID == id).FirstOrDefault<Employee>();
                FIOLB.Text = temp.FIO;
                PHONELB.Text = temp.Phone;
                AGELB.Text = Convert.ToString(temp.Age);
                EMAILLB.Text = temp.Email;
                POSTBOX.Text = temp.Post;       
                if (POSTBOX.Text == "Администратор")
                {
                    dataGridView1.Visible = false;
                    Size = new Size(382, 523);
                    metroLabel5.Location = new Point(23, 250);
                    EMAILLB.Location = new Point(175, 250);
                    metroLabel4.Location = new Point(23, 299);
                    PHONELB.Location = new Point(175, 299);
                    metroLabel1.Location = new Point(23, 108);
                    FIOLB.Location = new Point(175, 108);
                    metroLabel2.Location = new Point(23, 155);
                    AGELB.Location = new Point(175, 155);
                    metroLabel6.Location = new Point(23, 206);
                    POSTBOX.Location = new Point(175, 206);
                    EditBut.Location = new Point(30,376);
                    metroButton1.Location = new Point(34,432);
                    DelBut.Location = new Point(175,432);
                    dataGridView2.Visible = false;
                }
            }
        }

        private void DelBut_Click_1(object sender, EventArgs e)
        { 
            const string message = "Хотите удалить из базы данных ";
            const string caption = "Тату-салон. Удаление сотрудника";
            var result = MessageBox.Show(message + FIOLB.Text + "? Если вы удалите данного сотрудника, то удалятся и его заказы", caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

              if (result == DialogResult.OK)
              {
                  using (DataBaseContainer db = new DataBaseContainer())
                  {
                    
                        Employee emp = db.Employee.Where(x => x.ID == id).FirstOrDefault<Employee>();
                        RequestEmployee reqempl = db.RequestEmployee.Where(x => x.EmployeeID == emp.ID).FirstOrDefault<RequestEmployee>();
                        EmployeeService emplser = db.EmployeeService.Where(x => x.EmployeeID == emp.ID).FirstOrDefault<EmployeeService>();
                        Schedule schedul = db.Schedule.Where(x => x.EmployeeID == emp.ID).FirstOrDefault<Schedule>();
                        
                    if (reqempl != null && emplser != null && schedul != null)
                    {
                        try
                        {
                            db.Employee.Remove(emp);
                            db.RequestEmployee.Remove(reqempl);
                            db.EmployeeService.Remove(emplser);
                            db.Schedule.Remove(schedul);
                            MessageBox.Show("Сотрудник успешно удален!", "Тату салон");
                            db.SaveChanges();
                            this.Close();
                        }
                        catch
                        {
                            this.Close();
                        }
                    }
                    if(reqempl != null && emplser != null && schedul == null)
                    {
                        try
                        {
                            db.Employee.Remove(emp);
                            db.RequestEmployee.Remove(reqempl);
                            db.EmployeeService.Remove(emplser);
                            MessageBox.Show("Сотрудник успешно удален!", "Тату салон");
                            db.SaveChanges();
                            this.Close();
                        }
                        catch
                        {
                            this.Close();
                        }
                    }
                   

                }
                                      
              }
            
        }

        private void EmployeeCard_Load(object sender, EventArgs e)
        {
            Reload(this.id);
            FillGrid();
            FillGrid1();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            EmployeeEdit ee = new EmployeeEdit();
            ee.Currentid = id;
            ee.ShowDialog();
            Reload(id);

        }
        public void FillGrid()
        {
               using (DataBaseContainer db = new DataBaseContainer())
                {
                    List<Request> requestlist = new List<Request>();
                    Employee e = db.Employee.Where(x => x.ID == id).FirstOrDefault<Employee>();
                    List<RequestEmployee> re = db.RequestEmployee.Where(x => x.EmployeeID == e.ID).ToList();
                    foreach (RequestEmployee q in re)
                    {
                        requestlist.Add(db.Request.Find(q.RequestID));
                    }
                    foreach (Request rq1 in requestlist)
                    {
                        dataGridView1.Rows.Add(rq1.ID, rq1.Client.FIO, rq1.Session_Time, rq1.Session_Time, rq1.Price, rq1.DateStart, rq1.Status);
                    }
                }
            
        }
        public void FillGrid1()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                dataGridView2.Rows.Clear();
                var temp = db.Schedule.Where(x => x.EmployeeID == id);
                List<Schedule> requestlist = temp.ToList();
                foreach (Schedule sch1 in requestlist)
                {
                    dataGridView2.Rows.Add(sch1.Employee.FIO, sch1.DateStart, sch1.DateStart, sch1.DateFinish);
                }
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                try
                {
                    Schedule rq = db.Schedule.Where(x => x.EmployeeID == id).FirstOrDefault<Schedule>();
                    ScheduleCard rqcard = new ScheduleCard();
                    rqcard.Currentid = rq.ID;
                    rqcard.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("У данного сотрудника нету времени работы ", "Татту-салон");
                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientCard formcard = new ClientCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Client p = db.Client.Find(id);
                formcard.Text = "Информация о клиенте № " + id;
                formcard.Currentid = id;
                formcard.ShowDialog();

            }

        }

    }

        
        
    
}
