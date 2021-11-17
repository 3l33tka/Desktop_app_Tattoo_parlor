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
    public partial class EmployeeEdit : MetroFramework.Forms.MetroForm
    {
        public EmployeeEdit()
        {
            InitializeComponent();
            FIOBX.Validating += FIOBX_Validating;
            AGEBX.Validating += AGEBX_Validating;
            POSTBX.Validating += POSTBX_Validating;
            PHONEBX.Validating += PHONEBX_Validating;
            EMAILBX.Validating += EMAILBX_Validating;
        }
        #region
        private int id;
        public int Currentid
        {
           get { return id; }
            set { id = value; }
        }
        #endregion
        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Employee.Find(id) != null)
                {
                    Employee temp = db.Employee.Where(x => x.ID == id).FirstOrDefault<Employee>();
                    FIOBX.Text = temp.FIO;
                    AGEBX.Text = Convert.ToString(temp.Age);
                    PHONEBX.Text = temp.Phone;
                    EMAILBX.Text = temp.Email;
                    POSTBX.Text = temp.Post;

                }
                else
                {
                    SaveBt.Enabled = false;
                    Employee c = new Employee();
                    c.ID = db.Employee.Count() + 1;
                    Currentid = Convert.ToInt32(c.ID);
                }
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            Employee temp = new Employee();
            using (DataBaseContainer db = new DataBaseContainer())
            {
                if (db.Employee.Find(id) == null)
                {
                    Employee emp = new Employee();
                    emp.ID = id;
                    emp.FIO = FIOBX.Text;
                    emp.Phone = PHONEBX.Text;
                    emp.Age = Convert.ToInt32(AGEBX.Text);
                    emp.Email = EMAILBX.Text;
                    emp.Post = POSTBX.Text;
                    db.Employee.Add(emp);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.Employee.Where(x => x.ID == id).FirstOrDefault<Employee>();
                    temp = temp1;
                    temp.FIO = FIOBX.Text;
                    temp.Phone = PHONEBX.Text;
                    temp.Age = Convert.ToInt32(AGEBX.Text);
                    temp.Email = EMAILBX.Text;
                    temp.Post = POSTBX.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату-салон!");
                    this.Close();
                }
            }
        }

        private void FIOBX_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FIOBX.Text))
            {
                errorProvider1.SetError(FIOBX, "Не указано ФИО!");
                SaveBt.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBt.Enabled = true;
            }
        }

        private void AGEBX_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AGEBX.Text))
            {
                errorProvider1.SetError(AGEBX, "Не указан возраст!");
                SaveBt.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBt.Enabled = true;
            }
        }

        private void POSTBX_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(POSTBX.Text))
            {
                errorProvider1.SetError(POSTBX, "Не указана должность!");
                SaveBt.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBt.Enabled = true;
            }

        }

        private void PHONEBX_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PHONEBX.Text))
            {
                errorProvider1.SetError(PHONEBX, "Не указан номер телефона!");
                SaveBt.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBt.Enabled = true;
            }
        }

        private void EMAILBX_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(EMAILBX.Text))
            {
                errorProvider1.SetError(EMAILBX, "Не указан email!");
                SaveBt.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBt.Enabled = true;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
