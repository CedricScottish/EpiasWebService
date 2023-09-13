using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.63. Güniçi Piyasası Teklif Edilen ve Eşleşme Fiyatlarının minimum ve maksimum değerleri
    /// </summary>
    public class intraDayMinMaxPriceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Minmaxpricelist[] minMaxPriceList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Minmaxpricelist
        {
            public DateTime date { get; set; }
            public int minAskPrice { get; set; }
            public double? maxAskPrice { get; set; }
            public double? minBidPrice { get; set; }
            public int maxBidPrice { get; set; }
            public double? minMatchPrice { get; set; }
            public double? maxMatchPrice { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int minAskPriceMin { get; set; }
            public int minAskPriceMax { get; set; }
            public double? maxAskPriceMin { get; set; }
            public int maxAskPriceMax { get; set; }
            public int minBidPriceMin { get; set; }
            public double? minBidPriceMax { get; set; }
            public int maxBidPriceMin { get; set; }
            public int maxBidPriceMax { get; set; }
            public int minMatchPriceMin { get; set; }
            public int minMatchPriceMax { get; set; }
            public double? maxMatchPriceMin { get; set; }
            public int maxMatchPriceMax { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate, definitionValues.offerType offerType)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-income-summary?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + "&offerType=" + offerType.ToString();
        }


    }

}
