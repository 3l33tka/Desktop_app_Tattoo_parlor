using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class ClientCard : MetroFramework.Forms.MetroForm
    {
        public ClientCard()
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
        private void ClientCard_Load(object sender, EventArgs e)
        {
            Reload(this.id);
        }
        public void FillGrid()
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.Request.Where(x => x.ClientID == id);
                List<Request> requestlist = temp1.ToList();
                foreach (Request rq1 in requestlist)
                {
                    dataGridView1.Rows.Add(rq1.ID, rq1.Client.FIO, rq1.Session_Time, rq1.Session_Time, rq1.Price, rq1.Status);
                }
            }
        }
        private void DelBut_Click(object sender, EventArgs e)
        {
            const string message = "Хотите удалить из базы данных ";
            const string caption = "Тату-салон. Удаление клиента";
            var result = MessageBox.Show(message + FIOLB.Text + "? Если вы удалите данного клиента, то удалятся и его заказы", caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    Client c = db.Client.Where(x => x.ID == id).FirstOrDefault<Client>();
                    Request req = db.Request.Where(x => x.ClientID == id).FirstOrDefault<Request>();
                    RequestService reqser = db.RequestService.Where(x => x.RequestID == req.ID).FirstOrDefault<RequestService>();
                    RequestEmployee reqempl = db.RequestEmployee.Where(x => x.RequestID == req.ID).FirstOrDefault<RequestEmployee>();
                    if (reqempl == null && reqser == null)
                    {
                        db.Client.Remove(c);
                        db.Request.Remove(req);
                        MessageBox.Show("Клиент успешно удален!", "Тату салон");
                        db.SaveChanges();
                        this.Close();
                    }
                    if (reqempl != null && reqser != null)
                    {
                        db.Client.Remove(c);
                        db.Request.Remove(req);
                        db.RequestService.Remove(reqser);
                        db.RequestEmployee.Remove(reqempl);
                        MessageBox.Show("Клиент успешно удален!", "Тату салон");
                        db.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
        private void Reload(int id)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Client temp = db.Client.Where(x => x.ID == id).FirstOrDefault<Client>();
                FIOLB.Text = temp.FIO;
                PHONELB.Text = temp.Phone;
                AGELB.Text = Convert.ToString(temp.Age);
                EMAILLB.Text = temp.Email;
                FillGrid();
      
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            ClientEdit c = new ClientEdit();
            c.Currentid = id;
            c.ShowDialog();
            Reload(id);
        }

        private void metroButton1_Click(object sender, EventArgs e) //закрытие формы
        {
            this.Close();
        }
      
    }
}
