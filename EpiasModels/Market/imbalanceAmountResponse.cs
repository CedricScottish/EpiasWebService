using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.57. Dengesizlik Tutar Rest Servisi
    /// </summary>
    public class imbalanceAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Imbalanceamountlist[] imbalanceAmountList { get; set; }
        }

        public class Imbalanceamountlist
        {
            public DateTime date { get; set; }
            public string time { get; set; }
            public double positiveImbalance { get; set; }
            public double negativeImbalance { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/imbalance-amount?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge;

            }
            return strReturn;
        }


    }


}
