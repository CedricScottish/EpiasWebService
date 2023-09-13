using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.142. STP Mobil Fiyat Servisi
    /// </summary>
    public class stpMobilePriceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Price[] prices { get; set; }
        }

        public class Price
        {
            public DateTime gasDay { get; set; }
            public int imbalance { get; set; }
            public double? gasReferencePrice { get; set; }
            public double? balancingGasPurchase { get; set; }
            public double? balancingGasSale { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/mobile/price?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }
}
