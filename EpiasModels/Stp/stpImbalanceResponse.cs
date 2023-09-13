using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{

    /// <summary>
    /// 1.136. STP Aylık Dengesizlik Miktarları Servisi
    /// </summary>
    public class stpImbalanceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Imbalance[] imbalances { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public double? negativeImbalanceMin { get; set; }
            public double? negativeImbalanceMax { get; set; }
            public double? negativeImbalanceSum { get; set; }
            public double? positiveImbalanceMin { get; set; }
            public double? positiveImbalanceMax { get; set; }
            public double? positiveImbalanceSum { get; set; }
            public double? negativeImbalanceTradeValueMin { get; set; }
            public double? negativeImbalanceTradeValueMax { get; set; }
            public double? negativeImbalanceTradeValueSum { get; set; }
            public double? positiveImbalanceTradeValueMin { get; set; }
            public double? positiveImbalanceTradeValueMax { get; set; }
            public double? positiveImbalanceTradeValueSum { get; set; }
        }

        public class Imbalance
        {
            public DateTime period { get; set; }
            public string type { get; set; }
            public double? negativeImbalance { get; set; }
            public double? positiveImbalance { get; set; }
            public double? negativeImbalanceTradeValue { get; set; }
            public double? positiveImbalanceTradeValue { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/imbalance-monthly?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }






    }



}
