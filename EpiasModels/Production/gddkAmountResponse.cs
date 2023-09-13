using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.91. GDDK Tutarı Rest Servisi
    /// </summary>
    public class gddkAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Gddkamountlist[] gddkAmountList { get; set; }
        }

        public class Gddkamountlist
        {
            public Id id { get; set; }
            public double? gddkDebtAmount { get; set; }
            public double? gddkCreditAmount { get; set; }
            public double? gddkNetAmount { get; set; }
        }

        public class Id
        {
            public DateTime date { get; set; }
            public DateTime version { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/gddk-amount?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
