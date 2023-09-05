using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{

    /// <summary>
    /// 1.138. İlave Dengeleyici ve Toplam Eşleşme Miktar Servisi
    /// </summary>
    public class stpAdditionalImbalanceQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Quantity[] quantities { get; set; }
        }

        public class Quantity
        {
            public DateTime gasDay { get; set; }
            public int additionalQuantity { get; set; }
            public int otherQuantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/matching-quantity/additional-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }

}
