using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.register
{
    public struct RegisterUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisterUser(in string Nom, in string Email, in string Password)
        {
            this.Name = Nom;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
