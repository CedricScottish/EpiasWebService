using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.41. İkili Anlaşma Alış Rest Servisi
    /// </summary>
    public class bilateralContractBuyResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Bilateralcontractbuylist[] bilateralContractBuyList { get; set; }
        }

        public class Bilateralcontractbuylist
        {
            public DateTime date { get; set; }
            public double quantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? eic)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/bilateral-contract-buy?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
            if (eic != null)
            {
                strReturn += "&eic=" + eic;
            }
            return strReturn;
        }


    }
}
