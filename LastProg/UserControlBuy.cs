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
    public partial class UserControlBuy : UserControl
    {
        public UserControlBuy()
        {
            InitializeComponent();
        }

        public new void Load()
        {
            List<Classes.Purchased<string>> res = new List<Classes.Purchased<string>>();
            res = DataBase.SQL.Purchased(); 

            Classes.CompInv<Classes.Purchased<string>> cp = new Classes.CompInv<Classes.Purchased<string>>();
            res.Sort(cp);

            listBox1.Items.Clear();
            foreach (Classes.Purchased<string> item in res)
            {
                listBox1.Items.Add(item.MakeString());
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            int Count = Convert.ToInt32(textBoxCount.Text);
            int Walue = Convert.ToInt32(textBoxWalue.Text);
            DataBase.SQL.Buy(Name, Count, Walue);

            Load();
        }

    }
}
