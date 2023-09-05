using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.151. Toplam İşlem Hacmi Servisi
    /// </summary>
    public class stpTotalVolumeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Stptradevolume[] stpTradeVolume { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Stptradevolume
        {
            public DateTime gasDay { get; set; }
            public int tradeVolume { get; set; }
            public int totalMatchAmount { get; set; }
            public int period { get; set; }
            public string periodType { get; set; }
        }

        public class Statistic
        {
            public DateTime gasDay { get; set; }
            public int tradeVolumeMin { get; set; }
            public int tradeVolumeMax { get; set; }
            public int tradeVolumeSum { get; set; }
            public int tradeVolumeAvg { get; set; }
            public int totalMatchAmountMin { get; set; }
            public int totalMatchAmountMax { get; set; }
            public int totalMatchAmountSum { get; set; }
            public int totalMatchAmountAvg { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.period? period)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/stp/volume/stp-total-volume?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (period != null)
            {
                strReturn += "&period=" + period.ToString();
            }

            return strReturn;
        }

    }





}
