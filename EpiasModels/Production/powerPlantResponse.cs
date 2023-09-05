using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.95. Santral Rest Servisi
    /// 1.97. Gerçek Zamanlı Üretim Santral Rest Servisi
    /// 1.106. (YEKDEM) Santral Rest Servisi
    /// </summary>
    public class powerPlantResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Powerplantlist[] powerPlantList { get; set; }
        }

        public class Powerplantlist
        {
            public int id { get; set; }
            public string name { get; set; }
            public string eic { get; set; }
            public string shortName { get; set; }
        }


        public string getURL(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/power-plant?period=" + period.ToString("yyyy-MM-dd");
        }


        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/real-time-generation-power-plant-list";

        }

        public string getURLYEKDEM(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/renewable-sm-licensed-power-plant-list?period=" + period.ToString("yyyy-MM-dd");
        }


    }
}
