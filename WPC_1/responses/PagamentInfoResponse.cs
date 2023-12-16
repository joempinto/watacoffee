using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class PagamentInfoResponse //PaymentData
    {
        public int paymentId {  get; set; }
        public double amount { get; set; }
        public string paymentDate { get; set; }

        public PagamentInfoResponse(int paymentId, double amount, string paymentDate)
        {
            this.paymentId = paymentId;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }
    }
}
