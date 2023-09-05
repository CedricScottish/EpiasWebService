using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.StpTransmission
{
    /// <summary>
    /// 1.126. Sanal ticaret web servisi
    /// </summary>
    public class stpTranmissionVirtualTradeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Transferlist[] transferList { get; set; }
            public DateTime latestUpdate { get; set; }
        }

        public class Transferlist
        {
            public int id { get; set; }
            public DateTime date { get; set; }
            public int dayBefore { get; set; }
            public int endOfDay { get; set; }
            public int transfer { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp-transmission/virtual-trade?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }




    }








}
