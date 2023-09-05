using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.117. UEVÇB Rest Servisi
    /// </summary>
    public class uevcbResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Uevcblist[] uevcbList { get; set; }
        }

        public class Uevcblist
        {
            public int id { get; set; }
            public string name { get; set; }
            public string eic { get; set; }
        }

        public string getURL(DateTime period, int powerPlantId)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/uevcb?period=" + period.ToString("yyyy-MM-dd") + "&powerPlantId=" + powerPlantId.ToString();
        }



    }





}
