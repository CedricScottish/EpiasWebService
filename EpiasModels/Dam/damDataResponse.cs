using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Dam
{
    /// <summary>
    /// 1.34. Baraj Bilgileri Servisi
    /// </summary>
    public class damDataResponse
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
            public DateTime date { get; set; }
            public string basinName { get; set; }
            public string cityName { get; set; }
            public string damName { get; set; }
            public int? turbineNumber { get; set; }
            public double? coordx { get; set; }
            public double? coordy { get; set; }
            public double maxOperationVolume { get; set; }
            public double minOperationVolume { get; set; }
            public double maxOperationKot { get; set; }
            public double minOperationKot { get; set; }
            public double? installedPower { get; set; }
            public double? unitFlowRate { get; set; }
        }


        public string getURL(string? basinName, string? damName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/dam/get-dam-data";

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
