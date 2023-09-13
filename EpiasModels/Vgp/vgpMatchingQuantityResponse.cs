using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vgp
{
    /// <summary>
    /// 1.173. VGP Eşleşme Miktarı
    /// </summary>
    public class vgpMatchingQuantityResponse
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
            public int marketMatchingQuantity { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int marketMatchingQuantityMin { get; set; }
            public int marketMatchingQuantityMax { get; set; }
            public double? marketMatchingQuantityAvg { get; set; }
            public int marketMatchingQuantitySum { get; set; }
        }

        public string getURL(DateTime? startDate, DateTime? endDate, string? deliveryPeriod, string? year)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vgp/matching-quantity";
            string strQuery = "?";

            if (startDate != null)
            {
                strQuery += "startDate=" + startDate.Value.ToString("yyyy-MM-dd");
            }

            if (endDate != null)
            {
                if (strQuery.Length > 1)
                {
                    strQuery += "&endDate=" + endDate.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    strQuery += "endDate=" + endDate.Value.ToString("yyyy-MM-dd");
                }

            }

            if (deliveryPeriod != null)
            {
                if (strQuery.Length > 1)
                {
                    strQuery += "&deliveryPeriod=" + deliveryPeriod.ToString();
                }
                else
                {
                    strQuery += "deliveryPeriod=" + deliveryPeriod.ToString();
                }

            }

            if (year != null)
            {
                if (strQuery.Length > 1)
                {
                    strQuery += "&year=" + year.ToString();
                }
                else
                {
                    strQuery += "year=" + year.ToString();
                }
            }

            if (strQuery.Length > 1)
            {
                strReturn += strQuery.ToString();
            }
            return strReturn;
        }


    }



}
