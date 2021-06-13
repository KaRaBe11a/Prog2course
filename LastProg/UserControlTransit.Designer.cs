
namespace LastProg
{
    partial class UserControlTransit
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
            this.textBoxSchetNum = new System.Windows.Forms.TextBox();
            this.buttonTransit = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSchetNum
            // 
            this.textBoxSchetNum.Location = new System.Drawing.Point(22, 30);
            this.textBoxSchetNum.Name = "textBoxSchetNum";
            this.textBoxSchetNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSchetNum.TabIndex = 0;
            // 
            // buttonTransit
            // 
            this.buttonTransit.Location = new System.Drawing.Point(33, 82);
            this.buttonTransit.Name = "buttonTransit";
            this.buttonTransit.Size = new System.Drawing.Size(75, 23);
            this.buttonTransit.TabIndex = 1;
            this.buttonTransit.Text = "перевести";
            this.buttonTransit.UseVisualStyleBackColor = true;
            this.buttonTransit.Click += new System.EventHandler(this.buttonTransit_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(22, 56);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер счёта получателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма";
            // 
            // UserControlTransit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonTransit);
            this.Controls.Add(this.textBoxSchetNum);
            this.Name = "UserControlTransit";
            this.Size = new System.Drawing.Size(673, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSchetNum;
        private System.Windows.Forms.Button buttonTransit;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
