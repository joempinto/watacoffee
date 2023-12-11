using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{

    public class UsuariHttpResponse
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string Head { get; set; }
        public string Name { get; set; }
        public UsuariHttpResponse(string head, string token, string email, string name)
        {
            this.Email = email;
            this.Token = token;
            this.Head = head;
            this.Name = name;
        }

        public override string ToString()
        {
            return "Head: " + Head + ". Token: " + Token + ". Email: " + Email + ". Name: " + Name;
        }
    }
}
