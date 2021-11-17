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
    public partial class ServiceEdit : MetroFramework.Forms.MetroForm
    {
        public ServiceEdit()
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
        private int feedbackforpat;
        public int PatientID
        {
            get { return feedbackforpat; }
            set { feedbackforpat = value; }
        }
        #endregion

        private void ServiceEdit_Load(object sender, EventArgs e)
        {
            ServiceCard sc = new ServiceCard();
            using (DataBaseContainer db = new DataBaseContainer())
            {

                if (db.Service.Find(id) != null)
                {
                    Serviices temp = db.Service.Where(x => x.ID == id).FirstOrDefault<Serviices>();
                    NameTx.Text = temp.Name;
                    typeservice.Text = temp.TypeService.Name;
                    PriceTx.Text = Convert.ToString(temp.Price);
                    FillListBox();
                }
                else
                {

                    Request c = new Request();
                    c.ID = db.Request.Count() + 1;
                    Currentid = Convert.ToInt32(c.ID);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) // Выбираем мастера
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Employees AddEmployee = new Employees();
                AddEmployee.Text = "Добавить мастера";
                AddEmployee.feedbackid = id;
                AddEmployee.stat = 3;
                AddEmployee.ShowDialog();
                listBox1.Items.Add(db.Employee.Find(AddEmployee.choosenid).FIO);
            }
        }
        public void FillListBox() // Заполнение сотрудников в листбокс 
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                listBox1.Items.Clear();
                var temp1 = db.EmployeeService.Where(x => x.ServiceID ==id);
                List<EmployeeService> employelist = temp1.ToList();
                foreach (EmployeeService emp in employelist)
                {
                    listBox1.Items.Add(emp.Employee.FIO);
                }
            }
        }
        private void metroButton4_Click(object sender, EventArgs e) //Удаление сотрудника из листбокса
        {
            using (DataBaseContainer db = new DataBaseContainer())
             {
                Employee emp = db.Employee.Where(x => x.FIO == listBox1.SelectedItem.ToString()).FirstOrDefault<Employee>();
                EmployeeService cp = db.EmployeeService.Where(x => x.ServiceID == id && x.EmployeeID == emp.ID).FirstOrDefault<EmployeeService>(); 
                db.EmployeeService.Remove(cp);
                db.SaveChanges();
                FillListBox();
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e) // save Service
        {
            Serviices s1 = new Serviices();
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Service.Find(id) == null)
                {
                    Serviices s = new Serviices();
                    s.ID = id;
                    s.Name = NameTx.Text;
                    s.Price = Convert.ToDouble(PriceTx.Text);
                    s.TypeServiceID = db.TypeService.Where(x => x.Name == typeservice.Text).FirstOrDefault<TypeService>().ID;
                    db.Service.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату салон!");
                    this.Close();
                }
                else
                {
                    var temp = db.Service.Where(x => x.ID == id).FirstOrDefault<Serviices>();
                    s1 = temp;
                    s1.ID = id;
                    s1.Name = NameTx.Text;
                    s1.Price = Convert.ToDouble(PriceTx.Text);
                    s1.TypeServiceID = db.TypeService.Where(x => x.Name == typeservice.Text).FirstOrDefault<TypeService>().ID;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату салон!");
                    this.Close();
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton5_Click(object sender, EventArgs e) //Выбраем тип услуги
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Service.TypeServices AddType = new Service.TypeServices();
                AddType.Text = "Добавить тип";
                AddType.feedbackid = id;
                AddType.stat = 4;
                AddType.ShowDialog();
                typeservice.Text = db.TypeService.Find(AddType.choosenid).Name;
            }
             
        }

        private void metroLabel5_Click(object sender, EventArgs e) //удалить сотрудника из листбока
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
