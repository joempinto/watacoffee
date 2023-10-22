using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1.logout
{
    internal class LogoutInfo //maybe public struct
    {
        public string Authorization {  get; set; }        

        public LogoutInfo(string authorization)
        {
            this.Authorization = authorization;            
        }

        /*public string CreateHeader(string head, string token)
        {
            return (string.Concat(head, token));
        }*/
    }
}
