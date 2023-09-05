using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.45. GÖP Kesinleşmemiş PTF Rest Servisi
    /// </summary>
    public class interimMCPResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Interimmcplist[] interimMCPList { get; set; }
        }

        public class Interimmcplist
        {
            public DateTime date { get; set; }
            public double marketTradePrice { get; set; }
        }

        public string getURL(DateTime date)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/day-ahead-interim-mcp?date=" + date.ToString("yyyy-MM-dd");
        }


    }


}
