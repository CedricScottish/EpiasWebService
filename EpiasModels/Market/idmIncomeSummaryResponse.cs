using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.62. GİP İşlem Tutarı Toplam Rest Servisi
    /// </summary>
    public class idmIncomeSummaryResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Income[] incomes { get; set; }
            public object[] statistics { get; set; }
        }

        public class Income
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double income { get; set; }
            public string periodType { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-income-summary?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();

            }
            return strReturn;
        }



    }

}
