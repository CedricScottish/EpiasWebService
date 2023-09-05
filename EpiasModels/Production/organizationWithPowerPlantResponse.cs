using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.94. Organizasyon Rest Servisi
    /// </summary>
    public class organizationWithPowerPlantResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Organization[] organizations { get; set; }
        }

        public class Organization
        {
            public int organizationId { get; set; }
            public string organizationName { get; set; }
            public string organizationStatus { get; set; }
            public string organizationETSOCode { get; set; }
            public string organizationShortName { get; set; }
            public Powerplantlist[] powerPlantList { get; set; }
        }

        public class Powerplantlist
        {
            public string name { get; set; }
            public string eic { get; set; }
            public string shortName { get; set; }
        }


        public string getURL(DateTime donem)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/organization-with-powerplant?donem=" + donem.ToString("yyyy-MM-dd");
        }




    }

}
