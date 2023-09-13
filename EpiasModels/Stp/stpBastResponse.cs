using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.153. Bakiye sıfırlama tutarı servisi
    /// </summary>
    public class stpBastResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Zerobalance[] zeroBalances { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public double? zeroBalanceSum { get; set; }
            public double? zeroBalanceMin { get; set; }
            public double? zeroBalanceMax { get; set; }
        }

        public class Zerobalance
        {
            public DateTime gasDay { get; set; }
            public double? zeroBalance { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/zero-balance?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }
    }




}
