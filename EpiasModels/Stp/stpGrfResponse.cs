using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.145. STP Fiyat Servisi
    /// </summary>
    public class stpGrfResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Price[] prices { get; set; }
        }

        public class Price
        {
            public DateTime gasDay { get; set; }
            public double? price { get; set; }
            public string priceType { get; set; }
            public string state { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate, definitionValues.priceType? priceType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/stp/price?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (priceType != null)
            {
                strReturn += "&priceType=" + priceType.ToString();
            }

            return strReturn;
        }


    }


}
