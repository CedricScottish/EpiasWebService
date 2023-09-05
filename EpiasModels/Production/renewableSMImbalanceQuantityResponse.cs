using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.104. YEKDEM Dengesizlik Miktarı Rest Servisi
    /// </summary>
    public class renewableSMImbalanceQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Renewablesmimbalancequantitylist[] renewableSMImbalanceQuantityList { get; set; }
        }

        public class Renewablesmimbalancequantitylist
        {
            public DateTime date { get; set; }
            public object imbalanceQuantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/renewable-sm-imbalance-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }




    }

}
