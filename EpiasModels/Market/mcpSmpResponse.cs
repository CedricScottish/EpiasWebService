using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{


    /// <summary>
    /// 1.73. PTF-SMF Listeleme Servisi
    /// </summary>
    public class mcpSmpResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Mcpsmp[] mcpSmps { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Mcpsmp
        {
            public DateTime date { get; set; }
            public double? mcp { get; set; }
            public double? smp { get; set; }
            public string smpDirection { get; set; }
            public string mcpState { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? mcpMin { get; set; }
            public int mcpMax { get; set; }
            public double? mcpAvg { get; set; }
            public double? mcpWeightedAverage { get; set; }
            public double? smpMin { get; set; }
            public int smpMax { get; set; }
            public double? smpAvg { get; set; }
            public double? smpWeightedAverage { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/mcp-smp?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }



}
