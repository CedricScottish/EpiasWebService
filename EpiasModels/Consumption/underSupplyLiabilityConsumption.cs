using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.28. Tedarik Yükümlülüğü Kapsamındaki UEÇM Miktarı
    /// </summary>
    public class underSupplyLiabilityConsumption
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Swvlist[] swvList { get; set; }
            public Statistic statistic { get; set; }
        }

        public class Statistic
        {
            public double swvMin { get; set; }
            public double swvMax { get; set; }
            public double swvAvg { get; set; }
            public double swvSum { get; set; }
        }

        public class Swvlist
        {
            public DateTime date { get; set; }
            public double swv { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/under-supply-liability-consumption?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }






}
