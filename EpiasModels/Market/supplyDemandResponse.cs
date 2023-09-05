using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.81. Arz-Talep Eğrisi Rest Servisi
    /// 1.82. Arz-Talep Eğrisi Rest Servisi (Saatlik)
    /// </summary>
    public class supplyDemandResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Supplydemandcurve[] supplyDemandCurves { get; set; }
        }

        public class Supplydemandcurve
        {
            public DateTime date { get; set; }
            public double price { get; set; }
            public double supply { get; set; }
            public double demand { get; set; }
        }


        public string getURL(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/supply-demand-curve?period=" + period.ToString("yyyy-MM-dd");
        }

        public string getURL(DateTime period, int hour)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/market/supply-demand-curve-hour?hour=" + period.ToString("yyyy-MM-dd") + "T";

            if (hour < 10)
            {
                strReturn += "0" + hour.ToString() + ":00";
            }
            else
            {
                strReturn += hour.ToString() + ":00";
            }
            return strReturn;
        }


    }

}
