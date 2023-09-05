using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vgp
{
    /// <summary>
    /// 1.172. VGP Günlük Gösterge Fiyatı
    /// </summary>
    public class vgpGGFResponse
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
            public double price { get; set; }
            public double priceUsd { get; set; }
            public double priceEur { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double ggfTLMin { get; set; }
            public double ggfTLMax { get; set; }
            public double ggfTLAvg { get; set; }
            public double ggfTLSum { get; set; }
            public double ggfUSDMin { get; set; }
            public double ggfUSDMax { get; set; }
            public double ggfUSDAvg { get; set; }
            public double ggfUSDSum { get; set; }
            public double ggfEURMin { get; set; }
            public double ggfEURMax { get; set; }
            public double ggfEURAvg { get; set; }
            public double ggfEURSum { get; set; }
        }



        public string getURL(DateTime? startDate, DateTime? endDate, string? deliveryPeriod, string? year)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vgp/ggf";
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
