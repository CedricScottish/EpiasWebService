using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Dam
{

    /// <summary>
    /// 1.32. Baraj Günlük Ölçüm Değerleri. Günlük Kot, Günlük Hacim ve Suyun Enerji Karşılığı Bilgilerini içerir.
    /// </summary>
    public class damDailyMeasurementResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public DateTime createDate { get; set; }
            public string createUser { get; set; }
            public int isDeleted { get; set; }
            public object modifyDate { get; set; }
            public object modifyUser { get; set; }
            public DateTime date { get; set; }
            public int damId { get; set; }
            public string damName { get; set; }
            public double? kot { get; set; }
            public double? volume { get; set; }
            public double? energyGeneration { get; set; }
            public string basinName { get; set; }
            public object createIp { get; set; }
            public object modifyIp { get; set; }
        }

        public string getURL(string? basinName, string? damName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/dam/get-daily-measurement";

            if (basinName != null)
            {
                strReturn += "?basinName=" + basinName;

                if (damName != null)
                {
                    strReturn += "&damName=" + damName;
                }
            }
            else
            {
                if (damName != null)
                {
                    strReturn += "?damName=" + damName;
                }
            }

            return strReturn;
        }


    }

}
