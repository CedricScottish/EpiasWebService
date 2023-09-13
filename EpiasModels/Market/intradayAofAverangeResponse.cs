using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.60. GİP AOF Aritmetik Ortalama Rest Servisi
    /// </summary>
    public class intradayAofAverangeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Idmaoflist[] idmAofList { get; set; }
            public object[] statistics { get; set; }
        }

        public class Idmaoflist
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double? aof { get; set; }
            public string periodType { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-aof-average?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();

            }
            return strReturn;
        }


    }


}
