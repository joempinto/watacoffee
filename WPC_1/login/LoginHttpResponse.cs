using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.login
{
    internal class LoginHttpResponse
    {
        public string email { get; set; } 
        public string token { get; set; }
        public string head { get; set; }
        public string name { get; set; }
        public LoginHttpResponse(in string head, in string token, in string email, in string name)
        {
            this.email = email;
            this.token = token;
            this.head = head;
            this.name=name;
        }

        public override string ToString()
        {
            return "Head: " + head + ". Token: " + token + ". Email: " + email + ". Name: " + name;
        }
    }
}
