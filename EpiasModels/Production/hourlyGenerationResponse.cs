using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.96. Gerçek Zamanlı Üretim Rest Servisi
    /// 1.98. Gerçek Zamanlı Üretim Rest Servisi Santral Kırılımlı
    /// </summary>
    public class hourlyGenerationResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Hourlygeneration[] hourlyGenerations { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Hourlygeneration
        {
            public DateTime date { get; set; }
            public double fueloil { get; set; }
            public int gasOil { get; set; }
            public double blackCoal { get; set; }
            public double lignite { get; set; }
            public double geothermal { get; set; }
            public double naturalGas { get; set; }
            public double river { get; set; }
            public double dammedHydro { get; set; }
            public int lng { get; set; }
            public double biomass { get; set; }
            public int naphta { get; set; }
            public double importCoal { get; set; }
            public double asphaltiteCoal { get; set; }
            public double wind { get; set; }
            public int nucklear { get; set; }
            public double sun { get; set; }
            public double importExport { get; set; }
            public double wasteheat { get; set; }
            public double total { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double fueloilAvg { get; set; }
            public double fueloilMin { get; set; }
            public double fueloilMax { get; set; }
            public double fueloilSum { get; set; }
            public double gasOilAvg { get; set; }
            public int gasOilMin { get; set; }
            public int gasOilMax { get; set; }
            public int gasOilSum { get; set; }
            public double blackCoalAvg { get; set; }
            public double blackCoalMin { get; set; }
            public double blackCoalMax { get; set; }
            public double blackCoalSum { get; set; }
            public double ligniteAvg { get; set; }
            public double ligniteMin { get; set; }
            public double ligniteMax { get; set; }
            public double ligniteSum { get; set; }
            public double geothermalAvg { get; set; }
            public double geothermalMin { get; set; }
            public double geothermalMax { get; set; }
            public double geothermalSum { get; set; }
            public double naturalGasAvg { get; set; }
            public double naturalGasMin { get; set; }
            public double naturalGasMax { get; set; }
            public double naturalGasSum { get; set; }
            public double riverAvg { get; set; }
            public double riverMin { get; set; }
            public double riverMax { get; set; }
            public double riverSum { get; set; }
            public double dammedHydroAvg { get; set; }
            public double dammedHydroMin { get; set; }
            public double dammedHydroMax { get; set; }
            public double dammedHydroSum { get; set; }
            public double lngAvg { get; set; }
            public int lngMin { get; set; }
            public int lngMax { get; set; }
            public int lngSum { get; set; }
            public double biomassAvg { get; set; }
            public double biomassMin { get; set; }
            public double biomassMax { get; set; }
            public double biomassSum { get; set; }
            public double naphtaAvg { get; set; }
            public int naphtaMin { get; set; }
            public int naphtaMax { get; set; }
            public int naphtaSum { get; set; }
            public double importCoalAvg { get; set; }
            public double importCoalMin { get; set; }
            public double importCoalMax { get; set; }
            public double importCoalSum { get; set; }
            public double asphaltiteCoalAvg { get; set; }
            public double asphaltiteCoalMin { get; set; }
            public double asphaltiteCoalMax { get; set; }
            public double asphaltiteCoalSum { get; set; }
            public double windAvg { get; set; }
            public double windMin { get; set; }
            public double windMax { get; set; }
            public double windSum { get; set; }
            public double nucklearAvg { get; set; }
            public int nucklearMin { get; set; }
            public int nucklearMax { get; set; }
            public int nucklearSum { get; set; }
            public double sunAvg { get; set; }
            public int sunMin { get; set; }
            public double sunMax { get; set; }
            public double sunSum { get; set; }
            public double importExportAvg { get; set; }
            public double importExportMin { get; set; }
            public double importExportMax { get; set; }
            public double importExportSum { get; set; }
            public double totalAvg { get; set; }
            public double totalMin { get; set; }
            public double totalMax { get; set; }
            public double totalSum { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/real-time-generation?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

        //https://seffaflik.epias.com.tr/transparency/service/production/real-time-generation_with_powerplant?startDate=2023-06-01&endDate=2023-06-01&powerPlantId=2650


        public string getURL(DateTime startDate, DateTime endDate, int powerPlantId)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/real-time-generation_with_powerplant?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd") + @"&powerPlantId=" + powerPlantId.ToString();
        }



    }

}
