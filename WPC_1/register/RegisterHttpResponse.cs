using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.register
{
    internal class RegisterHttpResponse
    {
        public string Head { get; set; }
        public string Token { get; set; }
        public string Email { get; set; } 
        public string Name { get; set; }



        public RegisterHttpResponse(string head, string token, string email, string name)
        {
            Head = head;
            Token = token;
            Email = email;
            Name = name;         
        }

        public override string ToString()
        {
            return Head + Token + Email + Name;
        }
    }
}
