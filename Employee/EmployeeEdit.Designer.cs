
namespace Project1
{
    partial class EmployeeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FIOBX = new MetroFramework.Controls.MetroTextBox();
            this.AGEBX = new MetroFramework.Controls.MetroTextBox();
            this.POSTBX = new MetroFramework.Controls.MetroTextBox();
            this.PHONEBX = new MetroFramework.Controls.MetroTextBox();
            this.EMAILBX = new MetroFramework.Controls.MetroTextBox();
            this.SaveBt = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 199);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Должность";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 304);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Электронная почта";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 250);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Номер телефона";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Возраст";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "ФИО";
            // 
            // FIOBX
            // 
            this.FIOBX.Location = new System.Drawing.Point(182, 89);
            this.FIOBX.Name = "FIOBX";
            this.FIOBX.Size = new System.Drawing.Size(230, 23);
            this.FIOBX.TabIndex = 28;
            this.FIOBX.Validating += new System.ComponentModel.CancelEventHandler(this.FIOBX_Validating);
            // 
            // AGEBX
            // 
            this.AGEBX.Location = new System.Drawing.Point(182, 147);
            this.AGEBX.Name = "AGEBX";
            this.AGEBX.Size = new System.Drawing.Size(230, 23);
            this.AGEBX.TabIndex = 29;
            this.AGEBX.Validating += new System.ComponentModel.CancelEventHandler(this.AGEBX_Validating);
            // 
            // POSTBX
            // 
            this.POSTBX.Location = new System.Drawing.Point(182, 199);
            this.POSTBX.Name = "POSTBX";
            this.POSTBX.Size = new System.Drawing.Size(230, 23);
            this.POSTBX.TabIndex = 30;
            this.POSTBX.Validating += new System.ComponentModel.CancelEventHandler(this.POSTBX_Validating);
            // 
            // PHONEBX
            // 
            this.PHONEBX.Location = new System.Drawing.Point(182, 250);
            this.PHONEBX.Name = "PHONEBX";
            this.PHONEBX.Size = new System.Drawing.Size(230, 23);
            this.PHONEBX.TabIndex = 31;
            this.PHONEBX.Validating += new System.ComponentModel.CancelEventHandler(this.PHONEBX_Validating);
            // 
            // EMAILBX
            // 
            this.EMAILBX.Location = new System.Drawing.Point(182, 300);
            this.EMAILBX.Name = "EMAILBX";
            this.EMAILBX.Size = new System.Drawing.Size(230, 23);
            this.EMAILBX.TabIndex = 32;
            this.EMAILBX.Validating += new System.ComponentModel.CancelEventHandler(this.EMAILBX_Validating);
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(269, 379);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(143, 41);
            this.SaveBt.TabIndex = 33;
            this.SaveBt.Text = "Сохранить";
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 379);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(143, 41);
            this.metroButton2.TabIndex = 34;
            this.metroButton2.Text = "Отмена";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 461);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.EMAILBX);
            this.Controls.Add(this.PHONEBX);
            this.Controls.Add(this.POSTBX);
            this.Controls.Add(this.AGEBX);
            this.Controls.Add(this.FIOBX);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EmployeeEdit";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Редактировать информацию";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox FIOBX;
        private MetroFramework.Controls.MetroTextBox AGEBX;
        private MetroFramework.Controls.MetroTextBox POSTBX;
        private MetroFramework.Controls.MetroTextBox PHONEBX;
        private MetroFramework.Controls.MetroTextBox EMAILBX;
        private MetroFramework.Controls.MetroButton SaveBt;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}