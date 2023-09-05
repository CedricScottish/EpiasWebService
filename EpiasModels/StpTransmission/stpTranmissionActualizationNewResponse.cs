using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.StpTransmission
{

    /// <summary>
    /// 1.122. Fiili Gerçekleşme
    /// </summary>
    public class stpTranmissionActualizationNewResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Actualizationlist[] actualizationList { get; set; }
            public DateTime latestUpdate { get; set; }
        }

        public class Actualizationlist
        {
            public int id { get; set; }
            public DateTime relatedDate { get; set; }
            public int input { get; set; }
            public int output { get; set; }
            public int pipeStock { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp-transmission/actualization-input-output?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
