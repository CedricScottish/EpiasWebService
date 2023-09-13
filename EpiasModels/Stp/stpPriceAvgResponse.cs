using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.135. Günlük referans fiyat servisi
    /// </summary>
    public class stpPriceAvgResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Price[] prices { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Price
        {
            public DateTime gasDay { get; set; }
            public double? price { get; set; }
            public int period { get; set; }
            public string periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime gasDay { get; set; }
            public double? avgPrice { get; set; }
            public double? minPrice { get; set; }
            public double? maxPrice { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/grf?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + "&period=" + period.ToString();
        }




    }


}
