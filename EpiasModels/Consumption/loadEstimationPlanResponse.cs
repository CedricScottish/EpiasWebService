using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.18. Yük Tahmin Planı
    /// </summary>
    public class loadEstimationPlanResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Loadestimationplanlist[] loadEstimationPlanList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Loadestimationplanlist
        {
            public DateTime date { get; set; }
            public int lep { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? lepAvg { get; set; }
            public int lepMin { get; set; }
            public int lepMax { get; set; }
            public int lepSum { get; set; }
        }



        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/load-estimation-plan?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }






}
