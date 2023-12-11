using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class PagamentInfoResponse
    {
        public double amount { get; set; }
        public string paymentDate { get; set; }

        public PagamentInfoResponse(double amount, string paymentDate)
        {
            this.amount = amount;
            this.paymentDate = paymentDate;
        }
    }
}
