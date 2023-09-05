using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Vgp
{
    /// <summary>
    /// 1.170. VGP Yıl Listesi
    /// </summary>
    public class vgpAvailableYearResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }
        public class Body
        {
            public Yearlist[] yearList { get; set; }
        }

        public class Yearlist
        {
            public string year { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/vgp/available-year-list";
        }
    }



}
