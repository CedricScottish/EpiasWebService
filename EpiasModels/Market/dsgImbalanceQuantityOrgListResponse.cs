using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.52. DSG Dengesizlik Miktarı Servisi
    /// </summary>
    public class dsgImbalanceQuantityOrgListResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Orglist[] orgList { get; set; }
        }

        public class Orglist
        {
            public int organizationId { get; set; }
            public string organizationName { get; set; }
            public string organizationStatus { get; set; }
            public string organizationETSOCode { get; set; }
            public string organizationShortName { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/dsg-imbalance-quantity-orgaization-list?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }
    }
}
