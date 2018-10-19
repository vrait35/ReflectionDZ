using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string passwordMail;
        private string loginMail;

        public User(string password,string login)
        {
            passwordMail = new string(password.ToCharArray());
            loginMail = new string(login.ToCharArray());
        }

        public void AddAge()
        {
            Age++;
        }
    }
}
