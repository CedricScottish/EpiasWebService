using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.StpTransmission
{
    /// <summary>
    /// 1.123. Kapasite web servisi
    /// </summary>
    public class stpTranmissionCapacityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Capacitylist[] capacityList { get; set; }
            public DateTime latestUpdate { get; set; }
        }

        public class Capacitylist
        {
            public DateTime relatedDate { get; set; }
            public int pointTypeId { get; set; }
            public int maxCapacity { get; set; }
            public int reservedCapacity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.pointType pointType, int? pointId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/stp-transmission/capacity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            strReturn += "&pointType=" + pointType.ToString();

            if (pointId != null)
            {
                strReturn += "&pointId=" + pointId.ToString();
            }
            return strReturn;
        }



    }











}
