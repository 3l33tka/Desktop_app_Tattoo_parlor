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
    public partial class RequestEdit : MetroFramework.Forms.MetroForm
    {
        public RequestEdit()
        {
            InitializeComponent();
        }
        #region ---переменные---
        public int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        #endregion
        private void PayRequestLoad()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Request req = new Request();
                double s = 0;
                if (db.Request.Find(id) != null)
                {
                    var temp1 = db.RequestService.Where(x => x.ServiceID == id);
                    List<RequestService> sum = temp1.ToList();
                    foreach (RequestService q in sum)
                    {
                        s = s + Convert.ToDouble(q.Service.Price);
                    }
                    PayTextBox.Text = Convert.ToString(s);
                }
               
            }
            
        }
        private void RequestLoad()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {

                if (db.Request.Find(id) != null)
                {
                    Request temp = db.Request.Where(x => x.ID == id).FirstOrDefault<Request>();
                    FIOLB.Text = temp.Client.FIO;
                    TimeSes.Value = Convert.ToDateTime(temp.Session_Time);
                    DateSes.Value = Convert.ToDateTime(temp.Session_Time);
                    DateStart.Value = Convert.ToDateTime(temp.DateStart);
                    DateFinish.Value = Convert.ToDateTime(temp.DateFinish);
                    PayTextBox.Text = Convert.ToString(temp.Price);
                    if (temp.Status == "+")
                    {
                        metroCheckBox1.Checked = true;
                        metroCheckBox2.Checked = false;
                    }
                    else
                    {
                        metroCheckBox2.Checked = true;
                        metroCheckBox1.Checked = false;
                    }
                    FillListBoxEmployee();
                    FillListBoxService();

                }
                else
                {
                    Request r = new Request();
                    r.ID = db.Request.Count() + 1;
                    Currentid = Convert.ToInt32(r.ID);
                }
            }
        }
        private void RequestEdit_Load(object sender, EventArgs e)
        {
            RequestLoad();
        }
        public void FillListBoxEmployee()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                 EmployeeBox.Items.Clear();
                 var temp1 = db.RequestEmployee.Where(x => x.RequestID == id);
                 List<RequestEmployee> requestlist1 = temp1.ToList();
                 foreach (RequestEmployee re in requestlist1)
                 {
                        EmployeeBox.Items.Add(re.Employee.FIO);
                 }
               
            }
        }
        public void FillListBoxService()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                ServiceBox.Items.Clear();
                var temp1 = db.RequestService.Where(x => x.RequestID == id);
                List<RequestService> requestlist = temp1.ToList();
                foreach (RequestService rq in requestlist)
                {
                    ServiceBox.Items.Add(rq.Service.Name);

                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e) //Добавляем клиента
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Clients AddClient= new Clients();
                AddClient.Text = "Добавить клиента";
                AddClient.feedbackid = id;
                AddClient.stat = 4;
                AddClient.ShowDialog();
                FIOLB.Text = db.Client.Find(AddClient.choosenid).FIO;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e) //Добавляем услугу в листбок
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                ServiceForm Service = new ServiceForm();
                Service.Text = "Добавить услугу";
                Service.feedbackid = id;
                Service.stat = 2;
                Service.ShowDialog();
                ServiceBox.Items.Add(db.Service.Find(Service.choosenid).Name);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e) //Добавляем мастера в листбок
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Employees Employee = new Employees();
                Employee.Text = "Добавить мастера";
                Employee.feedbackid = id;
                Employee.stat = 2;
                Employee.ShowDialog();
                EmployeeBox.Items.Add(db.Employee.Find(Employee.choosenid).FIO);
            }
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            Request temp = new Request();
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Request.Find(id) == null)
                {
                    Request c = new Request();
                    c.ID = id;  
                    if (FIOLB.Text != "Клиент")
                    { c.ClientID = db.Client.Where(x => x.FIO == FIOLB.Text).FirstOrDefault<Client>().ID; }
                    TimeSpan TimeSession = TimeSes.Value.TimeOfDay;
                    c.Session_Time = Convert.ToDateTime(DateSes.Value).Date.Add(TimeSession);
                    c.DateStart = Convert.ToDateTime(DateStart.Value);
                    c.DateFinish = Convert.ToDateTime(DateFinish.Value);
                    c.Price = Convert.ToDouble(PayTextBox.Text);
                    if (metroCheckBox1.Checked == true)
                    {
                        c.Status = "+";
                    }
                    if (metroCheckBox2.Checked == true)
                    {
                        c.Status = "-";
                    }
                    if ((metroCheckBox1.Checked == true && metroCheckBox2.Checked == true) || (metroCheckBox1.Checked == false && metroCheckBox2.Checked == false))
                    {
                        SaveBt.Enabled = false;
                        MessageBox.Show("Ошибка в заполнении, измените статус заказа", "Тату салон");
                    } 
                    db.Request.Add(c);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату салон");
                    this.Close();
                }
                else
                {
                    var temp1 = db.Request.Where(x => x.ID == id).FirstOrDefault<Request>();
                    temp = temp1;
                    temp.ClientID = db.Client.Where(x => x.FIO == FIOLB.Text).FirstOrDefault<Client>().ID;
                    temp.DateStart = Convert.ToDateTime(DateStart.Value).Date;
                    TimeSpan st = TimeSes.Value.TimeOfDay;
                    temp.Session_Time = Convert.ToDateTime(DateSes.Value).Date.Add(st);
                    temp.DateFinish = Convert.ToDateTime(DateFinish.Value).Date;
                    temp.Price = Convert.ToDouble(PayTextBox.Text);
                    if (metroCheckBox1.Checked == true)
                    {
                        temp.Status = "+";
                    }
                    if (metroCheckBox2.Checked == true)
                    {
                        temp.Status = "-";
                    }
                    if ((metroCheckBox1.Checked == true && metroCheckBox2.Checked == true) || (metroCheckBox1.Checked == false && metroCheckBox2.Checked == false) )
                    {
                        SaveBt.Enabled = false;
                        MessageBox.Show("Ошибка в заполнении, измените статус заказа", "Тату салон");
                    }
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату салон");
                    this.Close();
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e) //удаление услуги из связующией таблицы
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Serviices s = db.Service.Where(x => x.Name == ServiceBox.SelectedItem.ToString()).FirstOrDefault<Serviices>();
                RequestService cp = db.RequestService.Where(x => x.ServiceID == s.ID && x.RequestID == id).FirstOrDefault<RequestService>();
                db.RequestService.Remove(cp);
                db.SaveChanges();
                FillListBoxService();
            }
        }

        private void delbtempl_Click(object sender, EventArgs e) //удаление мастера из связующией таблицы
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Employee emp = db.Employee.Where(x => x.FIO == EmployeeBox.SelectedItem.ToString()).FirstOrDefault<Employee>();
                RequestEmployee cp = db.RequestEmployee.Where(x => x.EmployeeID == emp.ID && x.RequestID == id).FirstOrDefault<RequestEmployee>();
                db.RequestEmployee.Remove(cp);
                db.SaveChanges();
                FillListBoxEmployee();
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e) //удаление из литбокса
        {
            ServiceBox.Items.Remove(ServiceBox.SelectedItem);
        }

        private void metroLabel11_Click(object sender, EventArgs e) //удаление из литбокса
        {
            EmployeeBox.Items.Remove(EmployeeBox.SelectedItem);
        }
    }
}
