/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.register
{
    public struct RegisterUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisterUser(in string Username, in string Email, in string Password)
        {
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
