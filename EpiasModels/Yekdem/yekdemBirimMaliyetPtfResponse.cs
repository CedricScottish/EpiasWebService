using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Yekdem
{
    /// <summary>
    /// 1.178. Yekdem Birim Maliyet Ptf
    /// </summary>
    public class yekdemBirimMaliyetPtfResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Datalist[] dataList { get; set; }
        }

        public class Datalist
        {
            public DateTime donem { get; set; }
            public float birimMaliyetPtf { get; set; }
        }
        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/yekdem/yekdem-birim-maliyet-ptf?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }

    }




}
