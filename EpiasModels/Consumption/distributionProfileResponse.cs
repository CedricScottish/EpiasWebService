using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{

    /// <summary>
    /// 1.10. Profil Abone Grup Çarpan Katsayı Rest Servisi
    /// Web Servisi Çalıştırılamadı
    /// </summary>
    public class distributionProfileResponse
    {



        public string getURL()
        {

            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/distribution-profile?period=2023-06-01&meterReadingType=3&distributionId=1010&subscriberProfileGroup=1";

        }
    }
}
