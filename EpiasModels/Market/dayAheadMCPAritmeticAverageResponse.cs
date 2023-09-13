using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.72. GÖP Takas Fiyatı Aritmetik Ortalama Rest Servisi
    /// </summary>
    public class dayAheadMCPAritmeticAverageResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Dayaheadmcplist[] dayAheadMCPList { get; set; }
            public object[] statistics { get; set; }
        }

        public class Dayaheadmcplist
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double? averageMcp { get; set; }
            public string periodType { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/mcp-average?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();
            }
            return strReturn;
        }





    }


}
