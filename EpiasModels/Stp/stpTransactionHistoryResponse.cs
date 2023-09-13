using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.148. İşlem akışı servisi
    /// </summary>
    public class stpTransactionHistoryResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Transactionhistory[] transactionHistories { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int priceMin { get; set; }
            public double? priceMax { get; set; }
            public double? priceAvg { get; set; }
            public int quantityMin { get; set; }
            public int quantityMax { get; set; }
            public int quantitySum { get; set; }
            public double? quantityAvg { get; set; }
        }

        public class Transactionhistory
        {
            public string id { get; set; }
            public string contractName { get; set; }
            public DateTime mathcingDate { get; set; }
            public double? price { get; set; }
            public int quantity { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/transaction-history?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }


}
