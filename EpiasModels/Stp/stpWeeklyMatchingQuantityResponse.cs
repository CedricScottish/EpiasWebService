using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.141. Haftalık Eşleşme Miktarı Servisi
    /// </summary>
    public class stpWeeklyMatchingQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Stpweeklymatchlist[] stpWeeklyMatchList { get; set; }
            public Statistic statistic { get; set; }
        }

        public class Statistic
        {
            public int hiemMin { get; set; }
            public int hiemMax { get; set; }
            public int hiemSum { get; set; }
            public int hiemAvg { get; set; }
            public int hsemMin { get; set; }
            public int hsemMax { get; set; }
            public int hsemSum { get; set; }
            public int hsemAvg { get; set; }
            public int htemMin { get; set; }
            public int htemMax { get; set; }
            public int htemSum { get; set; }
            public int htemAvg { get; set; }
            public int emTotalMin { get; set; }
            public int emTotalMax { get; set; }
            public int emTotalSum { get; set; }
            public int emTotalAvg { get; set; }
        }

        public class Stpweeklymatchlist
        {
            public string week { get; set; }
            public int hiem { get; set; }
            public int hsem { get; set; }
            public int htem { get; set; }
            public int emTotal { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/matching-quantity/stp-weekly-matching-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }




}
