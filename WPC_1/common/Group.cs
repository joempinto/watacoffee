using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1
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
        public string numMembers { get; set; }

        public GroupLlista(string groupName, string numMembers)
        {
            this.groupName = groupName;
            this.numMembers = numMembers;
        }

        public override string ToString()
        {
            return "\nName: " + groupName+ " Num. Participants: " + numMembers;
        }
    }
}
