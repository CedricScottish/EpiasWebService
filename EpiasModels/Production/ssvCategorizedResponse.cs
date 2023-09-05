using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.116. UEVM Kategori Rest Servisi
    /// </summary>
    public class ssvCategorizedResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Ssvlist[] ssvList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Ssvlist
        {
            public DateTime date { get; set; }
            public double total { get; set; }
            public double wind { get; set; }
            public double lignite { get; set; }
            public double stonecoal { get; set; }
            public double importedCoal { get; set; }
            public double sun { get; set; }
            public double fueloil { get; set; }
            public int naphtha { get; set; }
            public double naturalGas { get; set; }
            public double geothermal { get; set; }
            public double dam { get; set; }
            public double river { get; set; }
            public double biomass { get; set; }
            public double other { get; set; }
            public int lng { get; set; }
            public double asphaltite { get; set; }
            public double international { get; set; }
            public double internationalExport { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double totalAvg { get; set; }
            public double totalMin { get; set; }
            public double totalMax { get; set; }
            public double totalSum { get; set; }
            public double windAvg { get; set; }
            public double windMin { get; set; }
            public double windMax { get; set; }
            public double windSum { get; set; }
            public double ligniteAvg { get; set; }
            public double ligniteMin { get; set; }
            public double ligniteMax { get; set; }
            public double ligniteSum { get; set; }
            public double stonecoalAvg { get; set; }
            public double stonecoalMin { get; set; }
            public double stonecoalMax { get; set; }
            public double stonecoalSum { get; set; }
            public double importedCoalAvg { get; set; }
            public double importedCoalMin { get; set; }
            public double importedCoalMax { get; set; }
            public double importedCoalSum { get; set; }
            public double fueloilAvg { get; set; }
            public double fueloilMin { get; set; }
            public double fueloilMax { get; set; }
            public double fueloilSum { get; set; }
            public double naphthaAvg { get; set; }
            public int naphthaMin { get; set; }
            public int naphthaMax { get; set; }
            public int naphthaSum { get; set; }
            public double naturalGasAvg { get; set; }
            public double naturalGasMin { get; set; }
            public double naturalGasMax { get; set; }
            public double naturalGasSum { get; set; }
            public double geothermalAvg { get; set; }
            public double geothermalMin { get; set; }
            public double geothermalMax { get; set; }
            public double geothermalSum { get; set; }
            public double damAvg { get; set; }
            public double damMin { get; set; }
            public double damMax { get; set; }
            public double damSum { get; set; }
            public double riverAvg { get; set; }
            public double riverMin { get; set; }
            public double riverMax { get; set; }
            public double riverSum { get; set; }
            public double biomassAvg { get; set; }
            public double biomassMin { get; set; }
            public double biomassMax { get; set; }
            public double biomassSum { get; set; }
            public double otherAvg { get; set; }
            public double otherMin { get; set; }
            public double otherMax { get; set; }
            public double otherSum { get; set; }
            public double lngAvg { get; set; }
            public int lngMin { get; set; }
            public int lngMax { get; set; }
            public int lngSum { get; set; }
            public double asphaltiteAvg { get; set; }
            public double asphaltiteMin { get; set; }
            public double asphaltiteMax { get; set; }
            public double asphaltiteSum { get; set; }
            public double internationalAvg { get; set; }
            public double internationalMin { get; set; }
            public double internationalMax { get; set; }
            public double internationalSum { get; set; }
            public double internationalExportAvg { get; set; }
            public int internationalExportMin { get; set; }
            public double internationalExportMax { get; set; }
            public double internationalExportSum { get; set; }
            public double sunAvg { get; set; }
            public double sunMin { get; set; }
            public double sunMax { get; set; }
            public double sunSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, int? powerPlantId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/ssv-categorized?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (powerPlantId != null)
            {
                strReturn += @"&powerPlantId=" + powerPlantId.ToString();
            }

            return strReturn;
        }





    }







}
