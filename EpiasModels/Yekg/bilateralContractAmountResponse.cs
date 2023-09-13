using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Yekg
{
    /// <summary>
    /// 1.180. YEK-G İkili anlaşma miktarları
    /// </summary>
    public class bilateralContractAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Statistic[] statistics { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? windAvg { get; set; }
            public int windMin { get; set; }
            public int windMax { get; set; }
            public int windSum { get; set; }
            public double? sunAvg { get; set; }
            public int sunMin { get; set; }
            public int sunMax { get; set; }
            public int sunSum { get; set; }
            public double? hydroAvg { get; set; }
            public int hydroMin { get; set; }
            public int hydroMax { get; set; }
            public int hydroSum { get; set; }
            public double? geothermalAvg { get; set; }
            public int geothermalMin { get; set; }
            public int geothermalMax { get; set; }
            public int geothermalSum { get; set; }
            public double? biomassAvg { get; set; }
            public int biomassMin { get; set; }
            public int biomassMax { get; set; }
            public int biomassSum { get; set; }
            public double? totalAvg { get; set; }
            public int totalMin { get; set; }
            public int totalMax { get; set; }
            public int totalSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/yekg/bilateral-contract-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }



}
