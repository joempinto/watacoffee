/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WPC_1
{
    internal class User
    {
        public string Username{ get; set; }
        public string Email { get; set; }
        public string Head { get; set; }
        public string Token { get; set; }

        public User(in string head, in string token, in string nom, in string email)
        {
            this.Username = nom;
            this.Email = email;           
            this.Head = head;
            this.Token = token;
        }

        public override string ToString()
        {
            return "Head: " + Head + "\nToken: " + Token + "\nEmail: " + Email + "\nUsername: " + Username;
        }

    }

    internal class Admin
    {
        public string Username { get; set; }        
        public string Head { get; set; }
        public string Token { get; set; }

        public Admin(in string head, in string token, in string nom)
        {
            this.Username = nom;
            this.Head = head;
            this.Token = token;
        }

        public override string ToString()
        {
            return "Head: " + Head + "\nToken: " + Token + "\nUsername: " + Username;
        }
    }

    internal class UserLlista
    {
        public string username { get; set; }
        public string email { get; set; }

        public UserLlista(string username, string email)
        {
            this.username = username;
            this.email = email;
        }

        public override string ToString()
        {
            return "\nEmail: " + email + "\nName: " + username;
        }
    }

    internal class MembresLlista
    {
        public int groupId { get; set; }
        public string nickname { get; set; }
        public string username { get; set; }
        public Boolean admin { get; set; }

        public MembresLlista(int groupId, string nickname, string username, Boolean admin)
        {
            this.groupId = groupId;
            this.nickname = nickname;
            this.username = username;
            this.admin = admin;
        }

        public override string ToString()
        {
            return "IDgroup: " + groupId + "\nNickname: " + nickname + "\nUsername: " + username + "\nAdmin: " + admin;
        }

    }
}
