using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.137. STP Eşleşme Miktar Servisi
    /// </summary>
    public class stpMatchingQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Matchingdto[] matchingDtos { get; set; }
            public Statistics statistics { get; set; }
        }

        public class Statistics
        {
            public int intraDayMatchingQuantityMin { get; set; }
            public int intraDayMatchingQuantityMax { get; set; }
            public int intraDayMatchingQuantitySum { get; set; }
            public double? intraDayMatchingQuantityAvg { get; set; }
            public int dayAfterMatchingQuantityMin { get; set; }
            public int dayAfterMatchingQuantityMax { get; set; }
            public int dayAfterMatchingQuantitySum { get; set; }
            public double? dayAfterMatchingQuantityAvg { get; set; }
            public int dayAheadMatchingQuantityMin { get; set; }
            public int dayAheadMatchingQuantityMax { get; set; }
            public int dayAheadMatchingQuantitySum { get; set; }
            public double? dayAheadMatchingQuantityAvg { get; set; }
            public int gasReferenceMatchingQuantityMin { get; set; }
            public int gasReferenceMatchingQuantityMax { get; set; }
            public int gasReferenceMatchingQuantitySum { get; set; }
            public double? gasReferenceMatchingQuantityAvg { get; set; }
            public int gasDayMatchingQuantityMin { get; set; }
            public int gasDayMatchingQuantityMax { get; set; }
            public int gasDayMatchingQuantitySum { get; set; }
            public double? gasDayMatchingQuantityAvg { get; set; }
        }

        public class Matchingdto
        {
            public DateTime gasDay { get; set; }
            public string contractName { get; set; }
            public int? intraDayMatchingQuantity { get; set; }
            public int? dayAfterMatchingQuantity { get; set; }
            public int dayAheadMatchingQuantity { get; set; }
            public int? gasReferenceMatchingQuantity { get; set; }
            public int? gasDayMatchingQuantity { get; set; }
            public object weeklyMatchingQuantity { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/matching-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }




}
