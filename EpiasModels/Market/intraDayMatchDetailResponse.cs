using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.67. Güniçi Piyasası Saatlik Eşleşme Miktar Servisi
    /// 1.69. Güniçi Piyasası Saatlik Eşleşme Miktar Servisi
    /// </summary>
    public class intraDayMatchDetailResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Matchdetail[] matchDetails { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Matchdetail
        {
            public DateTime date { get; set; }
            public double blockMatchQuantity { get; set; }
            public double hourlyMatchQuantity { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double avgBlockMatchQuantity { get; set; }
            public double avgHourlyMatchQuantity { get; set; }
            public double minBlockMatchQuantity { get; set; }
            public int minHourlyMatchQuantity { get; set; }
            public double maxBlockMatchQuantity { get; set; }
            public double maxHourlyMatchQuantity { get; set; }
            public double sumBlockMatchQuantity { get; set; }
            public double sumHourlyMatchQuantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-volume?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

        public string getURLv2(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-volume-v2?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }





}
