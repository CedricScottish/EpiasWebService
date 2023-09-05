using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Dam
{
    /// <summary>
    /// 1.31. Havza Adı Listesi
    /// 1.35. Baraj Adı Listesi
    /// </summary>
    public class basinDamListResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public string[] basinList { get; set; }
        }

        public string getURLBasin()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/dam/get-basin-list";
        }
        public string getURLDam(string? basinName)
        {
            string strReturn= @"https://seffaflik.epias.com.tr/transparency/service/dam/get-dam-list";

            if (basinName != null)
            {
                strReturn += "?basinName=" + basinName;
            }

            return strReturn;
        }


    }

}
