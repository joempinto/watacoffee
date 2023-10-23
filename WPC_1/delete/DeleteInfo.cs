using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.delete
{
    internal class DeleteInfo
    {
        public string Authorization { get; set; }

        public DeleteInfo(string authorization)
        {
            this.Authorization = authorization;
        }
    }
}
