using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.93. YEKDEM Kurulu Güç Rest Servisi
    /// </summary>
    public class installedCapacityOfRenewableResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Installedcapacityofrenewablelist[] installedCapacityOfRenewableList { get; set; }
            public Statistic[] statistics { get; set; }
            public Ratio[] ratios { get; set; }
        }

        public class Installedcapacityofrenewablelist
        {
            public int capacityTypeId { get; set; }
            public DateTime period { get; set; }
            public string capacityType { get; set; }
            public double? capacity { get; set; }
        }

        public class Statistic
        {
            public object period { get; set; }
            public double? totalCapacity { get; set; }
        }

        public class Ratio
        {
            public int capacityTypeId { get; set; }
            public string capacityType { get; set; }
            public double? capacity { get; set; }
        }

        public string getURL(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/installed-capacity-of-renewable?period=" + period.ToString("yyyy-MM-dd");
        }




    }
}
