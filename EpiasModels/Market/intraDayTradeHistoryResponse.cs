using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.66. GİP Eşleşme Bilgisi Rest Servisi
    /// </summary>
    public class intraDayTradeHistoryResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Intradaytradehistorylist[] intraDayTradeHistoryList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Intradaytradehistorylist
        {
            public long id { get; set; }
            public DateTime date { get; set; }
            public string conract { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double priceWeightedAverage { get; set; }
            public int priceMin { get; set; }
            public int priceMax { get; set; }
            public int quantityMin { get; set; }
            public int quantityMax { get; set; }
            public int quantitySum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-trade-history?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }




}
