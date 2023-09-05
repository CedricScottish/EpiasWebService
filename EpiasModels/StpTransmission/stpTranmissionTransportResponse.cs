using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.StpTransmission
{
    /// <summary>
    /// 1.125. Taşıma Giriş Miktarı Bildirimi Servisi
    /// </summary>
    public class stpTranmissionTransportResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Transport[] transport { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Transport
        {
            public DateTime gasDay { get; set; }
            public int entryNomination { get; set; }
            public int exitNomination { get; set; }
        }

        public class Statistic
        {
            public DateTime gasDay { get; set; }
            public int entryNominationAvg { get; set; }
            public int entryNominationMin { get; set; }
            public int entryNominationMax { get; set; }
            public int exitNominationAvg { get; set; }
            public int exitNominationMin { get; set; }
            public int exitNominationMax { get; set; }
        }



        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp-transmission/transport?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }





    }












}
