using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.113. Yekdem Rest Servisi
    /// </summary>
    public class renewablesSupportResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Renewablessupport[] renewablesSupports { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Renewablessupport
        {
            public DateTime period { get; set; }
            public double? unitCost { get; set; }
            public double? reneablesCost { get; set; }
            public double? renewablesTotalCost { get; set; }
            public double? licenseExemptCost { get; set; }
            public double? portfolioIncome { get; set; }
        }

        public class Statistic
        {
            public DateTime period { get; set; }
            public double? unitCostAvg { get; set; }
            public double? unitCostMin { get; set; }
            public double? unitCostMax { get; set; }
            public double? reneablesCostAvg { get; set; }
            public double? reneablesCostMin { get; set; }
            public double? reneablesCostMax { get; set; }
            public double? renewablesTotalCostAvg { get; set; }
            public double? renewablesTotalCostMin { get; set; }
            public double? renewablesTotalCostMax { get; set; }
            public double? licenseExemptCostAvg { get; set; }
            public double? licenseExemptCostMin { get; set; }
            public double? licenseExemptCostMax { get; set; }
            public double? portfolioIncomeAvg { get; set; }
            public double? portfolioIncomeMin { get; set; }
            public double? portfolioIncomeMax { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/renewables-support?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }





    }






}
