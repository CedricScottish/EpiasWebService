using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.152. Haftalık İşlem Hacmi Servisi
    /// </summary>
    public class stpWeeklyVolumeResponse
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
            public int hiihMin { get; set; }
            public int hiihMax { get; set; }
            public int hiihSum { get; set; }
            public double hiihAvg { get; set; }
            public int hsihMin { get; set; }
            public int hsihMax { get; set; }
            public int hsihSum { get; set; }
            public double hsihAvg { get; set; }
            public int htihMin { get; set; }
            public int htihMax { get; set; }
            public int htihSum { get; set; }
            public double htihAvg { get; set; }
            public int ihTotalMin { get; set; }
            public int ihTotalMax { get; set; }
            public int ihTotalSum { get; set; }
            public double ihTotalAvg { get; set; }
        }

        public class Stpweeklymatchlist
        {
            public string week { get; set; }
            public int hiih { get; set; }
            public int hsih { get; set; }
            public int htih { get; set; }
            public int ihTotal { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/volume/stp-weekly-volume?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
