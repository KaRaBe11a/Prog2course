using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProg.DataBase
{
    class SQL
    {
        private List<string> str;
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=bankusers");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public static void Registration(string login, string pass) // Добавление нового пользователя
        {
            SQL dataBase = new SQL();
            dataBase.str = new List<string>();
            MySqlCommand commandInsert = new MySqlCommand("INSERT INTO `userlk`(`Login`, `Password`, `Count`, `admin`, `isOnline`) VALUES (@l, @p, @c, @a, @o)", dataBase.getConnection());
            commandInsert.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            commandInsert.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
            commandInsert.Parameters.Add("@c", MySqlDbType.Int32).Value = 0;
            commandInsert.Parameters.Add("@a", MySqlDbType.Int32).Value = 0;
            commandInsert.Parameters.Add("@o", MySqlDbType.Int32).Value = 1;
            dataBase.openConnection();
            commandInsert.ExecuteNonQuery();
            dataBase.closeConnection();
            
        }

        public static bool Login(string login, string pass)
        {
            SQL dataBase = new SQL();
            dataBase.str = new List<string>();
            MySqlCommand commandTake = new MySqlCommand("SELECT * FROM `userlk` WHERE `Login` = @l AND `Password` = @p", dataBase.getConnection());
            commandTake.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            commandTake.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = commandTake;
            DataTable table = new DataTable();

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }

            for ( int i = 0; i<table.Rows.Count; i++)
            {
                for ( int j = 0; j<table.Columns.Count; j++)
                {
                    dataBase.str.Add(table.Rows[i][j].ToString());
                }
                Classes.Login.id = Convert.ToInt32(dataBase.str[0]);
                Classes.Login.isOnline = Convert.ToInt32(dataBase.str[1]);
                Classes.Login.count = Convert.ToInt32(dataBase.str[2]);
                Classes.Login.admin = Convert.ToInt32(dataBase.str[5]);
                Classes.Login.isLogin = true;
            }
            return true;
        }

        public static void Transit(int number, int count)
        {
            SQL dataBase = new SQL();
            dataBase.str = new List<string>();
            int newCount = 0;
            MySqlCommand commandTakefirst = new MySqlCommand("UPDATE `userlk` SET `Count` = @c WHERE `Id` = @i", dataBase.getConnection());
            commandTakefirst.Parameters.Add("@c", MySqlDbType.Int32).Value = Classes.Login.count - count;
            Classes.Login.count -= count;
            commandTakefirst.Parameters.Add("@i", MySqlDbType.Int32).Value = Classes.Login.id;
            MySqlCommand commandTakeSecond = new MySqlCommand("SELECT `Count` FROM `userlk` WHERE `Id` = @id", dataBase.getConnection());
            commandTakeSecond.Parameters.Add("@id", MySqlDbType.Int32).Value = number;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = commandTakeSecond;
            DataTable table = new DataTable();
            adapter.Fill(table);
            newCount = Convert.ToInt32(table.Rows[0][0]);
            MySqlCommand updateSecond = new MySqlCommand("UPDATE `userlk` SET `Count` = @c WHERE `Id` = @i", dataBase.getConnection());
            updateSecond.Parameters.Add("@c", MySqlDbType.Int32).Value = newCount + count;
            updateSecond.Parameters.Add("@i", MySqlDbType.Int32).Value = number;

            dataBase.openConnection();
            commandTakefirst.ExecuteNonQuery();
            updateSecond.ExecuteNonQuery();
            dataBase.closeConnection();


        }

        public static void Freez()
        {
            SQL dataBase = new SQL();
            MySqlCommand commandFreez = new MySqlCommand("UPDATE `userlk` SET `isOnline` = @o WHERE `Id` = @i", dataBase.getConnection());
            commandFreez.Parameters.Add("@o", MySqlDbType.Int32).Value = 0;
            commandFreez.Parameters.Add("@i", MySqlDbType.Int32).Value = Classes.Login.id;
            dataBase.openConnection();
            commandFreez.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public static void Anul()
        {
            SQL dataBase = new SQL();
            MySqlCommand commandNULL = new MySqlCommand("DELETE FROM `userlk` WHERE `Id` = @i", dataBase.getConnection());
            commandNULL.Parameters.Add("@i", MySqlDbType.Int32).Value = Classes.Login.id;
            MessageBox.Show(Classes.Login.id.ToString());
            dataBase.openConnection();
            commandNULL.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public static List<Classes.Purchased<string>> Purchased()
        {
            SQL dataBase = new SQL();
            dataBase.str = new List<string>();
            List<Classes.Purchased<string>> result = new List<Classes.Purchased<string>>();
            MySqlCommand commandTake = new MySqlCommand("SELECT `Name`, `Count` FROM `purchased` WHERE `id` = @i", dataBase.getConnection());
            commandTake.Parameters.Add("@i", MySqlDbType.Int32).Value = Classes.Login.id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = commandTake;
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i<table.Rows.Count; i++)
            {
                for (int j = 0; j<table.Columns.Count; j++)
                {
                    dataBase.str.Add(table.Rows[i][j].ToString());
                }
                result.Add(new Classes.Purchased<string>(dataBase.str[0], Convert.ToInt32(dataBase.str[1])));
                dataBase.str.Clear();

            }
            return result;

        }

        public static void Buy(string name, int count, int walue)
        {
            SQL dataBase = new SQL();
            MySqlCommand command = new MySqlCommand("INSERT INTO `purchased` (`id`, `Name`, `Count`) VALUES (@i, @n, @c)", dataBase.getConnection());
            command.Parameters.Add("@i", MySqlDbType.Int32).Value = Classes.Login.id;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@c", MySqlDbType.Int32).Value = count;
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();

            command = new MySqlCommand("UPDATE `userlk` SET `Count` = @c WHERE `Id` = @i", dataBase.getConnection());
            command.Parameters.Add("@i", MySqlDbType.Int32).Value = Classes.Login.id;
            command.Parameters.Add("@c", MySqlDbType.Int32).Value = Classes.Login.count - (count * walue);
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();


        }

        public static List<Classes.User> Users()
        {
            SQL dataBase = new SQL();
            dataBase.str = new List<string>();
            List<Classes.User> result = new List<Classes.User>();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `userlk`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i<table.Rows.Count; i++)
            {
                for ( int j = 0; j<table.Columns.Count; j++)
                {
                    dataBase.str.Add(table.Rows[i][j].ToString());
                }
                result.Add(new Classes.User(Convert.ToInt32(dataBase.str[0]), Convert.ToInt32(dataBase.str[2]), dataBase.str[4], dataBase.str[3], Convert.ToInt32(dataBase.str[1]), Convert.ToInt32(dataBase.str[5])));
                dataBase.str.Clear();
            }

            return result;
        }

        public static void Freez(int id)
        {
            SQL dataBase = new SQL();
            MySqlCommand command = new MySqlCommand("UPDATE `userlk` SET `isOnline` = @o WHERE `Id` = @i", dataBase.getConnection());
            command.Parameters.Add("@o", MySqlDbType.Int32).Value = 0;
            command.Parameters.Add("@I", MySqlDbType.Int32).Value = id;

            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public static void unFreez(int id)
        {
            SQL dataBase = new SQL();
            MySqlCommand command = new MySqlCommand("UPDATE `userlk` SET `isOnline` = @o WHERE `Id` = @i", dataBase.getConnection());
            command.Parameters.Add("@o", MySqlDbType.Int32).Value = 1;
            command.Parameters.Add("@I", MySqlDbType.Int32).Value = id;

            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }

    }
}
