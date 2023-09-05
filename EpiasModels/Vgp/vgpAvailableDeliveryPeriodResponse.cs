using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vgp
{
    /// <summary>
    /// 1.169. VGP Teslimat Periyodu
    /// </summary>
    public class vgpAvailableDeliveryPeriodResponse
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

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/vgp/available-delivery-period-list";
        }

    }





}
