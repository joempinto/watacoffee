using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1.old.common
{
    internal class Group
    {
        public string memberName { get; set; }
        public string groupName { get; set; }

        public Group(in string memberName, in string groupName)
        {
            this.memberName = memberName;
            this.groupName = groupName;
        }
    }

    internal class GroupLlista
    {
        public string groupName { get; set; }
        public int numMembers { get; set; }

        public GroupLlista(string groupName, int numMembers)
        {
            this.groupName = groupName;
            this.numMembers = numMembers;
        }

        public override string ToString()
        {
            return "\nName: " + groupName + " Num. Participants: " + numMembers;
        }
    }

    internal class GroupLlistaTipus
    {
        public int id { get; set; }
        public string name { get; set; }


        public GroupLlistaTipus(string name, int id)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "\nid: " + id + " Nom Grup: " + name;
        }
    }
}
