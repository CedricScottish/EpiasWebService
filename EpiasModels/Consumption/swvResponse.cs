using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.25. Uzlaştırmaya Esas Çekiş Miktarı
    /// </summary>
    public class swvResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Swvlist[] swvList { get; set; }
            public Statistic statistic { get; set; }
        }

        public class Statistic
        {
            public double swvMin { get; set; }
            public double swvMax { get; set; }
            public double swvAvg { get; set; }
            public double swvSum { get; set; }
        }

        public class Swvlist
        {
            public DateTime date { get; set; }
            public double swv { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/consumption/swv??startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge.ToString();
            }

            return strReturn;
        }


    }

}
