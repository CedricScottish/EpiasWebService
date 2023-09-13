using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.112. (YEKDEM) Lisanssız Üretim Miktarı
    /// </summary>
    public class renewableUnlicencedGenerationAmountResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Renewableunlicencedgenerationamountlist[] renewableUnlicencedGenerationAmountList { get; set; }
        }

        public class Renewableunlicencedgenerationamountlist
        {
            public DateTime date { get; set; }
            public double? total { get; set; }
            public double? wind { get; set; }
            public double? biogas { get; set; }
            public double? canalType { get; set; }
            public double? biomass { get; set; }
            public double? sun { get; set; }
            public double? others { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/renewable-unlicenced-generation-amount?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += @"&bolge=" + bolge.ToString();
            }
            return strReturn;
        }





    }

}
