using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.140. Toplam Eşleşme Miktarı Servisi
    /// </summary>
    public class stpTotalMatchingQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Totalmatchingquantity[] totalMatchingQuantity { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Totalmatchingquantity
        {
            public DateTime gasDay { get; set; }
            public int tradeVolume { get; set; }
            public int totalMatchAmount { get; set; }
            public int period { get; set; }
            public object periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime gasDay { get; set; }
            public int tradeVolumeMin { get; set; }
            public int tradeVolumeMax { get; set; }
            public int tradeVolumeSum { get; set; }
            public double tradeVolumeAvg { get; set; }
            public int totalMatchAmountMin { get; set; }
            public int totalMatchAmountMax { get; set; }
            public int totalMatchAmountSum { get; set; }
            public double totalMatchAmountAvg { get; set; }
        }



        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/stp/matching-quantity/stp-total-matching-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();
            }

            return strReturn;
        }






    }



}
