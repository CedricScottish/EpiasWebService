using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{

    /// <summary>
    /// 1.9. Dağıtım Bölge Rest Servis
    /// </summary>
    public class distributionResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Distributionlist[] distributionList { get; set; }
        }

        public class Distributionlist
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public string getURL(DateTime date)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/distribution?date=" + date.ToString("yyyy-MM-dd");
        }



    }
}
