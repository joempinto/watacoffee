using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class MembresLlista
    {
        public int groupId { get; set; }
        public int userId { get; set; }
        public string nickname { get; set; }
        public string username { get; set; }
        public bool admin { get; set; }

        public MembresLlista(int groupId, int userId, string nickname, string username, bool admin)
        {
            this.groupId = groupId;
            this.userId = userId;
            this.nickname = nickname;
            this.username = username;
            this.admin = admin;
        }

        public override string ToString()
        {
            return "IDgroup: " + groupId + "\nIDuser: " + userId + "\nNickname: " + nickname + "\nUsername: " + username + "\nAdmin: " + admin;
        }

    }
}
