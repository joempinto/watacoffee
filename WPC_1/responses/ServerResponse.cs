using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class ServerResponse
    {
        public string status { get; set; }
        public string message { get; set; }

        public ServerResponse(string status, string message)
        {
            this.status = status;
            this.message = message;
        }
    }
}
