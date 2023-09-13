using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.38. Azami Uzlaştırma Fiyatı (AUF) Rest Servisi
    /// </summary>
    public class aufResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Auflist[] aufList { get; set; }
        }

        public class Auflist
        {
            public DateTime period { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public int gopAzamiFiyat { get; set; }
            public double? dogalGaz { get; set; }
            public double? ithalKomur { get; set; }
            public double? yerliKomur { get; set; }
            public double? diger { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/auf?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }


}
