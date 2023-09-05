using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.22. Gerçek Zamanlı Tüketim Rest Servisi
    /// </summary>
    public class realConsumptionResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Hourlyconsumption[] hourlyConsumptions { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Hourlyconsumption
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double consumption { get; set; }
            public string periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double consumptionAvg { get; set; }
            public double consumptionMin { get; set; }
            public double consumptionMax { get; set; }
            public double consumptionSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/real-time-consumption_with_period?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + "&period=" + period.ToString();
        }


    }
}
