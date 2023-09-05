using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{
    /// <summary>
    /// 1.165. VEP Eşleşme Miktarı
    /// </summary>
    public class vepMatchingQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Datalist[] dataList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Datalist
        {
            public DateTime date { get; set; }
            public string contractName { get; set; }
            public int marketMatchingQuantity { get; set; }
            public int privateOperationQuantity { get; set; }
            public int dailyIndexPriceBiddingQuantity { get; set; }
            public int basePriceBiddingQuantity { get; set; }
            public int defaultBiddingQuantity { get; set; }
            public int syntheticBuyMatchingQuantity { get; set; }
            public int syntheticSellMatchingQuantity { get; set; }
            public int total { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int marketMatchingQuantityMin { get; set; }
            public int marketMatchingQuantityMax { get; set; }
            public double marketMatchingQuantityAvg { get; set; }
            public int marketMatchingQuantitySum { get; set; }
            public int privateOperationQuantityMin { get; set; }
            public int privateOperationQuantityMax { get; set; }
            public double privateOperationQuantityAvg { get; set; }
            public int privateOperationQuantitySum { get; set; }
            public int dailyIndexPriceBiddingQuantityMin { get; set; }
            public int dailyIndexPriceBiddingQuantityMax { get; set; }
            public double dailyIndexPriceBiddingQuantityAvg { get; set; }
            public int dailyIndexPriceBiddingQuantitySum { get; set; }
            public int basePriceBiddingQuantityMin { get; set; }
            public int basePriceBiddingQuantityMax { get; set; }
            public double basePriceBiddingQuantityAvg { get; set; }
            public int basePriceBiddingQuantitySum { get; set; }
            public int defaultBiddingQuantityMin { get; set; }
            public int defaultBiddingQuantityMax { get; set; }
            public double defaultBiddingQuantityAvg { get; set; }
            public int defaultBiddingQuantitySum { get; set; }
            public int syntheticBuyMatchingQuantityMin { get; set; }
            public int syntheticBuyMatchingQuantityMax { get; set; }
            public double syntheticBuyMatchingQuantityAvg { get; set; }
            public int syntheticBuyMatchingQuantitySum { get; set; }
            public int syntheticSellMatchingQuantityMin { get; set; }
            public int syntheticSellMatchingQuantityMax { get; set; }
            public double syntheticSellMatchingQuantityAvg { get; set; }
            public int syntheticSellMatchingQuantitySum { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate, string? deliveryPeriod, string? year, string? loadType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/matching-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (deliveryPeriod != null)
            {
                strReturn += "&deliveryPeriod=" + deliveryPeriod.ToString();
            }

            if (year != null)
            {
                strReturn += "&year=" + year.ToString();
            }

            if (loadType != null)
            {
                strReturn += "&loadType=" + loadType.ToString();
            }

            return strReturn;
        }

    }


}
