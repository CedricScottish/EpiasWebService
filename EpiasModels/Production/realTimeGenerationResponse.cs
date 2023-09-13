using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.99. Gerçek Zamanlı Üretim Rest Servisi Santral Kırılımlı
    /// 1.100. Gerçek Zamanlı Üretim Rest Servisi Santral Kırılımlı
    /// </summary>
    public class realTimeGenerationResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Realtimegeneration[] realTimeGenerations { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Realtimegeneration
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double? generation { get; set; }
            public object periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? generationAvg { get; set; }
            public double? generationMin { get; set; }
            public double? generationMax { get; set; }
            public double? generationSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.source source, definitionValues.period? period, int? powerPlantId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/real-time-generation_with_powerplant_and_period?startDate=" + startDate.ToString("yyyy-MM-dd") + @"&endDate=" + endDate.ToString("yyyy-MM-dd") + @"&source=" + source.ToString();

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();
            }

            if (powerPlantId != null)
            {
                strReturn += "&powerPlantId=" + powerPlantId.ToString();
            }
            return strReturn;
        }

        public string getURLv2(DateTime startDate, DateTime endDate, definitionValues.source source, definitionValues.period? period, int? powerPlantId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/real-time-generation_with_powerplant_and_period-v2?startDate=" + startDate.ToString("yyyy-MM-dd") + @"&endDate=" + endDate.ToString("yyyy-MM-dd") + @"&source=" + source.ToString();

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();
            }

            if (powerPlantId != null)
            {
                strReturn += "&powerPlantId=" + powerPlantId.ToString();
            }
            return strReturn;
        }




    }
}
