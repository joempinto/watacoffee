/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.old.login
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
