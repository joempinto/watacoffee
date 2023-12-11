using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class GrupPagamentInfoResponse
    {
        public string nickname { get; set; }
        public double amount { get; set; }  
        public string? date { get; set; }
        public Boolean member {  get; set; }


        public GrupPagamentInfoResponse(string nickname, double amount, string date, Boolean member)
        {
            this.nickname = nickname;
            this.amount = amount;
            this.date = date;
            this.member = member;
        }
    }
}
