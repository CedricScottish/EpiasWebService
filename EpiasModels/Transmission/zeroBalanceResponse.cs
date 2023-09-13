using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Transmission
{
    /// <summary>
    /// 1.159. Sıfır Bakiye Servisi
    /// </summary>
    public class zeroBalanceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Zerobalance[] zeroBalances { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Zerobalance
        {
            public DateTime date { get; set; }
            public double? zeroBalanceAdjustment { get; set; }
            public double? downRegulation { get; set; }
            public double? upRegulation { get; set; }
            public object manual { get; set; }
            public double? negativeImbalance { get; set; }
            public int renewableImbalance { get; set; }
            public double? kupst { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? totalAvg { get; set; }
            public double? downRegulationAvg { get; set; }
            public double? upRegulationAvg { get; set; }
            public int manuelAvg { get; set; }
            public double? energtImbalanceCostAvg { get; set; }
            public int renewablesEnergyImbalanceCostAvg { get; set; }
            public double? kupstAvg { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/transmission/zero-balance?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
