using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.111. YEKDEM Birim Maliyet Rest Servisi
    /// </summary>
    public class renewableSMUnitCostResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Renewablesmunitcostlist[] renewableSMUnitCostList { get; set; }
        }

        public class Renewablesmunitcostlist
        {
            public Id id { get; set; }
            public double? unitCost { get; set; }
            public double? supplierUnitCost { get; set; }
        }

        public class Id
        {
            public DateTime donem { get; set; }
            public DateTime versiyon { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/renewable-sm-unit-cost?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
