
namespace Project1.Services
{
    partial class TypeServicesCard
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
            this.namelb = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.DescriptionText = new MetroFramework.Controls.MetroTextBox();
            this.del = new MetroFramework.Controls.MetroButton();
            this.cancel = new MetroFramework.Controls.MetroButton();
            this.edit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название";
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Location = new System.Drawing.Point(210, 86);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(82, 19);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "НазваниеТТ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Описание";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Enabled = false;
            this.DescriptionText.Location = new System.Drawing.Point(23, 153);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(306, 131);
            this.DescriptionText.TabIndex = 3;
            // 
            // del
            // 
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.Location = new System.Drawing.Point(230, 353);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(99, 43);
            this.del.Style = MetroFramework.MetroColorStyle.Orange;
            this.del.TabIndex = 4;
            this.del.Text = "Удалить";
            this.del.Theme = MetroFramework.MetroThemeStyle.Light;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Location = new System.Drawing.Point(23, 353);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 43);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Закрыть";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // edit
            // 
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Location = new System.Drawing.Point(97, 290);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(159, 43);
            this.edit.Style = MetroFramework.MetroColorStyle.Orange;
            this.edit.TabIndex = 6;
            this.edit.Text = "Редактировать";
            this.edit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // TypeServicesCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 419);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.del);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TypeServicesCard";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Информация о типе услуги";
            this.Load += new System.EventHandler(this.TypeServicesCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel namelb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox DescriptionText;
        private MetroFramework.Controls.MetroButton del;
        private MetroFramework.Controls.MetroButton cancel;
        private MetroFramework.Controls.MetroButton edit;
    }
}