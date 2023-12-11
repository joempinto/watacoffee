using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Head { get; set; }
        public string Token { get; set; }

        public User(in string head, in string token, in string nom, in string email)
        {
            Username = nom;
            Email = email;
            Head = head;
            Token = token;
        }

        public override string ToString()
        {
            return "Head: " + Head + "\nToken: " + Token + "\nEmail: " + Email + "\nUsername: " + Username;
        }

    }
}
