﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.59. GİP Ağırlıklı Ortalama Fiyat Rest Servisi
    /// </summary>
    public class intradayAofResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Idmaoflist[] idmAofList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Idmaoflist
        {
            public DateTime date { get; set; }
            public double price { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public double average { get; set; }
            public object weightedAverage { get; set; }
            public object summary { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/intra-day-aof?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }


    }

}
