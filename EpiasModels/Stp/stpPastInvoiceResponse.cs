using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Stp
{
    /// <summary>
    /// 1.144. Doğalgaz GDDK Servisi
    /// </summary>
    public class stpPastInvoiceResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Pastinvoice[] pastInvoices { get; set; }
        }

        public class Pastinvoice
        {
            public DateTime period { get; set; }
            public DateTime version { get; set; }
            public double? debt { get; set; }
            public double? credit { get; set; }
        }


        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/stp/past-invoice?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }





}
