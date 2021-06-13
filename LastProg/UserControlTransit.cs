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
    public partial class UserControlTransit : UserControl
    {
        public UserControlTransit()
        {
            InitializeComponent();
        }

        private void buttonTransit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBoxSchetNum.Text);
            int count = Convert.ToInt32(textBoxCount.Text);
            DataBase.SQL.Transit(num, count);
        }
    }
}
