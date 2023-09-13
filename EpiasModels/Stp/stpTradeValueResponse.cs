using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.147. STP GRF Ticaret Miktar Servisi
    /// </summary>
    public class stpTradeValueResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Tradevalue[] tradeValues { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int intraDayTradeValueMin { get; set; }
            public int intraDayTradeValueMax { get; set; }
            public int intraDayTradeValueSum { get; set; }
            public double? intraDayTradeValueAvg { get; set; }
            public int dayAfterTradeValueMin { get; set; }
            public int dayAfterTradeValueMax { get; set; }
            public int dayAfterTradeValueSum { get; set; }
            public double? dayAfterTradeValueAvg { get; set; }
            public int dayAheadTradeValueMin { get; set; }
            public int dayAheadTradeValueMax { get; set; }
            public int dayAheadTradeValueSum { get; set; }
            public double? dayAheadTradeValueAvg { get; set; }
            public int gasReferenceTradeValueMin { get; set; }
            public int gasReferenceTradeValueMax { get; set; }
            public int gasReferenceTradeValueSum { get; set; }
            public double? gasReferenceTradeValueAvg { get; set; }
            public int contractTradeValueMin { get; set; }
            public int contractTradeValueMax { get; set; }
            public int contractTradeValueSum { get; set; }
            public double? contractTradeValueAvg { get; set; }
        }

        public class Tradevalue
        {
            public DateTime gasDay { get; set; }
            public string contractName { get; set; }
            public int intraDayTradeValue { get; set; }
            public int dayAfterTradeValue { get; set; }
            public int dayAheadTradeValue { get; set; }
            public int gasReferenceTradeValue { get; set; }
            public int contractTradeValue { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/trade-value?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }




}
