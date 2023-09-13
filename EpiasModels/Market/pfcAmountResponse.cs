using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.75. Primer Frekans Rezerv Miktarı
    /// </summary>
    public class pfcAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Frequencyreservepricelist[] frequencyReservePriceList { get; set; }
        }

        public class Frequencyreservepricelist
        {
            public DateTime effectiveDate { get; set; }
            public int hour { get; set; }
            public double? totalAmount { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/pfc-amount?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
