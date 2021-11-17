
namespace Project1
{
    partial class ClientEdit
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SaveBt = new MetroFramework.Controls.MetroButton();
            this.FIOBox = new MetroFramework.Controls.MetroTextBox();
            this.AgeBox = new MetroFramework.Controls.MetroTextBox();
            this.PhoneBox = new MetroFramework.Controls.MetroTextBox();
            this.EmailBox = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelBt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 268);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Электронная почта";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 206);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Номер телефона";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 138);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Возраст";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "ФИО";
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(334, 405);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(113, 39);
            this.SaveBt.TabIndex = 9;
            this.SaveBt.Text = "Сохранить";
            this.SaveBt.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(178, 74);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(269, 23);
            this.FIOBox.TabIndex = 10;
            this.FIOBox.Validating += new System.ComponentModel.CancelEventHandler(this.FIOBox_Validating);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(178, 138);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(269, 23);
            this.AgeBox.TabIndex = 11;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(178, 206);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(269, 23);
            this.PhoneBox.TabIndex = 12;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(178, 268);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(269, 23);
            this.EmailBox.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelBt
            // 
            this.CancelBt.Location = new System.Drawing.Point(23, 405);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(113, 39);
            this.CancelBt.TabIndex = 14;
            this.CancelBt.Text = "Отмена";
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 490);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientEdit";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Редактировать информацию";
            this.Load += new System.EventHandler(this.ClientEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton SaveBt;
        private MetroFramework.Controls.MetroTextBox FIOBox;
        private MetroFramework.Controls.MetroTextBox AgeBox;
        private MetroFramework.Controls.MetroTextBox PhoneBox;
        private MetroFramework.Controls.MetroTextBox EmailBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton CancelBt;
    }
}