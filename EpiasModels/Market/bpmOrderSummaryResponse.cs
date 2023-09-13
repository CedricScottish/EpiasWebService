using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.43. DGP Talimat Rest Servisi
    /// </summary>
    public class bpmOrderSummaryResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Bpmordersummarylist[] bpmOrderSummaryList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Bpmordersummarylist
        {
            public DateTime date { get; set; }
            public double? net { get; set; }
            public double? upRegulationZeroCoded { get; set; }
            public int upRegulationOneCoded { get; set; }
            public int upRegulationTwoCoded { get; set; }
            public double? downRegulationZeroCoded { get; set; }
            public int downRegulationOneCoded { get; set; }
            public int downRegulationTwoCoded { get; set; }
            public double? upRegulationDelivered { get; set; }
            public double? downRegulationDelivered { get; set; }
            public string direction { get; set; }
            public DateTime nextHour { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? netMin { get; set; }
            public double? netMax { get; set; }
            public double? netTotal { get; set; }
            public int upRegulationZeroCodedMin { get; set; }
            public double? upRegulationZeroCodedMax { get; set; }
            public double? upRegulationZeroCodedTotal { get; set; }
            public int upRegulationOneCodedMin { get; set; }
            public int upRegulationOneCodedMax { get; set; }
            public int upRegulationOneCodedTotal { get; set; }
            public int upRegulationTwoCodedMin { get; set; }
            public int upRegulationTwoCodedMax { get; set; }
            public int upRegulationTwoCodedTotal { get; set; }
            public int downRegulationZeroCodedMin { get; set; }
            public double? downRegulationZeroCodedMax { get; set; }
            public double? downRegulationZeroCodedTotal { get; set; }
            public int downRegulationOneCodedMin { get; set; }
            public int downRegulationOneCodedMax { get; set; }
            public int downRegulationOneCodedTotal { get; set; }
            public int downRegulationTwoCodedMin { get; set; }
            public int downRegulationTwoCodedMax { get; set; }
            public int downRegulationTwoCodedTotal { get; set; }
            public int upRegulationDeliveredMin { get; set; }
            public double? upRegulationDeliveredMax { get; set; }
            public double? upRegulationDeliveredTotal { get; set; }
            public double? downRegulationDeliveredMin { get; set; }
            public int downRegulationDeliveredMax { get; set; }
            public double? downRegulationDeliveredTotal { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/bpm-order-summary?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge;
            }
            return strReturn;
        }


    }
}
