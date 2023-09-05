using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.107. (YEKDEM) Lisanslı Üretim Miktarı Gerçek Zamanlı Üretim
    /// </summary>
    public class renewableSMLicensedRealTimeGenerationResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Renewablelicencedgenerationamount[] renewableLicencedGenerationAmount { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Renewablelicencedgenerationamount
        {
            public DateTime date { get; set; }
            public double total { get; set; }
            public double wind { get; set; }
            public double geothermal { get; set; }
            public double biogas { get; set; }
            public double biomass { get; set; }
            public double canalType { get; set; }
            public double sun { get; set; }
            public double lfg { get; set; }
            public double riverType { get; set; }
            public double reservoir { get; set; }
            public double others { get; set; }
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
            public double geothermalAvg { get; set; }
            public double geothermalMin { get; set; }
            public double geothermalMax { get; set; }
            public double geothermalSum { get; set; }
            public double biogasAvg { get; set; }
            public double biogasMin { get; set; }
            public double biogasMax { get; set; }
            public double biogasSum { get; set; }
            public double biomassAvg { get; set; }
            public double biomassMin { get; set; }
            public double biomassMax { get; set; }
            public double biomassSum { get; set; }
            public double canalTypeAvg { get; set; }
            public double canalTypeMin { get; set; }
            public double canalTypeMax { get; set; }
            public double canalTypeSum { get; set; }
            public double sunAvg { get; set; }
            public int sunMin { get; set; }
            public double sunMax { get; set; }
            public double sunSum { get; set; }
            public object lfgAvg { get; set; }
            public object lfgMin { get; set; }
            public object lfgMax { get; set; }
            public object lfgSum { get; set; }
            public double riverTypeAvg { get; set; }
            public double riverTypeMin { get; set; }
            public double riverTypeMax { get; set; }
            public double riverTypeSum { get; set; }
            public double reservoirAvg { get; set; }
            public double reservoirMin { get; set; }
            public double reservoirMax { get; set; }
            public double reservoirSum { get; set; }
            public double othersAvg { get; set; }
            public double othersMin { get; set; }
            public double othersMax { get; set; }
            public double othersSum { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/renewable-sm-licensed-real-time-generation?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }





    }

}
