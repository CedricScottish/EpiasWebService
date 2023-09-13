using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Market
{
    /// <summary>
    /// 1.36. GÖP Blok Rest Servisi
    /// </summary>
    public class amountOfBlockResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Amountofblocklist[] amountOfBlockList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Amountofblocklist
        {
            public DateTime date { get; set; }
            public double? amountOfPurchasingTowardsBlock { get; set; }
            public double? amountOfPurchasingTowardsMatchBlock { get; set; }
            public double? amountOfSalesTowardsBlock { get; set; }
            public double? amountOfSalesTowardsMatchBlock { get; set; }
        }

        public class Statistic
        {
            public DateTime date { get; set; }
            public double? amountOfPurchasingTowardsBlockAvg { get; set; }
            public double? amountOfPurchasingTowardsBlockMin { get; set; }
            public double? amountOfPurchasingTowardsBlockMax { get; set; }
            public double? amountOfPurchasingTowardsBlockSum { get; set; }
            public double? amountOfPurchasingTowardsMatchBlockAvg { get; set; }
            public double? amountOfPurchasingTowardsMatchBlockMin { get; set; }
            public double? amountOfPurchasingTowardsMatchBlockMax { get; set; }
            public double? amountOfPurchasingTowardsMatchBlockSum { get; set; }
            public double? amountOfSalesTowardsBlockAvg { get; set; }
            public double? amountOfSalesTowardsBlockMin { get; set; }
            public double? amountOfSalesTowardsBlockMax { get; set; }
            public double? amountOfSalesTowardsBlockSum { get; set; }
            public double? amountOfSalesTowardsMatchBlockAvg { get; set; }
            public double? amountOfSalesTowardsMatchBlockMin { get; set; }
            public double? amountOfSalesTowardsMatchBlockMax { get; set; }
            public double? amountOfSalesTowardsMatchBlockSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate)
        {
            return @"https://seffaflik.epias.com.tr/transparency/service/market/amount-of-block?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");
        }



    }

}
