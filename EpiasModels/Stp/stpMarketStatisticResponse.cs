using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.149. STP Piyasa İstatistikleri Servisi
    /// </summary>
    public class stpMarketStatisticResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Marketstatistic[] marketStatistics { get; set; }
        }

        public class Marketstatistic
        {
            public DateTime gasDay { get; set; }
            public string contractName { get; set; }
            public int lastMatchPrice { get; set; }
            public double weightedAveragePrice { get; set; }
            public int totalQuantity { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/transaction-history/market-statistic";
        }

    }


}
