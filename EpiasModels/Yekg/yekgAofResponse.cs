using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Yekg
{
    /// <summary>
    /// 1.179. Org. YEK-G Piyasa Ağırlıklı Ortalama Fiyat
    /// </summary>
    public class yekgAofResponse
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
            public double? aofTl { get; set; }
            public double? aofUsd { get; set; }
            public double? aofEur { get; set; }
        }

        public class Id
        {
            public DateTime date { get; set; }
            public string resourceType { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? aofTlAvg { get; set; }
            public double? aofTlMin { get; set; }
            public double? aofTlMax { get; set; }
            public double? aofTlSum { get; set; }
            public double? aofUsdAvg { get; set; }
            public double? aofUsdMin { get; set; }
            public double? aofUsdMax { get; set; }
            public double? aofUsdSum { get; set; }
            public double? aofEurAvg { get; set; }
            public double? aofEurMin { get; set; }
            public double? aofEurMax { get; set; }
            public double? aofEurSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/yekg/aof?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }



}
