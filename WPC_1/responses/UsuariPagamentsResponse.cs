using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{
    public class UsuariPagamentsResponse<PagamentInfoResponse>
    {
        public string nickname { get; set; }
        public List<PagamentInfoResponse> paymentData { get; set; }

        public UsuariPagamentsResponse(string nickname, in List<PagamentInfoResponse> paymentData)
        {
            this.nickname = nickname;
            this.paymentData = paymentData;
        }
    }
}
