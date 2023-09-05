using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.101. Bölge Rest Servisi
    /// </summary>
    public class regionResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Regionlist[] regionList { get; set; }
        }

        public class Regionlist
        {
            public int id { get; set; }
            public string region { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/region";
        }


    }

}
