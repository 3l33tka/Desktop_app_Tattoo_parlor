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
    public partial class Requests : MetroFramework.Forms.MetroForm
    {
        public Requests()
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
       
        private void Requests_Load(object sender, EventArgs e)
        {
            MainForms(currentpage, currentcountonpage);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestCard rc = new RequestCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Request p = db.Request.Find(id);
                rc.Currentid = id;
                rc.Text = "Информация о заказе №" + rc.Currentid;
                rc.ShowDialog();
                MainForms(currentpage, currentcountonpage);
            }
            
        }
        private void MainForms(int page, int countonpage)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (metroCheckBox1.Checked == true)
                {
                    List<Request> requestlist;
                    dataGridView1.Rows.Clear();
                    requestlist = db.Request.Where(x => x.Status == "-").ToList();
                    maxpage = requestlist.Count() / countonpage;
                    if (requestlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Request rq1 in requestlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        DateTime s = Convert.ToDateTime(rq1.DateStart);
                        DateTime e = Convert.ToDateTime(rq1.DateFinish);
                        DateTime st = Convert.ToDateTime(rq1.Session_Time);

                        dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, Convert.ToString(s.ToShortDateString()), Convert.ToString(e.ToShortDateString()), rq1.Status);
                    }
                }
                else
                {
                    List<Request> requestlist;
                    dataGridView1.Rows.Clear();
                    requestlist = db.Request.Where(x => x.Status == "+").ToList();
                    maxpage = requestlist.Count() / countonpage;
                    if (requestlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Request rq1 in requestlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        DateTime s = Convert.ToDateTime(rq1.DateStart);
                        DateTime e = Convert.ToDateTime(rq1.DateFinish);
                        DateTime st = Convert.ToDateTime(rq1.Session_Time);

                        dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, Convert.ToString(s.ToShortDateString()), Convert.ToString(e.ToShortDateString()), rq1.Status);
                    }
                }

            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                next.Enabled = false;
            }
            MainForms(currentpage, currentcountonpage);
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
            MainForms(currentpage, currentcountonpage);
            metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }
        private void FormRequest(object sender, EventArgs e)
        {
            currentpage = 1;
            MainForms(currentpage, currentcountonpage);
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
            FormRequest(numericUpDown1, e);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MainForms(currentpage, currentcountonpage);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RequestEdit re = new RequestEdit();
            re.Text = "Новый заказ";
            re.Show();
            MainForms(currentpage, currentcountonpage);
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    List<Request> requestlist;
                    dataGridView1.Rows.Clear();
                    requestlist = db.Request.Where(x => x.Status == "-").ToList();
                    foreach (Request rq1 in requestlist)
                    {
                        DateTime s = Convert.ToDateTime(rq1.DateStart);
                        DateTime end = Convert.ToDateTime(rq1.DateFinish);
                        DateTime st = Convert.ToDateTime(rq1.Session_Time);

                        dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, Convert.ToString(s.ToShortDateString()), Convert.ToString(end.ToShortDateString()), rq1.Status);
                    }
                }
            }
            else
            {
                MainForms(currentpage, currentcountonpage);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stat == 4)
            {
                chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                this.Close();
            }
           

        }
        private void SearchBut_Click(object sender, EventArgs e)
        {
            
            if (FIOSEARCH.Text != "")
            {
                string str = FIOSEARCH.Text;
                List<Request> requestlist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    requestlist = db.Request.Where(x => x.Client.FIO == str && x.Status == "+").ToList();
                    foreach (Request rq1 in requestlist)
                    {
                        DateTime s = Convert.ToDateTime(rq1.DateStart);
                        DateTime end = Convert.ToDateTime(rq1.DateFinish);
                        DateTime st = Convert.ToDateTime(rq1.Session_Time);

                        dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, Convert.ToString(s.ToShortDateString()), Convert.ToString(end.ToShortDateString()), rq1.Status);
                    }
                }
                if (requestlist.Count == 0)
                {
                    MessageBox.Show("Заказы не найдены!", "Тату салон");
                }
            }
            if (FIOMSEARCH.Text != "")
            {
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    try
                    {

                        dataGridView1.Rows.Clear();
                        List<Request> requestlist = new List<Request>();
                        Employee emp = db.Employee.Where(x => x.FIO == FIOMSEARCH.Text).FirstOrDefault<Employee>();
                        List<RequestEmployee> remp = db.RequestEmployee.Where(x => x.EmployeeID == emp.ID).ToList();
                        foreach (RequestEmployee q in remp)
                        {
                            requestlist.Add(db.Request.Find(q.RequestID));
                        }
                        foreach (Request rq1 in requestlist)
                        {
                            DateTime s = Convert.ToDateTime(rq1.DateStart);
                            DateTime end = Convert.ToDateTime(rq1.DateFinish);
                            DateTime st = Convert.ToDateTime(rq1.Session_Time);

                            dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, Convert.ToString(s.ToShortDateString()), Convert.ToString(end.ToShortDateString()), rq1.Status);
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Заказы не найдны","Тату салон");
                    }

                }
              
            }
            if (DateStart1.Text != "" || DateStart2.Text != "") //поиск по диапозону дат заказов
            {

                List<Request> requestlist;
                 using (DataBaseContainer db = new DataBaseContainer())
                 {
                    DateTime datest = Convert.ToDateTime(DateStart1.Text);
                    DateTime datefin = Convert.ToDateTime(DateStart2.Text);
                    dataGridView1.Rows.Clear();
                    var temp4 = db.Request.Where(x => x.DateStart >= datest && x.DateStart <= datefin);
                    requestlist = temp4.ToList();
                     foreach (Request rq1 in requestlist)
                     {
                         DateTime s = Convert.ToDateTime(rq1.DateStart);
                         DateTime end = Convert.ToDateTime(rq1.DateFinish);
                         DateTime st = Convert.ToDateTime(rq1.Session_Time);

                        dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, rq1.DateStart, Convert.ToString(end.ToShortDateString()), rq1.Status);
                     }
                 }
                
            }
            if (Service.Text != null)
            {
                try
                {
                    using (DataBaseContainer db = new DataBaseContainer())
                    {
                        dataGridView1.Rows.Clear();
                        List<Request> requestlist = new List<Request>();
                        Serviices ser = db.Service.Where(x => x.Name == Service.Text).FirstOrDefault<Serviices>();
                        List<RequestService> sr = db.RequestService.Where(x => x.ServiceID == ser.ID).ToList();
                        foreach (RequestService q in sr)
                        {
                            requestlist.Add(db.Request.Find(q.RequestID));
                        }
                        foreach (Request rq1 in requestlist)
                        {
                            DateTime s = Convert.ToDateTime(rq1.DateStart);
                            DateTime end = Convert.ToDateTime(rq1.DateFinish);
                            DateTime st = Convert.ToDateTime(rq1.Session_Time);

                            dataGridView1.Rows.Add(rq1.ID, db.Client.Find(rq1.ClientID).FIO, Convert.ToString(st.ToShortDateString()), Convert.ToString(st.ToShortTimeString()), rq1.Price, Convert.ToString(s.ToShortDateString()), Convert.ToString(end.ToShortDateString()), rq1.Status);
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Заказы не найдены", "Тату салон");
                }
            }
         
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FIOMSEARCH.Text = "";
            FIOSEARCH.Text = "";
            Service.Text = "";
            MainForms(currentpage, currentcountonpage);
        }

       

    }
    
}
