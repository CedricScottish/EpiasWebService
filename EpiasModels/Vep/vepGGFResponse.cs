using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{
    /// <summary>
    /// 1.164. VEP Günlük Gösterge Fiyatı
    /// </summary>
    public class vepGGFResponse
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

        public string getURL(DateTime startDate, DateTime endDate, string? deliveryPeriod, string? year, string? loadType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/ggf?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

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
