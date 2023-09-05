using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Mobile
{

    /// <summary>
    /// 1.84. Mobil Uygulama Topic Listeleme
    /// </summary>
    public class mobileTopicResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Topic[] topics { get; set; }
        }

        public class Topic
        {
            public int id { get; set; }
            public string topicName { get; set; }
            public string topicDescription { get; set; }
            public string language { get; set; }
        }

        public string getURL()
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/mobile/topics";
        }

    }

 






}
