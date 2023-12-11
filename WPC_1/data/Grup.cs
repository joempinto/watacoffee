using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class Grup
    {
        public string memberName { get; set; }
        public string groupName { get; set; }

        public Grup(in string memberName, in string groupName)
        {
            this.memberName = memberName;
            this.groupName = groupName;
        }
    }
}
