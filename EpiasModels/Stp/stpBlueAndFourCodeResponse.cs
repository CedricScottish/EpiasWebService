using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.130. 2 Kodlu ilave dengeleyici işlemler servisi
    /// </summary>
    public class stpBlueAndFourCodeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Operation[] operations { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public object gasDay { get; set; }
            public int amountMin { get; set; }
            public int amountMax { get; set; }
            public int amountAvg { get; set; }
            public int amountSum { get; set; }
            public int weightedAverageMin { get; set; }
            public int weightedAverageMax { get; set; }
            public int weightedAverageAvg { get; set; }
        }

        public class Operation
        {
            public DateTime gasDay { get; set; }
            public string contractName { get; set; }
            public int amount { get; set; }
            public int weightedAverage { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/bluecode-operation?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }


}
