
namespace Project1
{
    partial class ClientCard
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
            this.FIOLB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.AGELB = new MetroFramework.Controls.MetroLabel();
            this.PHONELB = new MetroFramework.Controls.MetroLabel();
            this.EMAILLB = new MetroFramework.Controls.MetroLabel();
            this.EditBut = new MetroFramework.Controls.MetroButton();
            this.DelBut = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ФИО";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Возраст";
            // 
            // FIOLB
            // 
            this.FIOLB.AutoSize = true;
            this.FIOLB.Location = new System.Drawing.Point(201, 83);
            this.FIOLB.Name = "FIOLB";
            this.FIOLB.Size = new System.Drawing.Size(83, 19);
            this.FIOLB.TabIndex = 2;
            this.FIOLB.Text = "metroLabel3";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Номер телефона";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 149);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Электронная почта";
            // 
            // AGELB
            // 
            this.AGELB.AutoSize = true;
            this.AGELB.Location = new System.Drawing.Point(201, 120);
            this.AGELB.Name = "AGELB";
            this.AGELB.Size = new System.Drawing.Size(83, 19);
            this.AGELB.TabIndex = 5;
            this.AGELB.Text = "metroLabel6";
            // 
            // PHONELB
            // 
            this.PHONELB.AutoSize = true;
            this.PHONELB.Location = new System.Drawing.Point(202, 178);
            this.PHONELB.Name = "PHONELB";
            this.PHONELB.Size = new System.Drawing.Size(83, 19);
            this.PHONELB.TabIndex = 6;
            this.PHONELB.Text = "metroLabel7";
            // 
            // EMAILLB
            // 
            this.EMAILLB.AutoSize = true;
            this.EMAILLB.Location = new System.Drawing.Point(201, 149);
            this.EMAILLB.Name = "EMAILLB";
            this.EMAILLB.Size = new System.Drawing.Size(83, 19);
            this.EMAILLB.TabIndex = 7;
            this.EMAILLB.Text = "metroLabel8";
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(245, 468);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(280, 46);
            this.EditBut.TabIndex = 8;
            this.EditBut.Text = "Редактировать";
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(400, 541);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(125, 39);
            this.DelBut.TabIndex = 10;
            this.DelBut.Text = "Удалить";
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(245, 541);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 39);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Закрыть";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(14, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 195);
            this.dataGridView1.TabIndex = 12;
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
            this.Column2.HeaderText = "ФИО Клиента";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 96;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 87;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата сеанса";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 89;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Время сеанса";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 96;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Статус";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 66;
            // 
            // ClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.EMAILLB);
            this.Controls.Add(this.PHONELB);
            this.Controls.Add(this.AGELB);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.FIOLB);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientCard";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Информация о клиенте";
            this.Load += new System.EventHandler(this.ClientCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel FIOLB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel AGELB;
        private MetroFramework.Controls.MetroLabel PHONELB;
        private MetroFramework.Controls.MetroLabel EMAILLB;
        private MetroFramework.Controls.MetroButton EditBut;
        private MetroFramework.Controls.MetroButton DelBut;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}