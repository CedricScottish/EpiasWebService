using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.24. Profil Abone Grup
    /// </summary>
    public class subscriberProfileGroupResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Subscriberprofilegrouplist[] subscriberProfileGroupList { get; set; }
        }

        public class Subscriberprofilegrouplist
        {
            public int id { get; set; }
            public string name { get; set; }
        }

      


        public string getURL(DateTime? period, int? distributionId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/consumption/subscriber-profile-group";

            if (period != null)
            {
                strReturn += "?period=" + period.Value.ToString("yyyy-MM-dd");

                if (distributionId != null)
                {
                    strReturn += "&distributionId=" + distributionId.ToString();
                }

            }
            else
            {
                if (distributionId != null)
                {
                    strReturn += "?distributionId=" + distributionId.ToString();
                }
            }
            return strReturn;
        }


    }

}
