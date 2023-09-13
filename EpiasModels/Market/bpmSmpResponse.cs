using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.80. DGP Sistem Marjinal Fiyatı Aritmetik Ortalama Rest Servisi
    /// </summary>
    public class bpmSmpResponse
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
            public DateTime date { get; set; }
            public int period { get; set; }
            public double? averageSmp { get; set; }
            public string periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? min { get; set; }
            public double? max { get; set; }
            public double? average { get; set; }
            public double? weightedAverage { get; set; }
            public object summary { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/eligible-consumer-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + "&period=" + period.ToString();
        }





    }


}
