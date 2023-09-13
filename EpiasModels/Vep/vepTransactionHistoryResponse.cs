using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{

    /// <summary>
    /// 1.167. VEP İşlem Geçmişi
    /// </summary>
    public class vepTransactionHistoryResponse
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
            public DateTime matchTime { get; set; }
            public string contractName { get; set; }
            public string transactionType { get; set; }
            public int matchingPrice { get; set; }
            public int matchingQuantity { get; set; }
            public int total { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int matchingPriceMin { get; set; }
            public int matchingPriceMax { get; set; }
            public double? matchingPriceAvg { get; set; }
            public int matchingPriceSum { get; set; }
            public int matchingQuantityMin { get; set; }
            public int matchingQuantityMax { get; set; }
            public double? matchingQuantityAvg { get; set; }
            public int matchingQuantitySum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? deliveryPeriod, string? year, string? loadType)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/transaction-history?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

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
