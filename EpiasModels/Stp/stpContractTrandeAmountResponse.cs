using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.131. Kontrat işlem hacim ve miktar bilgisi servisi
    /// </summary>
    public class stpContractTrandeAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Contracttradeamount[] contractTradeAmounts { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Contracttradeamount
        {
            public DateTime gasDay { get; set; }
            public double? tradeValue { get; set; }
            public int matchingQuantity { get; set; }
            public int period { get; set; }
            public string periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime gasDay { get; set; }
            public int tradeValueMin { get; set; }
            public int tradeValueMax { get; set; }
            public double? tradeValueAvg { get; set; }
            public double? tradeValueSum { get; set; }
            public int matchingQuantityMin { get; set; }
            public int matchingQuantityMax { get; set; }
            public double? matchingQuantityAvg { get; set; }
            public int matchingQuantitySum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/contract-amount?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + "&period=" + period.ToString();
        }





    }

}
