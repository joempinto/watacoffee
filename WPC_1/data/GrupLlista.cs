using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class GrupLlista
    {
        public string groupName { get; set; }
        public int numMembers { get; set; }

        public GrupLlista(string groupName, int numMembers)
        {
            this.groupName = groupName;
            this.numMembers = numMembers;
        }

        public override string ToString()
        {
            return "\nName: " + groupName + " Num. Participants: " + numMembers;
        }
    }
}
