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
    public partial class Employees : MetroFramework.Forms.MetroForm
    {
        public Employees()
        {
            InitializeComponent();
            numericUpDown1.Value = currentcountonpage;

        }
        #region --- переменные ---
        public int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
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
        private int currentpage;
        private int maxpage;
        private int currentcountonpage = 10;
        #endregion
      
        private void FillEmployee(int page, int countonpage)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.Employee;
                List<Employee> employeelist = temp1.ToList();
                maxpage = employeelist.Count() / countonpage;
                if (employeelist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Employee emp in employeelist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    dataGridView1.Rows.Add(emp.ID, emp.FIO, emp.Age, emp.Post, emp.Phone, emp.Email);
                }

            }
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            FillEmployee(currentpage, currentcountonpage);
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeCard formcard = new EmployeeCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Employee p = db.Employee.Find(id);
                formcard.Currentid = id;
                formcard.ShowDialog();
                FillEmployee(currentpage, currentcountonpage);
                page.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { next.Enabled = false; }
                else
                { next.Enabled = true; }
            }
        }
        private void FormEmployee(object sender, EventArgs e)
        {
            currentpage = 1;
            FillEmployee(currentpage, currentcountonpage);
            back.Enabled = false;
            page.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { next.Enabled = false; }
            else
            { next.Enabled = true; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentcountonpage = Convert.ToInt32(numericUpDown1.Value);
            FormEmployee(numericUpDown1, e);
        }

        private void next_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                next.Enabled = false;
            }
            FillEmployee(currentpage, currentcountonpage);
            page.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void back_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                back.Enabled = false;
            }
            FillEmployee(currentpage, currentcountonpage);
            page.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            if (FIOSEARCH.Text != "")
            {
                string str = FIOSEARCH.Text;
                List<Employee> employeelist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    employeelist = db.Database.SqlQuery<Employee>("select * from Employee Where Employee.FIO like" + "'" + str + "%" + "'").ToList();
                    foreach (Employee emp in employeelist)
                    {
                        dataGridView1.Rows.Add(emp.ID, emp.FIO, emp.Age, emp.Post, emp.Phone, emp.Email);
                    }
                }

                if (employeelist.Count == 0)
                {
                    MessageBox.Show("Сотрдуник не найден", "Тату-салон ");

                }
            }
            if (PHONESEARCH.Text != "")
            {
                string str = PHONESEARCH.Text;
                List<Employee> employeelist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    employeelist = db.Database.SqlQuery<Employee>("select * from Employee Where Employee.Phone like" + "'" + str + "%" + "'").ToList();
                    foreach (Employee emp in employeelist)
                    {
                        dataGridView1.Rows.Add(emp.ID, emp.FIO, emp.Age, emp.Post, emp.Phone, emp.Email);
                    }
                }
                if (employeelist.Count == 0)
                {
                    MessageBox.Show("Сотрдуник не найден", "Тату-салон ");

                }
            }
            if (POSTLB.Text != "")
            {
                string str = POSTLB.Text;
                List<Employee> employeelist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    employeelist = db.Database.SqlQuery<Employee>("select * from Employee Where Employee.Post like" + "'" + str + "%" + "'").ToList();
                    foreach (Employee emp in employeelist)
                    {
                        dataGridView1.Rows.Add(emp.ID, emp.FIO, emp.Age, emp.Post, emp.Phone, emp.Email);
                    }
                }
                if (employeelist.Count == 0)
                {
                    MessageBox.Show("Сотрдуник не найден", "Тату-салон ");
                }
            }
            if (PHONESEARCH.Text != "" && FIOSEARCH.Text != "" && POSTLB.Text != "")
            {
                List<Employee> employeelist;
                string str = PHONESEARCH.Text;
                string str2 = FIOSEARCH.Text;
                string str3 = POSTLB.Text;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    employeelist = db.Database.SqlQuery<Employee>("select * from Employee Where Employee.Post like" + "'" + str3 + "%" + "'" + "and FIO like" + "'" + str2 + "%" + "'" + "and Phone like" + "'" + str + "%" + "'").ToList();
                    foreach (Employee emp in employeelist)
                    {
                        dataGridView1.Rows.Add(emp.ID, emp.FIO, emp.Age, emp.Post, emp.Phone, emp.Email);
                    }
                }
                if (employeelist.Count == 0)
                {
                    MessageBox.Show("Сотрдуник не найден", "Тату-салон ");
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e) //обновить форму
        {
            FillEmployee(currentpage, currentcountonpage);
        }

        private void metroButton1_Click(object sender, EventArgs e) //добавление сотрудника
        {
            EmployeeEdit addemp = new EmployeeEdit();
            addemp.Text = "Новый сотрудник";
            addemp.ShowDialog();
            FillEmployee(currentpage, currentcountonpage);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            POSTLB.Text = "";
            PHONESEARCH.Text = "";
            FIOSEARCH.Text = "";
            FillEmployee(currentpage, currentcountonpage);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (stat == 4)
            {
                chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                this.Close();
               
            }

            if (stat == 2)
            {
                using (DataBaseContainer db = new DataBaseContainer())
                {
                   RequestEmployee empreq = new RequestEmployee();
                    chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    empreq.EmployeeID = chid;
                    empreq.RequestID = backid;
                    try 
                    { 
                        db.RequestEmployee.Add(empreq);
                        db.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        this.Close();
                    }
                }
            } 
            if(stat ==3)
            {
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    EmployeeService emplser = new EmployeeService();
                    chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    emplser.EmployeeID = chid;
                    emplser.ServiceID = backid;
                    try
                    {
                        db.EmployeeService.Add(emplser);
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
}
