using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.8. Serbest Tüketici Çekiş Miktar Servisi
    /// </summary>
    public class consumptionResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Consumption[] consumptions { get; set; }
        }

        public class Consumption
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
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/consumption?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
