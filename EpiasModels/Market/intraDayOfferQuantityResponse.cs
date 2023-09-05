using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.64. Güniçi Piyasası Teklif Edilen Miktar(Saatlik)
    /// </summary>
    public class intraDayOfferQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Offerquantity[] offerQuantities { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Offerquantity
        {
            public DateTime effectiveDate { get; set; }
            public double hourlyPurchaseQuantity { get; set; }
            public double hourlySaleQuantity { get; set; }
            public double blockPurchaseQuantity { get; set; }
            public double blockSaleQuantity { get; set; }
        }

        public class Statistic
        {
            public DateTime effectiveDate { get; set; }
            public double hourlyPurchaseQuantityMin { get; set; }
            public double hourlyPurchaseQuantityMax { get; set; }
            public double hourlyPurchaseQuantityAvg { get; set; }
            public double hourlyPurchaseQuantitySum { get; set; }
            public double hourlySaleQuantityMin { get; set; }
            public double hourlySaleQuantityMax { get; set; }
            public double hourlySaleQuantityAvg { get; set; }
            public double hourlySaleQuantitySum { get; set; }
            public double blockPurchaseQuantityMin { get; set; }
            public double blockPurchaseQuantityMax { get; set; }
            public double blockPurchaseQuantityAvg { get; set; }
            public double blockPurchaseQuantitySum { get; set; }
            public double blockSaleQuantityMin { get; set; }
            public double blockSaleQuantityMax { get; set; }
            public double blockSaleQuantityAvg { get; set; }
            public double blockSaleQuantitySum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }

}
