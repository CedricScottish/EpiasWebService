using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Mobile
{
    /// <summary>
    /// 1.83. Son uzlaştırma dönemi web servisi
    /// </summary>
    public class finalConciliationPeriodResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public DateTime finalConciliationPeriod { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/mobile/final-conciliation-period";
        }



    }

}
