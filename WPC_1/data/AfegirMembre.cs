using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public struct AfegirMembre
    {
        public int groupId { get; set; }
        public string nickname { get; set; }
        public string? username { get; set; }

        public AfegirMembre(in int id, in string nickname, in string? username)
        {
            this.groupId = id;
            this.nickname = nickname;
            this.username = username;
        }

    }
}
