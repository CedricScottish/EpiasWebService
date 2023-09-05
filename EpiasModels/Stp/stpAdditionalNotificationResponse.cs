using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.127. İlave dengeleyici işlemleri bildirim servisi
    /// </summary>
    public class stpAdditionalNotificationResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Additionalnotification[] additionalNotifications { get; set; }
        }

        public class Additionalnotification
        {
            public int id { get; set; }
            public DateTime date { get; set; }
            public string subjectTr { get; set; }
            public string subjectEn { get; set; }
            public string messageTr { get; set; }
            public string messageEn { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/additional-notification?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }







}
