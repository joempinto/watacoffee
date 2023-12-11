using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class GrupLlistaTipus
    {
        public int id { get; set; }
        public string name { get; set; }

        public GrupLlistaTipus(string name, int id)
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
