using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public struct LoginUser
    {
        public string email { get; set; }
        public string password { get; set; }

        public LoginUser(in string email, in string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
