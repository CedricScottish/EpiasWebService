using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{

    /// <summary>
    /// 1.103. YEKDEM Dengesizlik Maliyeti Rest Servisi
    /// </summary>
    public class renewableSMImbalanceCostResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Renewablesmimbalancecostlist[] renewableSMImbalanceCostList { get; set; }
        }

        public class Renewablesmimbalancecostlist
        {
            public DateTime date { get; set; }
            public object imbalanceCost { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/renewable-sm-imbalance-cost?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }


}
