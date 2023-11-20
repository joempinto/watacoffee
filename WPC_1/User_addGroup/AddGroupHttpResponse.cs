using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.User_addGroup
{
    internal class AddGroupHttpResponse
    {
        public int id { get; set; }
        public string name { get; set; }

        public AddGroupHttpResponse(int id, string name)
        {
            this.id = id;
            this.name = name;            
        }

        public override string ToString()
        {
            return id + name;
        }
    }
}
