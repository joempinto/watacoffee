using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class GrupMembreTotalPagamentResponse
    {
        public string nickname { get; set; }
        public int memberId { get; set; }
        public double totalAmount { get; set; }


        public GrupMembreTotalPagamentResponse(string nickname, int memberId, double totalAmount)
        {            
            this.nickname = nickname;
            this.memberId = memberId;
            this.totalAmount = totalAmount;
        }
    }
}
