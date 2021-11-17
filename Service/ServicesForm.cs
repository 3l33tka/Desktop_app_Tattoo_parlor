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
    public partial class ServiceForm : MetroFramework.Forms.MetroForm
    {
        public ServiceForm()
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

        private int backid;
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
        
        private void Services_Load(object sender, EventArgs e)
        {
            FillService(currentpage, currentcountonpage);
        }
        private void SearchFIO()
        {
            if (FIOSEARCH.Text != "")
            {
                try
                {
                    using (DataBaseContainer db = new DataBaseContainer())
                    {
                        dataGridView1.Rows.Clear();
                        List<Serviices> servicelist = new List<Serviices>();
                        Employee emp = db.Employee.Where(x => x.FIO == FIOSEARCH.Text).FirstOrDefault<Employee>();
                        List<EmployeeService> empl = db.EmployeeService.Where(x => x.EmployeeID == emp.ID).ToList();
                        foreach (EmployeeService q in empl)
                        {
                            servicelist.Add(db.Service.Find(q.ServiceID));
                        }
                        foreach (Serviices serv in servicelist)
                        {
                            dataGridView1.Rows.Add(serv.ID, serv.Name, serv.Price, serv.TypeService.Name);
                        }
                        if (servicelist.Count == 0)
                        {
                            MessageBox.Show("Услуги не найдены", "Тату салон");
                        }
                    }
                }
                catch
                {

                }
            }
        }
        private void SearchPrice()
        {
            if (PriceBX1.Text != "" && PRICEBX2.Text != "")
            {
                List<Serviices> servicelist = new List<Serviices>();
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    Double min = Convert.ToDouble(PriceBX1.Text);
                    Double max = Convert.ToDouble(PRICEBX2.Text);
                    var temp1 = db.Service.Where(x => x.Price >= min && x.Price <= max);
                    servicelist = temp1.ToList();
                    foreach (Serviices serv in servicelist)
                    {
                        dataGridView1.Rows.Add(serv.ID, serv.Name, serv.Price, serv.TypeService.Name);
                    }

                    if (servicelist.Count == 0)
                    {
                        MessageBox.Show("Услуги не найдены", "Тату салон");
                    }
                }
            }
        }
        private void SearchService()
        {
            if (NAMESERVBX.Text != "")
            {
                List<Serviices> servicelist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Service.Where(x => x.TypeService.Name == NAMESERVBX.Text);
                    servicelist = temp1.ToList();
                    foreach (Serviices serv in servicelist)
                    {
                        dataGridView1.Rows.Add(serv.ID, serv.Name, serv.Price, db.TypeService.Find(serv.TypeServiceID).Name);
                    }
                }

                if (servicelist.Count == 0)
                {
                    MessageBox.Show("Услуги не найдены", "Тату салон");
                }
            }
        }
        private void SearchBut_Click(object sender, EventArgs e)
        {
            SearchFIO();
            SearchPrice();
            SearchService();

                if (PriceBX1.Text != "" && PRICEBX2.Text != "" && FIOSEARCH.Text != "")
                {
                     SearchFIO();
                     SearchPrice();
                }
            if (PriceBX1.Text != "" && PRICEBX2.Text != "" && FIOSEARCH.Text != "" && NAMESERVBX.Text != "")
            {
                SearchFIO();
                SearchPrice();
                SearchService();
            }

        }

        private void metroButton2_Click(object sender, EventArgs e) //обновить
        {
            FillService(currentpage, currentcountonpage);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PriceBX1.Text = "";
            PRICEBX2.Text = "";
            FIOSEARCH.Text = "";
            NAMESERVBX.Text = "";
            FillService(currentpage, currentcountonpage);
        }
        private void FillService(int page, int countonpage)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                dataGridView1.Rows.Clear();
                var groupbyname = from s in db.Service
                                  group s by s.TypeService.Name;
                foreach (var ser in groupbyname)
                {
                    dataGridView1.Rows.Add(ser.Key);
                    maxpage = ser.Count() / countonpage;
                    if (ser.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Serviices serv in ser.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        dataGridView1.Rows.Add(serv.ID, serv.Name, serv.Price);
                    }
                }
            }
        }

        private void FormService(object sender, EventArgs e)
        {
            currentpage = 1;
            FillService(currentpage, currentcountonpage);
            back.Enabled = false;
            metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { next.Enabled = false; }
            else
            { next.Enabled = true; }
        }
       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentcountonpage = Convert.ToInt32(numericUpDown1.Value);
            FormService(numericUpDown1, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceCard formcard = new ServiceCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Serviices s = db.Service.Find(id);
                formcard.Currentid = id;
                formcard.ShowDialog();
                FillService(currentpage, currentcountonpage);
            }
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    RequestService reqser = new RequestService();
                    chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    reqser.RequestID = backid;
                    reqser.ServiceID = chid;
                    try
                    {
                        db.RequestService.Add(reqser);
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ServiceEdit se = new ServiceEdit();
            se.Text = "Новая услуга";
            se.ShowDialog();
            FillService(currentpage, currentcountonpage);
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            back.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                next.Enabled = false;
            }
            FillService(currentpage, currentcountonpage);
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
            FillService(currentpage, currentcountonpage);
            metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Service.TypeServices ts = new Service.TypeServices();
            ts.Show();
            FillService(currentpage, currentcountonpage);
        }
    }
}

