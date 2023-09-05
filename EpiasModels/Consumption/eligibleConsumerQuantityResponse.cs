using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.11. Profil Abone Grubuna Göre Serbest Tüketici Sayısı Rest Servisi
    /// </summary>
    public class eligibleConsumerQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Eligibleconsumerquantitylist[] eligibleConsumerQuantityList { get; set; }
        }

        public class Eligibleconsumerquantitylist
        {
            public Id id { get; set; }
            public int quantityOfUsingEligibleConsumer { get; set; }
            public int quantityOfNotUsingEligibleConsumer { get; set; }
        }

        public class Id
        {
            public string profilAboneGrupAdi { get; set; }
            public DateTime date { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/eligible-consumer-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }



}
