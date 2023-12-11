/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.old.register
{
    internal class RegisterHttpResponse
    {
        public string Head { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }



        public RegisterHttpResponse(string head, string token, string email, string username)
        {
            Head = head;
            Token = token;
            Email = email;
            Username = username;
        }

        public override string ToString()
        {
            return Head + Token + Email + Username;
        }
    }
}
