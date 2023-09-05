using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Bulletin
{
    /// <summary>
    /// 1.1. EPİAŞ Günlük Bülten Servisi
    /// 1.2. EPİAŞ Aylık Bülten Servisi
    /// 1.3. EPİAŞ Günlük Doğal Gaz Bülten Servisi
    /// 1.4. EPİAŞ Haftalık Bülten Servisi
    /// 
    /// </summary>
    public class existBulletinResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }



        public class Body
        {
            public Bulletin[] bulletins { get; set; }
        }

        public class Bulletin
        {
            public string link { get; set; }
            public string title { get; set; }
        }


        public string getURLDaily(DateTime date)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/bulletin/daily?date=" + date.ToString("yyyy-MM-dd");

        }

        public string getURLDaily()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/bulletin/monthly";
        }

        public string getURLNGDaily(DateTime date)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/bulletin/naturalgas/daily?date=" + date.ToString("yyyy-MM-dd");
        }


        public string getURLWeekly()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/bulletin/weekly";
        }


        public string getURLYearly()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/bulletin/year";
        }


    }






}
