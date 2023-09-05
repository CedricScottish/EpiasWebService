using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.128. Tahsisat verileri servisi
    /// </summary>
    public class stpAllowanceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Allowance[] allowances { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public double inputDataPyhsicalMin { get; set; }
            public double inputDataPyhsicalMax { get; set; }
            public double inputDataPyhsicalSum { get; set; }
            public int inputDataVirtualMin { get; set; }
            public int inputDataVirtualMax { get; set; }
            public int inputDataVirtualSum { get; set; }
            public double outputDataPyhsicalMin { get; set; }
            public double outputDataPyhsicalMax { get; set; }
            public double outputDataPyhsicalSum { get; set; }
            public int outputDataVirtualMin { get; set; }
            public int outputDataVirtualMax { get; set; }
            public int outputDataVirtualSum { get; set; }
            public double negativeImbalanceMin { get; set; }
            public double negativeImbalanceMax { get; set; }
            public double negativeImbalanceSum { get; set; }
            public double positiveImbalanceMin { get; set; }
            public double positiveImbalanceMax { get; set; }
            public double positiveImbalanceSum { get; set; }
            public double negativeImbalanceTradeValueMin { get; set; }
            public double negativeImbalanceTradeValueMax { get; set; }
            public double negativeImbalanceTradeValueSum { get; set; }
            public double positiveImbalanceTradeValueMin { get; set; }
            public double positiveImbalanceTradeValueMax { get; set; }
            public double positiveImbalanceTradeValueSum { get; set; }
        }

        public class Allowance
        {
            public DateTime gasDay { get; set; }
            public string type { get; set; }
            public double inputDataPyhsical { get; set; }
            public int inputDataVirtual { get; set; }
            public double outputDataPyhsical { get; set; }
            public int outputDataVirtual { get; set; }
            public double negativeImbalance { get; set; }
            public double positiveImbalance { get; set; }
            public double negativeImbalanceTradeValue { get; set; }
            public double positiveImbalanceTradeValue { get; set; }
            public string systemDirection { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/allowance?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }

}
