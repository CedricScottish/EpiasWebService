using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Transmission
{
    /// <summary>
    /// 1.156. Nomine Kapasite Servisi
    /// </summary>
    public class nominalCapacityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Nominalcapacitiylist[] nominalCapacitiyList { get; set; }
        }

        public class Nominalcapacitiylist
        {
            public DateTime date { get; set; }
            public int bidQuantity { get; set; }
            public int offerQuantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/transmission/nominal-capacity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }




}
