using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.146. Haftalık Referans Fiyatı Servisi
    /// </summary>
    public class stpWeeklyReferencePriceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Weeklyrefpricelist[] weeklyRefPriceList { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int weekdayPriceMin { get; set; }
            public int weekdayPriceMax { get; set; }
            public int weekendPriceMin { get; set; }
            public int weekendPriceMax { get; set; }
            public int weekTotalPriceMin { get; set; }
            public int weekTotalPriceMax { get; set; }
            public object weeklyRefPriceMin { get; set; }
            public object weeklyRefPriceMax { get; set; }
        }

        public class Weeklyrefpricelist
        {
            public string week { get; set; }
            public int weekdayPrice { get; set; }
            public int weekendPrice { get; set; }
            public int weekTotalPrice { get; set; }
            public object weeklyRefPrice { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/stp-weekly-reference-price?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }




    }


}
