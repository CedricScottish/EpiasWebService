using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.55. Esnek Alış Satış Teklif Miktarları
    /// </summary>
    public class damFlexibleOfferWithBuySellInfoResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Getdamflexibleoffer[] getDamFlexibleOffer { get; set; }
        }

        public class Getdamflexibleoffer
        {
            public DateTime day { get; set; }
            public int totalBuyingFlexibleOfferQuantity { get; set; }
            public int matchedBuyingFlexibleOfferQuantity { get; set; }
            public int unmatchedBuyingFlexibleOfferQuantity { get; set; }
            public double? totalSellingFlexibleOfferQuantity { get; set; }
            public int matchedSellingFlexibleOfferQuantity { get; set; }
            public double? unmatchedSellingFlexibleOfferQuantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/flexible-offer-amount?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }
}
