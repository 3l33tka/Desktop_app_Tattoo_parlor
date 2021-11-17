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

namespace Project1.Services
{
    public partial class TypeServicesCard : MetroFramework.Forms.MetroForm
    {
        public TypeServicesCard()
        {
            InitializeComponent();
        }
        #region ---Переменные---
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
        private void Reload(int id)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                TypeService temp = db.TypeService.Where(x => x.ID == id).FirstOrDefault<TypeService>();
                namelb.Text = temp.Name;
                DescriptionText.Text = temp.Description;
            }
        }

        private void TypeServicesCard_Load(object sender, EventArgs e)
        {
            Reload(this.id);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            TypeServicesEdit tse = new TypeServicesEdit();
            tse.Currentid = id;
            tse.ShowDialog();
            Reload(id);
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                TypeService ts = db.TypeService.Where(x => x.ID == id).FirstOrDefault<TypeService>();
                Serviices ser = db.Service.Where(x => x.TypeServiceID == ts.ID).FirstOrDefault<Serviices>();
                if(ser != null )
                {
                    db.TypeService.Remove(ts);
                    db.Service.Remove(ser);
                    MessageBox.Show(" Тип услуги удален!", "Тату салон");
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    db.TypeService.Remove(ts);
                    MessageBox.Show(" Тип услуги удален!", "Тату салон");
                    db.SaveChanges();
                    this.Close();
                }
              
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
