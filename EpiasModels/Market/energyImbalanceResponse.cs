using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.53. Enerji Dengesizlik Rest Servisi
    /// 1.54. AylıkEnerji Dengesizlik Rest Servisi
    /// </summary>
    public class energyImbalanceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Energyimbalance[] energyImbalances { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Energyimbalance
        {
            public DateTime date { get; set; }
            public double? positiveImbalance { get; set; }
            public double? negativeImbalance { get; set; }
            public double? positiveImbalanceIncome { get; set; }
            public double? negativeImbalanceIncome { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? positiveImbalanceAvg { get; set; }
            public double? positiveImbalanceMin { get; set; }
            public double? positiveImbalanceMax { get; set; }
            public double? positiveImbalanceSum { get; set; }
            public double? negativeImbalanceAvg { get; set; }
            public double? negativeImbalanceMin { get; set; }
            public double? negativeImbalanceMax { get; set; }
            public double? negativeImbalanceSum { get; set; }
            public double? positiveImbalanceIncomeAvg { get; set; }
            public double? positiveImbalanceIncomeMin { get; set; }
            public double? positiveImbalanceIncomeMax { get; set; }
            public double? positiveImbalanceIncomeSum { get; set; }
            public double? negativeImbalanceIncomeAvg { get; set; }
            public double? negativeImbalanceIncomeMin { get; set; }
            public double? negativeImbalanceIncomeMax { get; set; }
            public double? negativeImbalanceIncomeSum { get; set; }
        }

        public string getURLHourly(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/energy-imbalance-hourly?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

        public string getURLMonthly(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/energy-imbalance-monthly?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
