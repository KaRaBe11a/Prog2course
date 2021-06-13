
namespace LastProg
{
    partial class UserControlLk
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSchetNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonFreez = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNULL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Баланс";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(3, 37);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxBalance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер счёта";
            // 
            // textBoxSchetNumber
            // 
            this.textBoxSchetNumber.Location = new System.Drawing.Point(3, 107);
            this.textBoxSchetNumber.Name = "textBoxSchetNumber";
            this.textBoxSchetNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxSchetNumber.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonFreez
            // 
            this.buttonFreez.Location = new System.Drawing.Point(130, 27);
            this.buttonFreez.Name = "buttonFreez";
            this.buttonFreez.Size = new System.Drawing.Size(110, 38);
            this.buttonFreez.TabIndex = 4;
            this.buttonFreez.Text = "Заморозить счёт";
            this.buttonFreez.UseVisualStyleBackColor = true;
            this.buttonFreez.Click += new System.EventHandler(this.buttonFreez_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Разморозить счёт может только админ";
            // 
            // buttonNULL
            // 
            this.buttonNULL.Location = new System.Drawing.Point(130, 104);
            this.buttonNULL.Name = "buttonNULL";
            this.buttonNULL.Size = new System.Drawing.Size(110, 32);
            this.buttonNULL.TabIndex = 6;
            this.buttonNULL.Text = "Анулировать счёт";
            this.buttonNULL.UseVisualStyleBackColor = true;
            this.buttonNULL.Click += new System.EventHandler(this.buttonNULL_Click);
            // 
            // UserControlLk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNULL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFreez);
            this.Controls.Add(this.textBoxSchetNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.label1);
            this.Name = "UserControlLk";
            this.Size = new System.Drawing.Size(673, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSchetNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonFreez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNULL;
    }
}
