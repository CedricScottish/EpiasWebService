using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Transmission
{
    /// <summary>
    /// 1.155. ENTSO-E X Kodları Rest Servisi
    /// </summary>
    public class entsOrganizationResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Entsorganizationlist[] entsOrganizationList { get; set; }
        }

        public class Entsorganizationlist
        {
            public string etsoOrganizationCode { get; set; }
            public string organizationName { get; set; }
            public string organizationShortName { get; set; }
        }

        public string getURL(DateTime period, int? organizationId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/transmission/ents-organization?period=" + period.ToString("yyyy-MM-dd");

            if (organizationId != null)
            {
                strReturn += "&organizationId=" + organizationId.ToString();
            }
            return strReturn;
        }

    }





}
