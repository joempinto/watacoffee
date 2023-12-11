using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC_1.old.logout;

namespace WPC_1.helpers
{
    public class RequestHelper
    {

        public string getUserAuthorization(string head, string token)
        {
            string header = String.Concat(head, token);
            // LogoutInfo logoutAdmin = new LogoutInfo(header);
            data.UserAuthorization auth = new data.UserAuthorization(header);
            return header;
        }



    }
}
