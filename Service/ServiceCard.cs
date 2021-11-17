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
    public partial class ServiceCard : MetroFramework.Forms.MetroForm
    {
        public ServiceCard()
        {
            InitializeComponent();
        }
        #region
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
        private void FillGrid()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                List<Request> requestlist = new List<Request>();
                Serviices s = db.Service.Where(x => x.ID == id).FirstOrDefault<Serviices>();
                List<RequestService> sr = db.RequestService.Where(x => x.ServiceID == s.ID).ToList();
                foreach (RequestService q in sr)
                {
                    requestlist.Add(db.Request.Find(q.RequestID));
                }
                foreach (Request rq1 in requestlist)
                {
                    DateTime st = Convert.ToDateTime(rq1.Session_Time);

                    dataGridView1.Rows.Add(rq1.ID, rq1.Client.FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Status);
                }
            }
        }
         public void EmployeeList()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                listBox1.Items.Clear();
                var temp1 = db.EmployeeService.Where(x => x.ServiceID == id);
                List<EmployeeService> servicelist = temp1.ToList();
                foreach (EmployeeService empser in servicelist)
                {
                    listBox1.Items.Add(empser.Employee.FIO);
                }
            }
        }
        private void FormLoad(int id)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Serviices temp = db.Service.Where(x => x.ID == id).FirstOrDefault<Serviices>();
                Namelb.Text = temp.Name;
                Typelb.Text = temp.TypeService.Name;
                PriceLB.Text = Convert.ToString(temp.Price);
                Description.Text = temp.TypeService.Description;
                EmployeeList();
                Description.Enabled = false;
            }
        }

        private void ServiceCard_Load(object sender, EventArgs e)
        {
            FormLoad(this.id);
            FillGrid();
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            const string message = "Хотите удалить из базы данных ";
            const string caption = "Тату-салон. Удаление услуги";
            var result = MessageBox.Show(message + Namelb.Text + "?", caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    Serviices ser = db.Service.Where(x => x.ID == id).FirstOrDefault<Serviices>();
                    RequestService reqser = db.RequestService.Where(x => x.ServiceID == ser.ID).FirstOrDefault<RequestService>();
                    EmployeeService empser = db.EmployeeService.Where(x => x.ServiceID == reqser.ServiceID).FirstOrDefault<EmployeeService>();
   
                    if(reqser != null || empser != null)
                    {
                        db.Service.Remove(ser);
                        db.RequestService.Remove(reqser);
                        db.EmployeeService.Remove(empser);
                        MessageBox.Show("Услуга успешно удалeна!", "Тату салон");
                        db.SaveChanges();
                        this.Close();
                    }
                    else 
                    {
                        db.Service.Remove(ser); 
                        MessageBox.Show("Услуга успешно удалeна!", "Тату салон");
                        db.SaveChanges();
                        this.Close();
                    }
                 
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            ServiceEdit ee = new ServiceEdit();
            ee.Currentid = id;
            ee.Text = "Редактирование услуги № " + Currentid;
            ee.ShowDialog();
            FormLoad(id);
        }

    }

}
