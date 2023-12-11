using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class UserLlista
    {
        public string username { get; set; }
        public string email { get; set; }

        public UserLlista(string username, string email)
        {
            this.username = username;
            this.email = email;
        }

        public override string ToString()
        {
            return "\nEmail: " + email + "\nName: " + username;
        }
    }
}
