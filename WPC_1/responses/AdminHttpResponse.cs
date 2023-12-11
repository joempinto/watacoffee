using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class AdminHttpResponse
    {
        public string Token { get; set; }
        public string Head { get; set; }
        public string Username { get; set; }
        public AdminHttpResponse(string head, string token, string username)
        {
            this.Token = token;
            this.Head = head;
            this.Username = username;
        }

        public override string ToString()
        {
            return "Head: " + Head + ". Token: " + Token + ". Username: " + Username;
        }
    }
}
