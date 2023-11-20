/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPC_1.login;
using WPC_1.register;
using WPC_1.delete;
using WPC_1.logout;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace WPC_1.login
{
    internal class LoginHttpResponse
    {
        public string Email { get; set; } 
        public string Token { get; set; }
        public string Head { get; set; }
        public string Name { get; set; }
        public LoginHttpResponse(string head, string token, string email, string name)
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
    internal class LoginHttpResponseAdmin
    {        
        public string Token { get; set; }
        public string Head { get; set; }
        public string Username { get; set; }
        public LoginHttpResponseAdmin(string head, string token, string username)
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

    public class LoginHttpResponseArrayUsers<UserLlista>
    {
        public List<UserLlista> User { get; set; }

        public LoginHttpResponseArrayUsers(in List<UserLlista> user)
        {
            this.User= user;
        }
    }

    public class LoginHttpResponseArrayGroups<GroupLlista>
    {
        public List<GroupLlista> Group { get; set; }

        public LoginHttpResponseArrayGroups(in List<GroupLlista> group)
        {
            this.Group = group;
        }
    }
}
