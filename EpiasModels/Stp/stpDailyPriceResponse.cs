using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.132. STP Günlük Fiyat Servisi
    /// </summary>
    public class stpDailyPriceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Stpdailypricedto[] stpDailyPriceDtos { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public double intraDayPriceMin { get; set; }
            public double intraDayPriceMax { get; set; }
            public double dayAfterPriceMin { get; set; }
            public double dayAfterPriceMax { get; set; }
            public double dayAheadPriceMin { get; set; }
            public double dayAheadPriceMax { get; set; }
            public double weightedAverageMin { get; set; }
            public double weightedAverageMax { get; set; }
            public double gasReferencePriceMin { get; set; }
            public int gasReferencePriceMax { get; set; }
        }

        public class Stpdailypricedto
        {
            public DateTime gasDay { get; set; }
            public string contractName { get; set; }
            public double? intraDayPrice { get; set; }
            public double dayAfterPrice { get; set; }
            public double dayAheadPrice { get; set; }
            public double weightedAverage { get; set; }
            public double gasReferencePrice { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/daily-price?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }


}
