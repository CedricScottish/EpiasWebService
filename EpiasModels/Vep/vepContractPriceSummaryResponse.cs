using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{
    /// <summary>
    /// 1.163. VEP Kontrat Fiyatları Özet Servisi
    /// </summary>
    public class vepContractPriceSummaryResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Datalist[] dataList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Datalist
        {
            public DateTime date { get; set; }
            public string contractName { get; set; }
            public int firstMatchingPrice { get; set; }
            public int maxMatchingPrice { get; set; }
            public int minMatchingPrice { get; set; }
            public int latestMatchingPrice { get; set; }
            public double? dipPrice { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int firstMatchingPriceMin { get; set; }
            public int firstMatchingPriceMax { get; set; }
            public double firstMatchingPriceAvg { get; set; }
            public int firstMatchingPriceSum { get; set; }
            public int maxMatchingPriceMin { get; set; }
            public int maxMatchingPriceMax { get; set; }
            public double maxMatchingPriceAvg { get; set; }
            public int maxMatchingPriceSum { get; set; }
            public int minMatchingPriceMin { get; set; }
            public int minMatchingPriceMax { get; set; }
            public double minMatchingPriceAvg { get; set; }
            public int minMatchingPriceSum { get; set; }
            public int latestMatchingPriceMin { get; set; }
            public int latestMatchingPriceMax { get; set; }
            public double latestMatchingPriceAvg { get; set; }
            public int latestMatchingPriceSum { get; set; }
            public double dipPriceMin { get; set; }
            public double dipPriceMax { get; set; }
            public double dipPriceAvg { get; set; }
            public double dipPriceSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? deliveryPeriod, string? year, string? loadType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/contract-price-summary?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (deliveryPeriod != null)
            {
                strReturn += "&deliveryPeriod=" + deliveryPeriod.ToString();
            }

            if (year != null)
            {
                strReturn += "&year=" + year.ToString();
            }

            if (loadType != null)
            {
                strReturn += "&loadType=" + loadType.ToString();
            }

            return strReturn;
        }

    }


}
