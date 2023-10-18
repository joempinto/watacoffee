using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1
{
    internal class User
    {
        public string nom { get; set; }
        public string email { get; set; }
        public string head { get; set; }
        public string token { get; set; }

        public User(in string head, in string token, in string nom, in string email)
        {
            this.nom = nom;
            this.email = email;           
            this.head = head;
            this.token = token;
        }
        
    }
}
