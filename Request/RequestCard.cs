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
    public partial class RequestCard : MetroFramework.Forms.MetroForm
    {
        public RequestCard()
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
        private void FillListServ()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                listBox1.Items.Clear();
                var temp1 = db.RequestService.Where(x => x.RequestID == id);
                List<RequestService> requestlist = temp1.ToList();
                foreach (RequestService wp in requestlist)
                {
                    listBox1.Items.Add(wp.Service.Name);
                }
            }
        }
        public void FillListEmployee()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                listBox2.Items.Clear();
                var temp1 = db.RequestEmployee.Where(x => x.RequestID == id);
                List<RequestEmployee> requestlist = temp1.ToList();
                foreach (RequestEmployee wp in requestlist)
                {
                    listBox2.Items.Add(wp.Employee.FIO);
                }
            }
        }
        private void loadCard(int id)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {

                Request temp = db.Request.Where(x => x.ID == id).FirstOrDefault<Request>();
                DateTime s = Convert.ToDateTime(temp.DateStart);
                DateTime e = Convert.ToDateTime(temp.DateFinish);
                DateTime c = Convert.ToDateTime(temp.Session_Time);
                metroLink1.Text = temp.Client.FIO;
                TimeSes.Text = c.ToShortTimeString();
                DateSes.Text = c.ToShortDateString();
                DateLb.Text = s.ToShortDateString();
                DateEnLb.Text = e.ToShortDateString();
                PriceLb.Text = Convert.ToString(temp.Price);
                if (temp.Status == "+")
                {
                    Status.Text = "Заказ действителен";
                }
                else
                {
                    Status.Text = "Заказ не действителен";
                }
                
            }
            FillListServ();
            FillListEmployee();
        }
        private void RequestCard_Load(object sender, EventArgs e)
        {
            loadCard(this.id);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RequestEdit ee = new RequestEdit();
            ee.Currentid = id;
            ee.Text = "Редоктирование заказа № " + Currentid;
            ee.ShowDialog();
            loadCard(id);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Client cl = db.Client.Where(x => x.FIO == metroLink1.Text).FirstOrDefault<Client>();
                ClientCard ec = new ClientCard();
                ec.Currentid = cl.ID;
                ec.ShowDialog();
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
