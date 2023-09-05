using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Yekg
{
    /// <summary>
    /// 1.181. İptal edilen YEK-G Belge Miktarı
    /// </summary>
    public class cancelAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Datalist[] dataList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Datalist
        {
            public DateTime date { get; set; }
            public int wind { get; set; }
            public int sun { get; set; }
            public int hydro { get; set; }
            public int geothermal { get; set; }
            public int biomass { get; set; }
            public int total { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public int windAvg { get; set; }
            public int windMin { get; set; }
            public int windMax { get; set; }
            public int windSum { get; set; }
            public int sunAvg { get; set; }
            public int sunMin { get; set; }
            public int sunMax { get; set; }
            public int sunSum { get; set; }
            public int hydroAvg { get; set; }
            public int hydroMin { get; set; }
            public int hydroMax { get; set; }
            public int hydroSum { get; set; }
            public int geothermalAvg { get; set; }
            public int geothermalMin { get; set; }
            public int geothermalMax { get; set; }
            public int geothermalSum { get; set; }
            public int biomassAvg { get; set; }
            public int biomassMin { get; set; }
            public int biomassMax { get; set; }
            public int biomassSum { get; set; }
            public int totalAvg { get; set; }
            public int totalMin { get; set; }
            public int totalMax { get; set; }
            public int totalSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/yekg/cancel-amount-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }
    }





}
