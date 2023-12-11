using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class Admin
    {
        public string Username { get; set; }
        public string Head { get; set; }
        public string Token { get; set; }

        public Admin(in string head, in string token, in string nom)
        {
            Username = nom;
            Head = head;
            Token = token;
        }

        public override string ToString()
        {
            return "Head: " + Head + "\nToken: " + Token + "\nUsername: " + Username;
        }
    }
}
