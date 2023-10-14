using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1
{
    internal struct LoginHttpResponse
    {
        private string Email {  get; set; } //Capital 'E' due server response variables names
        private string Token { get; set; }
        private string Prefix { get; set; }

        public LoginHttpResponse(in string email, in string token,in string prefix)
        {
            this.Email = email;
            this.Token = token;
            this.Prefix = prefix;   
        }

        public static implicit operator Task<object>(LoginHttpResponse v)
        {
            throw new NotImplementedException();
        }
    }
}
