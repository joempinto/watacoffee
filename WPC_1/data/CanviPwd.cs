using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.data
{
    public class ChangePwd
    {
        public string Password { get; set; }

        public ChangePwd(string password)
        {
            Password = password;
        }
    }
}
