using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{

    /// <summary>
    /// 1.119. Piyasa Mesaj Sistemi Mesaj Tip Rest Servisi
    /// </summary>
    public class ummTypeResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Ummtypelist[] ummTypeList { get; set; }
        }

        public class Ummtypelist
        {
            public int id { get; set; }
            public string type { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/urgent-market-message-type";
        }

    }









}
