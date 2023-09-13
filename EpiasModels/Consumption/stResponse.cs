using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.23. Profil Abone Grubuna Göre Serbest Tüketici Tüketim Miktarları Rest Servisi
    /// </summary>
    public class stResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Stlist[] stList { get; set; }
        }

        public class Stlist
        {
            public Id id { get; set; }
            public double? quantityOfUsingEligibleConsumer { get; set; }
            public double? quantityOfNotUsingEligibleConsumer { get; set; }
            public int stCount { get; set; }
        }

        public class Id
        {
            public string profilAboneGrupAdi { get; set; }
            public DateTime date { get; set; }
        }


    }
}
