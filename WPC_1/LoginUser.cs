using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1
{
    public struct LoginUser
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginUser(in string Email, in string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }

    
}
