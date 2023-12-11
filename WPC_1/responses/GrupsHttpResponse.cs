using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{   
    public class GrupsHttpResponse<GrupLlista>
    {
        public List<GrupLlista> Group { get; set; }

        public GrupsHttpResponse(in List<GrupLlista> group)
        {
            this.Group = group;
        }
    }
}
