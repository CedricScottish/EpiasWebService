using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vep
{
    /// <summary>
    /// 1.162. VEP Yıl Listesi
    /// </summary>
    public class vepAvailableYearByDateResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Yearlist[] yearList { get; set; }
        }

        public class Yearlist
        {
            public string year { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate, definitionValues.serviceName? serviceName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/available-year-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (serviceName != null)
            {
                strReturn += "&serviceName=" + serviceName.ToString();
            }

            return strReturn;
        }


    }



}
