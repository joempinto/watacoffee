using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.common
{
    
    internal class AddPayment
    {
        public float amount { get; set; }
        public string paymentDate { get; set; }
        public int groupId { get; set; }
        public int memberId { get; set; }        

        public AddPayment(float amount, string paymentDate, int groupId, int memberId)
        {
            this.amount = amount;
            this.paymentDate = paymentDate;
            this.groupId = groupId;
            this.memberId = memberId;            
        }
    }
}
