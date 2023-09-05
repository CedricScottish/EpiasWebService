using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.71. Elektrik Piyasalarının Hacim Bilgisi Rest Servisi
    /// </summary>
    public class marketVolumeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Marketvolumelist[] marketVolumeList { get; set; }
            public Statistic[] statistics { get; set; }
            public Ratio[] ratios { get; set; }
        }

        public class Marketvolumelist
        {
            public DateTime date { get; set; }
            public int period { get; set; }
            public double bilateralContractAmount { get; set; }
            public double dayAheadMarketVolume { get; set; }
            public double intradayVolume { get; set; }
            public double balancedPowerMarketVolume { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double bilateralContractAmountAvg { get; set; }
            public double bilateralContractAmountMin { get; set; }
            public double bilateralContractAmountMax { get; set; }
            public double bilateralContractAmountSum { get; set; }
            public double dayAheadMarketVolumeAvg { get; set; }
            public double dayAheadMarketVolumeMin { get; set; }
            public double dayAheadMarketVolumeMax { get; set; }
            public double dayAheadMarketVolumeSum { get; set; }
            public double intradayVolumeAvg { get; set; }
            public double intradayVolumeMin { get; set; }
            public double intradayVolumeMax { get; set; }
            public double intradayVolumeSum { get; set; }
            public double balancedPowerMarketVolumeAvg { get; set; }
            public double balancedPowerMarketVolumeMin { get; set; }
            public double balancedPowerMarketVolumeMax { get; set; }
            public double balancedPowerMarketVolumeSum { get; set; }
        }

        public class Ratio
        {
            public DateTime date { get; set; }
            public object period { get; set; }
            public double bilateralContractAmount { get; set; }
            public double dayAheadMarketVolume { get; set; }
            public double intradayVolume { get; set; }
            public double balancedPowerMarketVolume { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/market-volume?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + "&period=" + period.ToString();
        }




    }

}
