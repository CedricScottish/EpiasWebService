﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Dam
{
    /// <summary>
    /// 1.30. Aktif Hacim
    /// </summary>
    public class activeVolumeResponse
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
            public string damName { get; set; }
            public double? activeVolume { get; set; }
        }


        public string getURL(string? basinName, string? damName)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/dam/get-active-volume";

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
