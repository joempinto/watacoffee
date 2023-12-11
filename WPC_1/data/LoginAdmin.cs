using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public struct LoginAdmin
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginAdmin(in string username, in string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
