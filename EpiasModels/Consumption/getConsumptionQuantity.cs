using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Consumption
{
    /// <summary>
    /// 1.13. Tüketim Miktarları Listeleme Servisi
    /// Web Servisi Çalıştırılamadı
    /// </summary>
    public class getConsumptionQuantity
    {

        public string getURL()
        {

            return @"https://seffaflik.epias.com.tr/transparency/service/consumption/get-consumption-quantity?period=2023-06-01&profileGroupId=-1&provinceId=-1";

        }
    }
}
