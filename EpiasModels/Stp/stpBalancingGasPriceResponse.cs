using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.129. STP Dengeleyici Gaz Fiyatları Servisi
    /// </summary>
    public class stpBalancingGasPriceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Price[] prices { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int additionalBalancingPurchaseMin { get; set; }
            public int additionalBalancingPurchaseMax { get; set; }
            public object additionalBalancingSaleMin { get; set; }
            public object additionalBalancingSaleMax { get; set; }
            public double balancingGasPurchaseMin { get; set; }
            public double balancingGasPurchaseMax { get; set; }
            public double balancingGasSaleMin { get; set; }
            public double balancingGasSaleMax { get; set; }
        }

        public class Price
        {
            public DateTime gasDay { get; set; }
            public int additionalBalancingPurchase { get; set; }
            public bool finalAbp { get; set; }
            public object additionalBalancingSale { get; set; }
            public bool finalAbs { get; set; }
            public double balancingGasPurchase { get; set; }
            public bool finalBgp { get; set; }
            public double balancingGasSale { get; set; }
            public bool finalBgs { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/balancing-gas-price?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }





    }




}
