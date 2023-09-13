using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{


    /// <summary>
    /// 1.49. GÖP Eşleşme Miktarı Toplam Rest Servisi
    /// </summary>
    public class damVolumeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Volume[] volumes { get; set; }
            public object[] statistics { get; set; }
        }

        public class Volume
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double? volume { get; set; }
            public string? periodType { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/day-ahead-market-volume-summary?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();

            }
            return strReturn;
        }


    }

}
