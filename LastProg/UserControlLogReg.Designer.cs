
namespace LastProg
{
    partial class UserControlLogReg
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxSignLog = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxSignPas = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация";
            // 
            // textBoxRegLogin
            // 
            this.textBoxRegLogin.Location = new System.Drawing.Point(491, 40);
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegLogin.TabIndex = 2;
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(491, 66);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegPassword.TabIndex = 3;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(473, 92);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(130, 23);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "Зарегитсрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxSignLog
            // 
            this.textBoxSignLog.Location = new System.Drawing.Point(31, 40);
            this.textBoxSignLog.Name = "textBoxSignLog";
            this.textBoxSignLog.Size = new System.Drawing.Size(100, 20);
            this.textBoxSignLog.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxSignPas
            // 
            this.textBoxSignPas.Location = new System.Drawing.Point(31, 66);
            this.textBoxSignPas.Name = "textBoxSignPas";
            this.textBoxSignPas.Size = new System.Drawing.Size(100, 20);
            this.textBoxSignPas.TabIndex = 7;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(15, 92);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(130, 23);
            this.buttonSign.TabIndex = 8;
            this.buttonSign.Text = "Войти";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Логин";
            // 
            // UserControlLogReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.textBoxSignPas);
            this.Controls.Add(this.textBoxSignLog);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxRegPassword);
            this.Controls.Add(this.textBoxRegLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlLogReg";
            this.Size = new System.Drawing.Size(801, 453);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegLogin;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxSignLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxSignPas;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
