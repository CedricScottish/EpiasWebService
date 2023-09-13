using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.74. Lisans Tipine Göre Katılımcı Rest Servisi
    /// </summary>
    public class participantResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Participantlist[] participantList { get; set; }
            public Ratio[] ratios { get; set; }
        }

        public class Participantlist
        {
            public int id { get; set; }
            public DateTime date { get; set; }
            public string licence { get; set; }
            public int publicCompany { get; set; }
            public int privateSector { get; set; }
            public int licenceId { get; set; }
            public int publicCompanyOfSum { get; set; }
            public int privateSectorOfSum { get; set; }
        }

        public class Ratio
        {
            public string licence { get; set; }
            public int licenceId { get; set; }
            public double? ratio { get; set; }
        }

        public string getURL(DateTime period)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/participant?period=" + period.ToString("yyyy-MM-dd");
        }


    }







}
