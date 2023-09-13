using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.39. İkili Anlaşma Rest Servisi
    /// </summary>
    public class bilateralContractResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Bilateralcontractlist[] bilateralContractList { get; set; }
        }

        public class Bilateralcontractlist
        {
            public DateTime date { get; set; }
            public double? quantity { get; set; }
            public DateTime nextHour { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/bilateral-contract?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }
}
