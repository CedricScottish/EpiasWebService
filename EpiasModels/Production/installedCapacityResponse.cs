using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.92. Kurulu Güç Rest Servisi
    /// </summary>
    public class installedCapacityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Installedcapacitylist[] installedCapacityList { get; set; }
        }

        public class Installedcapacitylist
        {
            public DateTime period { get; set; }
            public string capacityType { get; set; }
            public double capacity { get; set; }
        }

        public string getURL(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/installed-capacity?period=" + period.ToString("yyyy-MM-dd");
        }


    }






}
