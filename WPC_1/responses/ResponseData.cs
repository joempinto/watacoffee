using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_1.responses
{    
    static class ResponseData
    {
        //basiques
        public static GrupMembreTotalPagamentResponse? grupTotalPerMembre = null;
        public static GrupPagamentInfoResponse? grupPayInfo = null;
        public static PagamentInfoResponse? paymentData = null;

        //llistat de les anteriors
        public static List<GrupMembreTotalPagamentResponse>? listGrupTotals = null;
        public static List<GrupPagamentInfoResponse>? listGrupPayInfo = null;
        public static List<PagamentInfoResponse>? listPaymentData = null;

        //aquesta està composada per un nickname i un 'listPaymentData'
        public static UsuariPagamentsResponse<PagamentInfoResponse>? listUserPayments = null;

    }
}
