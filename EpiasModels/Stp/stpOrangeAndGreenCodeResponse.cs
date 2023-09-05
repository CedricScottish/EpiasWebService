using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.134. 1 Kodlu ilave dengeleyici işlemler servisi
    /// </summary>
    public class stpOrangeAndGreenCodeResponse
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
            public int amountMin { get; set; }
            public int amountMax { get; set; }
            public int amountSum { get; set; }
            public double amountAvg { get; set; }
            public double weightedAverageAvg { get; set; }
            public double weightedAverageMin { get; set; }
            public double weightedAverageMax { get; set; }
        }

        public class Operation
        {
            public DateTime gasDay { get; set; }
            public DateTime contractGasDay { get; set; }
            public DateTime transactionDate { get; set; }
            public string contractName { get; set; }
            public int amount { get; set; }
            public double weightedAverage { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/greencode-operation?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }





    }


}
