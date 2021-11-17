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
    public partial class Clients : MetroFramework.Forms.MetroForm
    {
        public Clients()
        {
            InitializeComponent();
            numericUpDown1.Value = currentcountonpage;
        }
        #region --- Переменные---
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

        private void Clients_Load(object sender, EventArgs e)
        {
            FillClient(currentpage, currentcountonpage);
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            if (FIOSEARCH.Text != "")
            {
                string str = FIOSEARCH.Text;
                List<Client> clientlist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    clientlist = db.Database.SqlQuery<Client>("select * from Client Where Client.FIO like" + "'" + str + "%" + "'").ToList();
                    //clientlist = db.Client.Where(x => x.FIO == str).ToList();
                    foreach (Client c in clientlist)
                    {
                        dataGridView1.Rows.Add(c.ID, c.FIO, c.Age, c.Phone, c.Email);
                    }

                    if (clientlist.Count == 0)
                    {
                        MessageBox.Show("Клиент не найден", "Тату-салон ");

                    }
                }
            }
            if (PHONESEARCH.Text != "")
            {
                string str = PHONESEARCH.Text;
                List<Client> clientlist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    dataGridView1.Rows.Clear();
                    clientlist = db.Database.SqlQuery<Client>("select * from Client Where Client.Phone like" + "'" + str + "%" + "'").ToList();
                    //clientlist = db.Client.Where(x => x.Phone == str).ToList();
                    foreach (Client c in clientlist)
                    {
                        dataGridView1.Rows.Add(c.ID, c.FIO, c.Age, c.Phone, c.Email);
                    }

                    if (clientlist.Count == 0)
                    {
                        MessageBox.Show(" Клиент не найден", "Тату-салон ");

                    }
                }
            }

            if (PHONESEARCH.Text != "" && FIOSEARCH.Text != "")
            {
                List<Client> clientlist;
                using (DataBaseContainer db = new DataBaseContainer())
                {
                    string str = PHONESEARCH.Text;
                    string str2 = FIOSEARCH.Text;
                    dataGridView1.Rows.Clear();
                    clientlist = db.Database.SqlQuery<Client>("select * from Client Where Client.Phone like" + "'" + str + "%" + "'" + "and FIO like" + "'" + str2 + "%" + "'").ToList();
                    //clientlist = db.Client.Where(x => x.Phone == str && x.FIO == str2).ToList();
                    foreach (Client c in clientlist)
                    {
                        dataGridView1.Rows.Add(c.ID, c.FIO, c.Age, c.Phone, c.Email);
                    }

                    if (clientlist.Count == 0)
                    {
                        MessageBox.Show("Клиент не найден", "Тату-салон ");
                    }
                }
            }
        }

    private void Clear_Click(object sender, EventArgs e)
    {
        FIOSEARCH.Text = "";
        PHONESEARCH.Text = "";
        FillClient(currentpage, currentcountonpage);
    }
    public void FillClient(int page, int countonpage)
    {
        using (DataBaseContainer db = new DataBaseContainer())
        {
            numericUpDown1.Value = 10;
            dataGridView1.Rows.Clear();
            var temp1 = db.Client;
            List<Client> clientlist = temp1.ToList();
            maxpage = clientlist.Count() / countonpage;
            if (clientlist.Count() % countonpage != 0)
            {
                maxpage++;
            }
            foreach (Client c in clientlist.Skip((page - 1) * countonpage).Take(countonpage))
            {
                dataGridView1.Rows.Add(c.ID, c.FIO, c.Age, c.Phone, c.Email);
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
        FillClient(currentpage, currentcountonpage);
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
        FillClient(currentpage, currentcountonpage);
        metroLabel3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
    }

    private void FormClient(object sender, EventArgs e)
    {
        currentpage = 1;
        FillClient(currentpage, currentcountonpage);
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
        FormClient(numericUpDown1, e);
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
        ClientEdit addclient = new ClientEdit();
        addclient.Text = "Новый клиент";
        addclient.ShowDialog();
        FillClient(currentpage, currentcountonpage);
    }

    private void metroButton2_Click(object sender, EventArgs e) //кнопка обновить
    {
        FillClient(currentpage, currentcountonpage);

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (stat == 4)
        {
            chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
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

        private void metroButton3_Click(object sender, EventArgs e) //Кнопка "Заказы клиентов" (Была сделана для быстрого перемещения к заказам)
        {
            this.Close();
            Requests req = new Requests();
            req.Show();
        }
    }
}

