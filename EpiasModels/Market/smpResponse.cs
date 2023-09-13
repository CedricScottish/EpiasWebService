using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.79. SMF Rest Servisi
    /// </summary>
    public class smpResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Smplist[] smpList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Smplist
        {
            public DateTime date { get; set; }
            public double? price { get; set; }
            public string smpDirection { get; set; }
            public int smpDirectionId { get; set; }
            public DateTime nextHour { get; set; }
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

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/smp?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge;
            }
            return strReturn;
        }


    }


}
