using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1.data
{
    public struct RegisterUser
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public RegisterUser(in string username, in string email, in string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}
