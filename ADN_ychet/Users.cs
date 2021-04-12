using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN_ychet
{
    public partial class Users
    {
        public int Id { get; set; }

        public string login, password;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Users() { }

        public Users(int Id, string Login, string Password)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
