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
    public partial class TypeServicesEdit : MetroFramework.Forms.MetroForm
    {
        public TypeServicesEdit()
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
        private void metroButton1_Click(object sender, EventArgs e) //Save TypeService
        {
            TypeService temp = new TypeService();
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.TypeService.Find(id) == null)
                {
                    TypeService c = new TypeService();
                    c.ID = id;
                    c.Name = nameTX.Text;
                    c.Description = DescriptionText.Text;
                    db.TypeService.Add(c);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();

                }
                else
                {
                    var temp1 = db.TypeService.Where(x => x.ID == id).FirstOrDefault<TypeService>();
                    temp = temp1;
                    temp.Name = nameTX.Text;
                    temp.Description = DescriptionText.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();
                }
            }
        }
    }
}
