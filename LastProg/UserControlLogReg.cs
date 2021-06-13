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
    public partial class UserControlLogReg : UserControl
    {
        public UserControlLogReg()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string log = textBoxRegLogin.Text;
            string pass = textBoxRegPassword.Text;
            DataBase.SQL.Registration(log, pass);
            MessageBox.Show("Succesfull");
            
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            string log = textBoxSignLog.Text;
            string pass = textBoxSignPas.Text;
            if(DataBase.SQL.Login(log, pass))
            {
                
            }
            else
            {
                MessageBox.Show("Xui");
            }
        }
    }
}
