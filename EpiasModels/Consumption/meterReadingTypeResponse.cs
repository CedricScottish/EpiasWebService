using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.20. Sayaç Okuma Tip Rest Servisi
    /// </summary>
    public class meterReadingTypeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Meterreadingtypelist[] meterReadingTypeList { get; set; }
        }

        public class Meterreadingtypelist
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/meter-reading-type";
        }



    }

}
