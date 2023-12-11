using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{    
    public class UsuarisHttpResponse<UserLlista>
    {
        public List<UserLlista> User { get; set; }

        public UsuarisHttpResponse(in List<UserLlista> user)
        {
            this.User = user;
        }
    }
}
