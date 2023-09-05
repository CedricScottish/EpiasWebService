using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.44. GÖP Fark Tutarı Rest Servisi
    /// </summary>
    public class diffFundsResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Difffundlist[] diffFundList { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int originatingFromBidsAvg { get; set; }
            public int originatingFromBidsMin { get; set; }
            public int originatingFromBidsMax { get; set; }
            public int originatingFromBidsSum { get; set; }
            public double originatingFromOffersAvg { get; set; }
            public double originatingFromOffersMin { get; set; }
            public double originatingFromOffersMax { get; set; }
            public double originatingFromOffersSum { get; set; }
            public double originatingFromRoundingAvg { get; set; }
            public double originatingFromRoundingMin { get; set; }
            public double originatingFromRoundingMax { get; set; }
            public double originatingFromRoundingSum { get; set; }
            public double totalAvg { get; set; }
            public double totalMin { get; set; }
            public double totalMax { get; set; }
            public double totalSum { get; set; }
        }

        public class Difffundlist
        {
            public DateTime date { get; set; }
            public int originatingFromBids { get; set; }
            public double originatingFromOffers { get; set; }
            public double originatingFromRounding { get; set; }
            public double total { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/day-ahead-diff-funds?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge;
            }
            return strReturn;
        }

    }
}
