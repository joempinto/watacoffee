using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class UserAuthorization
    {
        public string Authorization { get; set; }

        public UserAuthorization(string authorization)
        {
            Authorization = authorization;
        }
    }
}
