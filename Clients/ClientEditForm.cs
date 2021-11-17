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
    public partial class ClientEdit : MetroFramework.Forms.MetroForm
    {
        public ClientEdit()
        {
            InitializeComponent();
            FIOBox.Validating += FIOBox_Validating;
        }
        #region ---переменные---
        private int id;
         public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        private void ClientEdit_Load(object sender, EventArgs e)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Client.Find(id) != null)
                {
                    Client temp = db.Client.Where(x => x.ID == id).FirstOrDefault<Client>();
                    FIOBox.Text = temp.FIO;
                    AgeBox.Text = Convert.ToString(temp.Age);
                    PhoneBox.Text = temp.Phone;
                    EmailBox.Text = temp.Email;
         
                }
                else
                {
                    SaveBt.Enabled = false;
                    Client c = new Client();
                    c.ID = db.Client.Count() + 1;
                    Currentid = Convert.ToInt32(c.ID);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) // сoхранение клиента
        {
            Client temp = new Client();
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Client.Find(id) == null)
                {
                    Client c = new Client();
                    c.ID = id;
                    c.FIO = FIOBox.Text;
                    c.Phone = PhoneBox.Text;
                    c.Age = Convert.ToInt32(AgeBox.Text);
                    c.Email = EmailBox.Text;
                    Request req = new Request();
                    req.ID = db.Request.Count() + 1;
                    req.ClientID = c.ID;
                    req.DateStart = DateTime.Now;
                    req.DateFinish = DateTime.Now;
                    req.Session_Time = DateTime.Now;
                    req.Status = "+";
                    db.Client.Add(c);
                    db.Request.Add(req);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();

                }
                else
                {
                    var temp1 = db.Client.Where(x => x.ID == id).FirstOrDefault<Client>();
                    temp = temp1;
                    temp.FIO = FIOBox.Text;
                    temp.Phone = PhoneBox.Text;
                    temp.Age = Convert.ToInt32(AgeBox.Text);
                    temp.Email = EmailBox.Text; 
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();
                }
            }
        
        }

        private void FIOBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FIOBox.Text))
            {
                errorProvider1.SetError(FIOBox, "Не указано ФИО!");
                SaveBt.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBt.Enabled = true;
            }
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
