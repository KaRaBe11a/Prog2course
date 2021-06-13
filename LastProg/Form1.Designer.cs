
namespace LastProg
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLK = new System.Windows.Forms.Button();
            this.buttonTransit = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAdm = new System.Windows.Forms.Button();
            this.userControlAdmin1 = new LastProg.UserControlAdmin();
            this.userControlLogReg1 = new LastProg.UserControlLogReg();
            this.userControlBuy1 = new LastProg.UserControlBuy();
            this.userControlTransit1 = new LastProg.UserControlTransit();
            this.userControlLk1 = new LastProg.UserControlLk();
            this.SuspendLayout();
            // 
            // buttonLK
            // 
            this.buttonLK.Location = new System.Drawing.Point(12, 12);
            this.buttonLK.Name = "buttonLK";
            this.buttonLK.Size = new System.Drawing.Size(97, 36);
            this.buttonLK.TabIndex = 0;
            this.buttonLK.Text = "Личный кабинет";
            this.buttonLK.UseVisualStyleBackColor = true;
            this.buttonLK.Click += new System.EventHandler(this.buttonLK_Click);
            // 
            // buttonTransit
            // 
            this.buttonTransit.Location = new System.Drawing.Point(13, 55);
            this.buttonTransit.Name = "buttonTransit";
            this.buttonTransit.Size = new System.Drawing.Size(96, 35);
            this.buttonTransit.TabIndex = 1;
            this.buttonTransit.Text = "Перевод";
            this.buttonTransit.UseVisualStyleBackColor = true;
            this.buttonTransit.Click += new System.EventHandler(this.buttonTransit_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(13, 97);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(96, 40);
            this.buttonBuy.TabIndex = 2;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAdm
            // 
            this.buttonAdm.Location = new System.Drawing.Point(13, 143);
            this.buttonAdm.Name = "buttonAdm";
            this.buttonAdm.Size = new System.Drawing.Size(99, 39);
            this.buttonAdm.TabIndex = 7;
            this.buttonAdm.Text = "Админ Панель";
            this.buttonAdm.UseVisualStyleBackColor = true;
            this.buttonAdm.Visible = false;
            this.buttonAdm.Click += new System.EventHandler(this.buttonAdm_Click);
            // 
            // userControlAdmin1
            // 
            this.userControlAdmin1.Location = new System.Drawing.Point(118, 12);
            this.userControlAdmin1.Name = "userControlAdmin1";
            this.userControlAdmin1.Size = new System.Drawing.Size(673, 426);
            this.userControlAdmin1.TabIndex = 8;
            // 
            // userControlLogReg1
            // 
            this.userControlLogReg1.Location = new System.Drawing.Point(0, -2);
            this.userControlLogReg1.Name = "userControlLogReg1";
            this.userControlLogReg1.Size = new System.Drawing.Size(801, 453);
            this.userControlLogReg1.TabIndex = 6;
            // 
            // userControlBuy1
            // 
            this.userControlBuy1.Location = new System.Drawing.Point(115, 12);
            this.userControlBuy1.Name = "userControlBuy1";
            this.userControlBuy1.Size = new System.Drawing.Size(673, 426);
            this.userControlBuy1.TabIndex = 5;
            // 
            // userControlTransit1
            // 
            this.userControlTransit1.Location = new System.Drawing.Point(115, 12);
            this.userControlTransit1.Name = "userControlTransit1";
            this.userControlTransit1.Size = new System.Drawing.Size(673, 426);
            this.userControlTransit1.TabIndex = 4;
            // 
            // userControlLk1
            // 
            this.userControlLk1.Location = new System.Drawing.Point(115, 12);
            this.userControlLk1.Name = "userControlLk1";
            this.userControlLk1.Size = new System.Drawing.Size(673, 426);
            this.userControlLk1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlAdmin1);
            this.Controls.Add(this.buttonAdm);
            this.Controls.Add(this.userControlLogReg1);
            this.Controls.Add(this.userControlBuy1);
            this.Controls.Add(this.userControlTransit1);
            this.Controls.Add(this.userControlLk1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonTransit);
            this.Controls.Add(this.buttonLK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLK;
        private System.Windows.Forms.Button buttonTransit;
        private System.Windows.Forms.Button buttonBuy;
        private UserControlLk userControlLk1;
        private UserControlTransit userControlTransit1;
        private UserControlBuy userControlBuy1;
        private UserControlLogReg userControlLogReg1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAdm;
        private UserControlAdmin userControlAdmin1;
    }
}

