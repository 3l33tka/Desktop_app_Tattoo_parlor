
namespace Project1
{
    partial class ScheduleEdit
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Fiotx = new MetroFramework.Controls.MetroTextBox();
            this.datetx = new MetroFramework.Controls.MetroTextBox();
            this.dateftx = new MetroFramework.Controls.MetroTextBox();
            this.SaveBt = new MetroFramework.Controls.MetroButton();
            this.CancelBt = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.posttx = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 267);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Должность";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 197);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Дата и время окончания";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Дата и время начала";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "ФИО сотрудника";
            // 
            // Fiotx
            // 
            this.Fiotx.Location = new System.Drawing.Point(257, 79);
            this.Fiotx.Name = "Fiotx";
            this.Fiotx.Size = new System.Drawing.Size(219, 23);
            this.Fiotx.TabIndex = 10;
            // 
            // datetx
            // 
            this.datetx.Location = new System.Drawing.Point(257, 139);
            this.datetx.Name = "datetx";
            this.datetx.Size = new System.Drawing.Size(219, 23);
            this.datetx.TabIndex = 11;
            // 
            // dateftx
            // 
            this.dateftx.Location = new System.Drawing.Point(257, 197);
            this.dateftx.Name = "dateftx";
            this.dateftx.Size = new System.Drawing.Size(219, 23);
            this.dateftx.TabIndex = 12;
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(324, 321);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(115, 41);
            this.SaveBt.TabIndex = 15;
            this.SaveBt.Text = "Сохранить";
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Location = new System.Drawing.Point(23, 321);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(115, 41);
            this.CancelBt.TabIndex = 16;
            this.CancelBt.Text = "Отмена";
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(131, 83);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "выбрать";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // posttx
            // 
            this.posttx.AutoSize = true;
            this.posttx.Location = new System.Drawing.Point(257, 266);
            this.posttx.Name = "posttx";
            this.posttx.Size = new System.Drawing.Size(73, 19);
            this.posttx.TabIndex = 19;
            this.posttx.Text = "должность";
            // 
            // ScheduleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 394);
            this.Controls.Add(this.posttx);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.dateftx);
            this.Controls.Add(this.datetx);
            this.Controls.Add(this.Fiotx);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ScheduleEdit";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Редактирование информации";
            this.Load += new System.EventHandler(this.ScheduleEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Fiotx;
        private MetroFramework.Controls.MetroTextBox datetx;
        private MetroFramework.Controls.MetroTextBox dateftx;
        private MetroFramework.Controls.MetroButton SaveBt;
        private MetroFramework.Controls.MetroButton CancelBt;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel posttx;
    }
}