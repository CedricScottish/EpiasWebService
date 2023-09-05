using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{

    /// <summary>
    /// 1.19. Sayaç Okuyan Kurum Rest Servisi
    /// </summary>
    public class meterReadingCompanyResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Meterreadingcompanylist[] meterReadingCompanyList { get; set; }
        }

        public class Meterreadingcompanylist
        {
            public int id { get; set; }
            public string name { get; set; }
            public int status { get; set; }
        }

        public string getURL(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/meter-reading-company?period=" + period.ToString("yyyy-MM-dd");
        }


    }






}
