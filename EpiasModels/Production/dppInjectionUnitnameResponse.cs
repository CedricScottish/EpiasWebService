using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.88. KGÜP UEVÇB Rest Servisi
    /// </summary>
    public class dppInjectionUnitnameResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Injectionunitname[] injectionUnitNames { get; set; }
        }

        public class Injectionunitname
        {
            public int id { get; set; }
            public string name { get; set; }
            public string eic { get; set; }
        }


        public string getURL(string organizationEIC)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/dpp-injection-unit-name?organizationEIC=" + organizationEIC;
        }


    }

}
