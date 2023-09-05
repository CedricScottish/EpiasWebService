using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.65. Gün İçi Piyasası Özet Servisi
    /// </summary>
    public class intraDaySummaryResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Intradaysummarylist[] intraDaySummaryList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Intradaysummarylist
        {
            public long id { get; set; }
            public DateTime date { get; set; }
            public string contract { get; set; }
            public double? volume { get; set; }
            public double minAskPrice { get; set; }
            public double maxAskPrice { get; set; }
            public double? minBidPrice { get; set; }
            public double? maxBidPrice { get; set; }
            public double quantityOfAsk { get; set; }
            public double? quantityOfBid { get; set; }
            public double? tradingVolume { get; set; }
            public double? minMatchPrice { get; set; }
            public double? maxMatchPrice { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double volumeAvg { get; set; }
            public double volumeMin { get; set; }
            public double volumeMax { get; set; }
            public double volumeSum { get; set; }
            public int minAskPriceMin { get; set; }
            public int minAskPriceMax { get; set; }
            public int maxAskPriceMin { get; set; }
            public int maxAskPriceMax { get; set; }
            public int minBidPriceMin { get; set; }
            public int minBidPriceMax { get; set; }
            public int maxBidPriceMin { get; set; }
            public int maxBidPriceMax { get; set; }
            public double quantityOfAskAvg { get; set; }
            public double quantityOfAskMin { get; set; }
            public double quantityOfAskMax { get; set; }
            public double quantityOfAskSum { get; set; }
            public double quantityOfBidAvg { get; set; }
            public double quantityOfBidMin { get; set; }
            public double quantityOfBidMax { get; set; }
            public double quantityOfBidSum { get; set; }
            public double tradingVolumeAvg { get; set; }
            public int tradingVolumeMin { get; set; }
            public double tradingVolumeMax { get; set; }
            public double tradingVolumeSum { get; set; }
            public int minMatchPriceMin { get; set; }
            public int minMatchPriceMax { get; set; }
            public double maxMatchPriceMin { get; set; }
            public int maxMatchPriceMax { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate, definitionValues.offerType? offerType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-summary?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (offerType != null)
            {
                strReturn += "&offerType=" + offerType.ToString();
            }
            return strReturn;
        }

    }



}
