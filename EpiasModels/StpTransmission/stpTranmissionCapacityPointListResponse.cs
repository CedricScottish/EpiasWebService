using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.StpTransmission
{

    /// <summary>
    /// 1.124. İletim noktası web servisi
    /// </summary>
    public class stpTranmissionCapacityPointListResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Capacitypointlist[] capacityPointList { get; set; }
        }

        public class Capacitypointlist
        {
            public int pointId { get; set; }
            public string pointName { get; set; }
        }


        public string getURL(definitionValues.pointType pointType)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp-transmission/capacity-point-list?pointType=" + pointType.ToString();
        }



    }

}
