using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{
    /// <summary>
    /// 1.161. VEP Yük tipi listesi
    /// </summary>
    public class vepAvailableLoadTypeByDateResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Loadtypelist[] loadTypeList { get; set; }
        }

        public class Loadtypelist
        {
            public string name { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.serviceName? serviceName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/available-load-type-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (serviceName != null)
            {
                strReturn += "&serviceName=" + serviceName.ToString();
            }

            return strReturn;
        }



    }



}
