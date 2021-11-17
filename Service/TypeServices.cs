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
using Project1.Services;

namespace Project1.Service
{
    public partial class TypeServices : MetroFramework.Forms.MetroForm
    {
        public TypeServices()
        {
            InitializeComponent();
        }
        #region ---Переменные---
        
        private int backid;
        public int feedbackid
        {
            get { return backid; }
            set { backid = value; }
        }
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
        public int id;
        private int chid;
        public int choosenid
        {
            get { return chid; }
            set { chid = value; }
        }
        #endregion
        private void metroButton1_Click(object sender, EventArgs e)
        {
            TypeServicesEdit tse = new TypeServicesEdit();
            tse.Text = "Новый тип услуг";
            tse.ShowDialog();
            FillGrid();
        }
        private void FillGrid()
        {
            List<TypeService> tservice;
            using (DataBaseContainer db = new DataBaseContainer())
            {
                var temp = db.TypeService;
                tservice = temp.ToList();
                foreach(TypeService tp in tservice)
                {
                    dataGridView1.Rows.Add(tp.ID, tp.Name, tp.Description);
                }
            }  
        }
        private void TypeServices_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            TypeServicesCard formcard = new TypeServicesCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (DataBaseContainer db = new DataBaseContainer())
            {
                Client p = db.Client.Find(id);
                formcard.Text = "Информация № " + id;
                formcard.Currentid = id;
                formcard.ShowDialog();
                FillGrid();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stat == 4)
            {
                chid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }
    }

}
