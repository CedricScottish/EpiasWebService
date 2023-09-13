using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels
{

    /// <summary>
    /// 1.7. Günlük Karşılaştırma Servisi
    /// </summary>
    public class marketCompareDailyResponse
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
            public DateTime date { get; set; }
            public double? mcpAvg { get; set; }
            public double? smpAvg { get; set; }
            public int idmAofAvg { get; set; }
            public double? matchingQuantityAvg { get; set; }
            public double? bilateralContractsAvg { get; set; }
            public double? idmMatchingQuantitySum { get; set; }
        }


        public string getURL(DateTime date)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/compare/market/daily?date=" + date.ToString("yyyy-MM-dd");
        }

    }

}
