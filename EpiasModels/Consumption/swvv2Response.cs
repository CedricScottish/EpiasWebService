using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.26. Serbest Tüketici Çekiş Rest Servisi
    /// 1.27. Serbest Tüketici Çekiş Rest Servisi
    /// </summary>
    public class swvv2Response
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Swvv2list[] swvV2List { get; set; }
        }

        public class Swvv2list
        {
            public DateTime vcGecTrh { get; set; }
            public double? st { get; set; }
        }

        public string getURLSwv2(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/swv-v2?period=" + period.ToString("yyyy-MM-dd");
        }
        public string getURLSwv3(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/swv-v2?period=" + period.ToString("yyyy-MM-dd");
        }




    }

}
