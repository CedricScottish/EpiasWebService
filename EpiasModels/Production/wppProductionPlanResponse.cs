using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{

    /// <summary>
    /// 1.120. Res Üretim Tahmini Servisi
    /// </summary>
    public class wppProductionPlanResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Datum[] data { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Datum
        {
            public DateTime effectiveDate { get; set; }
            public double quarter1 { get; set; }
            public double quarter2 { get; set; }
            public double quarter3 { get; set; }
            public double quarter4 { get; set; }
            public double generation { get; set; }
            public double forecast { get; set; }
            public object createIp { get; set; }
            public object modifyIp { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double quarter1Avg { get; set; }
            public int quarter1Min { get; set; }
            public double quarter1Max { get; set; }
            public double quarter1Sum { get; set; }
            public double quarter2Avg { get; set; }
            public double quarter2Min { get; set; }
            public double quarter2Max { get; set; }
            public double quarter2Sum { get; set; }
            public double quarter3Avg { get; set; }
            public double quarter3Min { get; set; }
            public double quarter3Max { get; set; }
            public double quarter3Sum { get; set; }
            public double quarter4Avg { get; set; }
            public double quarter4Min { get; set; }
            public double quarter4Max { get; set; }
            public double quarter4Sum { get; set; }
            public double generationAvg { get; set; }
            public double generationMin { get; set; }
            public double generationMax { get; set; }
            public double generationSum { get; set; }
            public double forecastAvg { get; set; }
            public double forecastMin { get; set; }
            public double forecastMax { get; set; }
            public double forecastSum { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/wpp-generation-and-forecast?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }




    }




}
