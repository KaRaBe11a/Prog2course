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
    public partial class UserControlLk : UserControl
    {
        public UserControlLk()
        {
            InitializeComponent();
        }
        
        public new void Load()
        {
            textBoxBalance.Text = Classes.Login.count.ToString();
            textBoxSchetNumber.Text = Classes.Login.id.ToString();
        }

        private void buttonFreez_Click(object sender, EventArgs e)
        {
            Classes.Login.isOnline = 0;
            DataBase.SQL.Freez();

        }

        private void buttonNULL_Click(object sender, EventArgs e)
        {
            Classes.Login.isLogin = false;
            DataBase.SQL.Anul();


        }
    }
}
