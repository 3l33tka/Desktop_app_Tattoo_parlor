
namespace Project1
{
    partial class ServiceCard
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Typelb = new MetroFramework.Controls.MetroLabel();
            this.PriceLB = new MetroFramework.Controls.MetroLabel();
            this.Namelb = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DelBut = new MetroFramework.Controls.MetroButton();
            this.EditBut = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Description = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название услуги";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Стоимость услуги";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Тип услуги";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 348);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Мастер";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 262);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Описание услуги";
            // 
            // Typelb
            // 
            this.Typelb.AutoSize = true;
            this.Typelb.Location = new System.Drawing.Point(322, 204);
            this.Typelb.Name = "Typelb";
            this.Typelb.Size = new System.Drawing.Size(74, 19);
            this.Typelb.TabIndex = 10;
            this.Typelb.Text = "Тип услуги";
            // 
            // PriceLB
            // 
            this.PriceLB.AutoSize = true;
            this.PriceLB.Location = new System.Drawing.Point(322, 142);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(115, 19);
            this.PriceLB.TabIndex = 9;
            this.PriceLB.Text = "Стоимость услуги";
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Location = new System.Drawing.Point(322, 83);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(110, 19);
            this.Namelb.TabIndex = 8;
            this.Namelb.Text = "Название услуги";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(322, 348);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 69);
            this.listBox1.TabIndex = 12;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(200, 670);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 39);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Закрыть";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(355, 670);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(125, 39);
            this.DelBut.TabIndex = 14;
            this.DelBut.Text = "Удалить";
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(200, 605);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(280, 46);
            this.EditBut.TabIndex = 13;
            this.EditBut.Text = "Редактировать";
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(23, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер заказа";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО клиента";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата сеанса";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 89;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время сеанса";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 96;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Статус";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 66;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 414);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(107, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Услуга в заказах";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(322, 262);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(326, 61);
            this.Description.TabIndex = 18;
            // 
            // ServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 755);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Typelb);
            this.Controls.Add(this.PriceLB);
            this.Controls.Add(this.Namelb);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ServiceCard";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Информация о услуге";
            this.Load += new System.EventHandler(this.ServiceCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel Typelb;
        private MetroFramework.Controls.MetroLabel PriceLB;
        private MetroFramework.Controls.MetroLabel Namelb;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton DelBut;
        private MetroFramework.Controls.MetroButton EditBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}