using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Transmission
{
    /// <summary>
    /// 1.154. Kısıt Maliyet Rest Servisi
    /// </summary>
    public class congestionRentResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Congestionrentlist[] congestionRentList { get; set; }
        }

        public class Congestionrentlist
        {
            public int cityId { get; set; }
            public string cityName { get; set; }
            public double? mcpCost { get; set; }
            public double? smpCost { get; set; }
            public int orderCount { get; set; }
            public int upRegulationOrderCount { get; set; }
            public double? downRegulationOrderCount { get; set; }
            public double? totalOrderCount { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge, definitionValues.orderType? orderType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/stp/trade-value?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge.ToString();
            }

            if (orderType != null)
            {
                strReturn += "&orderType=" + orderType.ToString();
            }

            return strReturn;
        }



    }






}
