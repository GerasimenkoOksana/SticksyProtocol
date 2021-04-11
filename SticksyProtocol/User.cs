using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SticksyProtocol
{
    [Serializable]
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public List<Stick> sticks { get; set; }

        public User(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.sticks = new List<Stick>();
        }
    }

    [Serializable]
    public class Friend  //пользователь с данными для других пользователей (чтобы выбрать и добавить к стику)
    {
        public int id { get; }
        public string login { get; }

        public Friend(int id, string login)
        {
            this.id = id;
            this.login = login;
        }
    }
}
