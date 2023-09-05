using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.90. Toplam Kesinleşmiş Günlük Üretim Planı Rest Servisi
    /// </summary>
    public class finalDPPResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Finaldpplist[] finalDPPList { get; set; }
        }

        public class Finaldpplist
        {
            public DateTime date { get; set; }
            public double dpp { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/production/final-dpp?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }




    }










}
