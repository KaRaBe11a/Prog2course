using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProg.Classes
{
    class User
    {
        public int id;
        public int Count;
        public string login;
        public string password;
        public int isOnline;
        public int admin;

        public User()
        {

        }

        public User(int i, int c, string l, string p, int o, int a)
        {
            this.id = i;
            this.Count = c;
            this.password = p;
            this.admin = a;
            this.login = l;
            this.isOnline = o;
        }

        public string MakeString()
        {
            return "Id: " + id.ToString() + " Баланс: " + Count.ToString() + " Логин: " + login + " Пароль: " + password + " Статус: " + isOnline.ToString() + " Админ: " + admin.ToString();
        }
    }
}
