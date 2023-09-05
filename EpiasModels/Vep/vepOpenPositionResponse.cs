using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{
    /// <summary>
    /// 1.166. VEP Açık Pozisyon Servisi
    /// </summary>
    public class vepOpenPositionResponse
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
            public DateTime date { get; set; }
            public string contractName { get; set; }
            public int openPosition { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int openPositionMin { get; set; }
            public int openPositionMax { get; set; }
            public double openPositionAvg { get; set; }
            public int openPositionSum { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate, string? deliveryPeriod, string? year, string? loadType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/open-position?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (deliveryPeriod != null)
            {
                strReturn += "&deliveryPeriod=" + deliveryPeriod.ToString();
            }

            if (year != null)
            {
                strReturn += "&year=" + year.ToString();
            }

            if (loadType != null)
            {
                strReturn += "&loadType=" + loadType.ToString();
            }

            return strReturn;
        }




    }

}
