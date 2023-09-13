using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EpiasModels.definitionValues;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.51. DSG Dengesizlik Miktarı Servisi
    /// </summary>
    public class dsgImbalanceQuantityResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Imbalancequantitylist[] imbalanceQuantityList { get; set; }
        }

        public class Imbalancequantitylist
        {
            public DateTime date { get; set; }
            public double? positiveImbalanceQuantity { get; set; }
            public double? negativImbalanceQuantity { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? eic, int? organizationId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/dsg-imbalance-quantity?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (eic != null)
            {
                strReturn += "&eic=" + eic.ToString();
            }

            if (organizationId != null)
            {
                strReturn += "&organizationId=" + organizationId.ToString();

            }

            return strReturn;
        }

    }
}
