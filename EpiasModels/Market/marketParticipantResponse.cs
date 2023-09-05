using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{

    /// <summary>
    /// 1.70. Piyasa Katılımcıları Raporu
    /// </summary>
    public class marketParticipantResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Marketparticipantlist[] marketParticipantList { get; set; }
        }

        public class Marketparticipantlist
        {
            public int id { get; set; }
            public string orgName { get; set; }
            public bool damEntry { get; set; }
            public bool intraDayEntry { get; set; }
            public bool naturalGasMarketEntry { get; set; }
            public bool legalStatus { get; set; }
            public string orgShortName { get; set; }
        }

        public string getURL(string? eic)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/market-participants";


            if (eic != null)
            {
                strReturn += @"?eic=" + eic.ToString();
            }

            return strReturn;
        }


    }




}
