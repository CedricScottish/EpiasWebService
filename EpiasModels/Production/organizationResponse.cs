using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.89. KGÜP Organizasyon Rest Servisi
    /// </summary>
    public class organizationResponse
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
        }


        public string getURL(string? organizationName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/dpp-organization";

            if (organizationName != null)
            {
                strReturn += "?organizationName=" + organizationName;
            }
            return strReturn;
        }



    }

}
