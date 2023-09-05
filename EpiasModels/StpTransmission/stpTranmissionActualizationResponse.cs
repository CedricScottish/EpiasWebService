using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.StpTransmission
{

    /// <summary>
    /// 1.121. Stok Miktarı Servisi
    /// </summary>
    public class stpTranmissionActualizationResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Actualization[] actualizations { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Actualization
        {
            public DateTime gasDay { get; set; }
            public int pipeStock { get; set; }
        }

        public class Statistic
        {
            public DateTime gasDay { get; set; }
            public int pipeStockAvg { get; set; }
            public int pipeStockMin { get; set; }
            public int pipeStockMax { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp-transmission/actualization?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }




    }


}
