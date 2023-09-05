using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{

    /// <summary>
    /// 1.12. Tüketici Sayısı Listeleme Servisi
    /// Web Servisi Çalıştırılamadı
    /// </summary>
    public class getConsumerQuantity
    {

        public string getURL()
        {

            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/get-consumer-quantity?period=2023-06-01&profileGroupId=-1&provinceId=-1";

        }

    }
}
