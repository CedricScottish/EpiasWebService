using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.48. Gün Öncesi Piyasası Eşleşme Miktar Rest Servisi
    /// </summary>
    public class dayAheadMarketVolumeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Dayaheadmarketvolumelist[] dayAheadMarketVolumeList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Dayaheadmarketvolumelist
        {
            public DateTime date { get; set; }
            public double? quantityOfAsk { get; set; }
            public double? volume { get; set; }
            public double? quantityOfBid { get; set; }
            public double? priceIndependentBid { get; set; }
            public double? priceIndependentOffer { get; set; }
            public double? blockBid { get; set; }
            public double? blockOffer { get; set; }
            public double? matchedBids { get; set; }
            public double? matchedOffers { get; set; }
            public int period { get; set; }
            public object? periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? quantityOfAskAvg { get; set; }
            public double? quantityOfAskMin { get; set; }
            public double? quantityOfAskMax { get; set; }
            public double? quantityOfAskSum { get; set; }
            public double? quantityOfBidAvg { get; set; }
            public double? quantityOfBidMin { get; set; }
            public double? quantityOfBidMax { get; set; }
            public double? quantityOfBidSum { get; set; }
            public double? priceIndependentBidAvg { get; set; }
            public double? priceIndependentBidMin { get; set; }
            public double? priceIndependentBidMax { get; set; }
            public double? priceIndependentBidSum { get; set; }
            public double? priceIndependentOfferAvg { get; set; }
            public double? priceIndependentOfferMin { get; set; }
            public double? priceIndependentOfferMax { get; set; }
            public double? priceIndependentOfferSum { get; set; }
            public double? blockBidAvg { get; set; }
            public double? blockBidMin { get; set; }
            public double? blockBidMax { get; set; }
            public double? blockBidSum { get; set; }
            public double? blockOfferAvg { get; set; }
            public double? blockOfferMin { get; set; }
            public double? blockOfferMax { get; set; }
            public double? blockOfferSum { get; set; }
            public double? matchedBidsAvg { get; set; }
            public double? matchedBidsMin { get; set; }
            public double? matchedBidsMax { get; set; }
            public double? matchedBidsSum { get; set; }
            public double? volumeAvg { get; set; }
            public double? volumeMin { get; set; }
            public double? volumeMax { get; set; }
            public double? volumeSum { get; set; }
            public double? matchedOffersAvg { get; set; }
            public double? matchedOffersMin { get; set; }
            public double? matchedOffersMax { get; set; }
            public double? matchedOffersSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period, string? eic)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/day-ahead-market-volume?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
            
            if (period != null)
            {
                strReturn += "&period=" + period.ToString();

            }

            if (eic != null)
            {
                strReturn += "&eic=" + eic.ToString();
            }

            return strReturn;
        }




    }

}
