using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Yekg
{
    /// <summary>
    /// 1.184. YEK-G Min-Max Eşleşme Fiyatları
    /// </summary>
    public class minMaxMatchAmountResponse
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
            public Id id { get; set; }
            public double? minMatchPrice { get; set; }
            public double? maxMatchPrice { get; set; }
        }

        public class Id
        {
            public DateTime date { get; set; }
            public string resourceType { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? minMatchPriceAvg { get; set; }
            public double? minMatchPriceMin { get; set; }
            public double? minMatchPriceMax { get; set; }
            public double? minMatchPriceSum { get; set; }
            public double? maxMatchPriceAvg { get; set; }
            public double? maxMatchPriceMin { get; set; }
            public double? maxMatchPriceMax { get; set; }
            public double? maxMatchPriceSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/yekg/min-max-match-amount-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }




}
