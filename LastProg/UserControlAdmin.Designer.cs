
namespace LastProg
{
    partial class UserControlAdmin
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonFr = new System.Windows.Forms.Button();
            this.buttonUnFr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(189, 33);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(454, 290);
            this.listBoxUsers.TabIndex = 0;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(41, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // buttonFr
            // 
            this.buttonFr.Location = new System.Drawing.Point(13, 59);
            this.buttonFr.Name = "buttonFr";
            this.buttonFr.Size = new System.Drawing.Size(75, 23);
            this.buttonFr.TabIndex = 2;
            this.buttonFr.Text = "Заморозить";
            this.buttonFr.UseVisualStyleBackColor = true;
            this.buttonFr.Click += new System.EventHandler(this.buttonFr_Click);
            // 
            // buttonUnFr
            // 
            this.buttonUnFr.Location = new System.Drawing.Point(94, 59);
            this.buttonUnFr.Name = "buttonUnFr";
            this.buttonUnFr.Size = new System.Drawing.Size(80, 23);
            this.buttonUnFr.TabIndex = 3;
            this.buttonUnFr.Text = "Разморозить";
            this.buttonUnFr.UseVisualStyleBackColor = true;
            this.buttonUnFr.Click += new System.EventHandler(this.buttonUnFr_Click);
            // 
            // UserControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUnFr);
            this.Controls.Add(this.buttonFr);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "UserControlAdmin";
            this.Size = new System.Drawing.Size(673, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonFr;
        private System.Windows.Forms.Button buttonUnFr;
    }
}
