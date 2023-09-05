using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.40. İkili Anlaşma Alış-Satış Servisi
    /// </summary>
    public class bilateralContractAllResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Bilateralcontract[] bilateralContracts { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Bilateralcontract
        {
            public DateTime date { get; set; }
            public double quantityBid { get; set; }
            public double quantityBidAsk { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double quantityBidAvg { get; set; }
            public double quantityBidMin { get; set; }
            public double quantityBidMax { get; set; }
            public double quantityBidSum { get; set; }
            public double quantityBidAskAvg { get; set; }
            public double quantityBidAskMin { get; set; }
            public double quantityBidAskMax { get; set; }
            public double quantityBidAskSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? eic)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/bilateral-contract-all?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
            if (eic != null)
            {
                strReturn += "&eic=" + eic;
            }
            return strReturn;
        }


    }
}
