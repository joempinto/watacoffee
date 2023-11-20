using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WPC_1
{   
    public struct AddNewMembre
    {        
        public int groupId { get; set; }
        public string nickname { get; set; }
        public string? username { get; set; }

        public AddNewMembre(in int id, in string nickname,in string? username)
        {
            this.groupId = id;
            this.nickname = nickname;
            this.username = username;
        }

    }
}
