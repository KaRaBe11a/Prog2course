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
    public partial class UserControlAdmin : UserControl
    {
        public UserControlAdmin()
        {
            InitializeComponent();
        }

        public new void Load()
        {
            List<Classes.User> users = new List<Classes.User>();
            users = DataBase.SQL.Users();
            listBoxUsers.Items.Clear();
            foreach (Classes.User item in users)
            {
                listBoxUsers.Items.Add(item.MakeString());
            }
        }

        private void buttonFr_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            DataBase.SQL.Freez(id);
            Load();
        }

        private void buttonUnFr_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            DataBase.SQL.unFreez(id);
            Load();
        }
    }
}
