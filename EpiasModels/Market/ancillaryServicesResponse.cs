using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.37. Butun yan hizmetler servisi
    /// </summary>
    public class ancillaryServicesResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Ancillaryservicesdtolist[] ancillaryServicesDTOList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Ancillaryservicesdtolist
        {
            public DateTime effectiveDate { get; set; }
            public int hour { get; set; }
            public string pfcPrice { get; set; }
            public string pfcAmount { get; set; }
            public string sfcPrice { get; set; }
            public string sfcAmount { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double pfcPriceAvg { get; set; }
            public double pfcPriceMin { get; set; }
            public double pfcPriceMax { get; set; }
            public double pfcPriceSum { get; set; }
            public double pfcAmountAvg { get; set; }
            public double pfcAmountMin { get; set; }
            public double pfcAmountMax { get; set; }
            public double pfcAmountSum { get; set; }
            public double sfcPriceAvg { get; set; }
            public double sfcPriceMin { get; set; }
            public double sfcPriceMax { get; set; }
            public double sfcPriceSum { get; set; }
            public double sfcAmountAvg { get; set; }
            public double sfcAmountMin { get; set; }
            public double sfcAmountMax { get; set; }
            public double sfcAmountSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/ancillary-services-all?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }

}
