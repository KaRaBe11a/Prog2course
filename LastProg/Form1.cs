using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void AccHandler();
        public event AccHandler Notify;

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlBuy1.Hide();
            userControlLk1.Hide();
            userControlTransit1.Hide();
            userControlAdmin1.Hide();

        }

        private void buttonLK_Click(object sender, EventArgs e)
        {
            Notify += Lk;
            Notify.Invoke();
            Notify -= Lk;
            
        }

        private void buttonTransit_Click(object sender, EventArgs e)
        {
            Notify += Tr;
            Notify.Invoke();
            Notify -= Tr;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Notify += By;
            Notify.Invoke();
            Notify -= By;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Notify += Lo;
            Notify.Invoke();
            Notify -= Lo;
        }

        public void Lk()
        {
            userControlBuy1.Hide();
            userControlLk1.Show();
            userControlTransit1.Hide();
            userControlLk1.Load();
            userControlAdmin1.Hide();
            
        }


        public void Tr()
        {
            userControlBuy1.Hide();
            userControlLk1.Hide();
            userControlTransit1.Show();
            userControlAdmin1.Hide();
        }

        public void By()
        {
            userControlBuy1.Show();
            userControlLk1.Hide();
            userControlTransit1.Hide();
            userControlBuy1.Load();
            userControlAdmin1.Hide();
        }

        public void Lo()
        {
            if (Classes.Login.isLogin)
            {
                userControlLogReg1.Hide();
                if(Classes.Login.admin == 1)
                {
                    buttonAdm.Visible = true;
                }
            }
            if (Classes.Login.isLogin == false)
            {
                userControlLogReg1.Show();
                buttonAdm.Visible = false;
            }
        }

        private void buttonAdm_Click(object sender, EventArgs e)
        {
            userControlBuy1.Hide();
            userControlLk1.Hide();
            userControlTransit1.Hide();
            userControlAdmin1.Show();
            userControlAdmin1.Load();
        }
    }
}
