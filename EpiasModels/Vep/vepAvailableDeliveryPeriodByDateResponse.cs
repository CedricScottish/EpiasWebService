using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EpiasModels.definitionValues;

namespace EpiasModels.Vep
{

    /// <summary>
    /// 1.160. VEP Teslimat Periyodu
    /// </summary>
    public class vepAvailableDeliveryPeriodByDateResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Deliveryperiodlist[] deliveryPeriodList { get; set; }
        }

        public class Deliveryperiodlist
        {
            public string periodName { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate, definitionValues.serviceName? serviceName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/vep/available-delivery-period-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (serviceName != null)
            {
                strReturn += "&serviceName=" + serviceName.ToString();
            }

            return strReturn;
        }



    }

}
