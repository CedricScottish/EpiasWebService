using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.139. Günlük Eşleşme Miktarı Servisi
    /// </summary>
    public class stpDailyMatchingQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Stpgifgeftradeamount[] stpGifGefTradeAmounts { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int intraDayTradeValueMin { get; set; }
            public int intraDayTradeValueMax { get; set; }
            public int intraDayTradeValueSum { get; set; }
            public int intraDayTradeValueAvg { get; set; }
            public int intraDayMatchingQuantityMin { get; set; }
            public int intraDayMatchingQuantityMax { get; set; }
            public int intraDayMatchingQuantitySum { get; set; }
            public int intraDayMatchingQuantityAvg { get; set; }
            public int dayAfterTradeValueMin { get; set; }
            public int dayAfterTradeValueMax { get; set; }
            public int dayAfterTradeValueSum { get; set; }
            public int dayAfterTradeValueAvg { get; set; }
            public int dayAfterMatchingQuantityMin { get; set; }
            public int dayAfterMatchingQuantityMax { get; set; }
            public int dayAfterMatchingQuantitySum { get; set; }
            public int dayAfterMatchingQuantityAvg { get; set; }
            public int dayAheadTradeValueMin { get; set; }
            public int dayAheadTradeValueMax { get; set; }
            public int dayAheadTradeValueSum { get; set; }
            public int dayAheadTradeValueAvg { get; set; }
            public int dayAheadMatchingQuantityMin { get; set; }
            public int dayAheadMatchingQuantityMax { get; set; }
            public int dayAheadMatchingQuantitySum { get; set; }
            public int dayAheadMatchingQuantityAvg { get; set; }
            public int gasReferenceMatchingQuantityMin { get; set; }
            public int gasReferenceMatchingQuantityMax { get; set; }
            public int gasReferenceMatchingQuantitySum { get; set; }
            public int gasReferenceMatchingQuantityAvg { get; set; }
            public int gasReferenceTradeValueMin { get; set; }
            public int gasReferenceTradeValueMax { get; set; }
            public int gasReferenceTradeValueSum { get; set; }
            public int gasReferenceTradeValueAvg { get; set; }
        }

        public class Stpgifgeftradeamount
        {
            public DateTime gasDay { get; set; }
            public string contractName { get; set; }
            public int intraDayTradeValue { get; set; }
            public int intraDayMatchingQuantity { get; set; }
            public int dayAfterTradeValue { get; set; }
            public int dayAfterMatchingQuantity { get; set; }
            public int dayAheadTradeValue { get; set; }
            public int dayAheadMatchingQuantity { get; set; }
            public double weightedAverage { get; set; }
            public int gasReferenceMatchingQuantity { get; set; }
            public int gasReferenceTradeValue { get; set; }
            public object intraDayPrice { get; set; }
            public double dayAfterPrice { get; set; }
            public double dayAheadPrice { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/matching-quantity/stp-daily-matching-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }






}
