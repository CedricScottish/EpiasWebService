using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EpiasModels.Compare
{

    /// <summary>
    /// 1.6. Karşılaştırma Rest Servisi
    /// </summary>
    public class marketCompareResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Marketcompare[] marketCompares { get; set; }
        }

        public class Marketcompare
        {
            public int period { get; set; }
            public DateTime date { get; set; }
            public double? mcpAvg { get; set; }
            public double? smpAvg { get; set; }
            public double? maxMcp { get; set; }
            public double? minMcp { get; set; }
            public double? dayTimeMcp { get; set; }
            public double? peakTimeMcp { get; set; }
            public double? nightTimeMcp { get; set; }
            public double? priceIndependentBid { get; set; }
            public double? priceIndependentOffer { get; set; }
            public double? matchingQuantity { get; set; }
            public double? bilateralContracts { get; set; }
            public double? idmMatchingQuantity { get; set; }
            public double? consumptionAvg { get; set; }
            public double? consumptionSum { get; set; }
            public double? idmAof { get; set; }
        }


        public string getURL(DateTime date, definitionValues.type type)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/compare/market?date=" + date.ToString("yyyy-MM-dd") + @"&type=" + type.ToString();
        }

    }






}
