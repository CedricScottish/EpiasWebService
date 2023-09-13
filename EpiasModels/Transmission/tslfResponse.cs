using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Transmission
{
    /// <summary>
    /// 1.158. ISKK Rest Servisi
    /// </summary>
    public class tslfResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Transmissionsystemlossfactorlist[] transmissionSystemLossFactorList { get; set; }
        }

        public class Transmissionsystemlossfactorlist
        {
            public DateTime date { get; set; }
            public double? firstVersionValue { get; set; }
            public double? lastVersionValue { get; set; }
            public DateTime firstVersionDate { get; set; }
            public DateTime lastVersionDate { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/stp/trade-value?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge.ToString();
            }
            return strReturn;

        }

    }

}
