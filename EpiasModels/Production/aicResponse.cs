using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.86. Emre Amade Kapasite Rest Servisi
    /// </summary>
    public class aicResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }

        public class Body
        {
            public Aiclist[] aicList { get; set; }
            public Statistic[] statistics { get; set; }
        }

        public class Aiclist
        {
            public DateTime tarih { get; set; }
            public double? toplam { get; set; }
            public double? dogalgaz { get; set; }
            public double? ruzgar { get; set; }
            public double? linyit { get; set; }
            public int tasKomur { get; set; }
            public int ithalKomur { get; set; }
            public double? fuelOil { get; set; }
            public double? jeotermal { get; set; }
            public double? barajli { get; set; }
            public int nafta { get; set; }
            public double? biokutle { get; set; }
            public double? akarsu { get; set; }
            public double? diger { get; set; }
        }

        public class Statistic
        {
            public DateTime tarih { get; set; }
            public double? toplamAvg { get; set; }
            public double? toplamMin { get; set; }
            public double? toplamMax { get; set; }
            public double? toplamSum { get; set; }
            public double? dogalgazAvg { get; set; }
            public double? dogalgazMin { get; set; }
            public double? dogalgazMax { get; set; }
            public double? dogalgazSum { get; set; }
            public double? ruzgarAvg { get; set; }
            public double? ruzgarMin { get; set; }
            public double? ruzgarMax { get; set; }
            public double? ruzgarSum { get; set; }
            public double? linyitAvg { get; set; }
            public double? linyitMin { get; set; }
            public double? linyitMax { get; set; }
            public double? linyitSum { get; set; }
            public double? tasKomurAvg { get; set; }
            public int tasKomurMin { get; set; }
            public int tasKomurMax { get; set; }
            public int tasKomurSum { get; set; }
            public double? ithalKomurAvg { get; set; }
            public int ithalKomurMin { get; set; }
            public int ithalKomurMax { get; set; }
            public int ithalKomurSum { get; set; }
            public double? fuelOilAvg { get; set; }
            public double? fuelOilMin { get; set; }
            public double? fuelOilMax { get; set; }
            public double? fuelOilSum { get; set; }
            public double? jeotermalAvg { get; set; }
            public double? jeotermalMin { get; set; }
            public double? jeotermalMax { get; set; }
            public double? jeotermalSum { get; set; }
            public double? barajliAvg { get; set; }
            public double? barajliMin { get; set; }
            public double? barajliMax { get; set; }
            public double? barajliSum { get; set; }
            public double? naftaAvg { get; set; }
            public int naftaMin { get; set; }
            public int naftaMax { get; set; }
            public int naftaSum { get; set; }
            public double? biokutleAvg { get; set; }
            public double? biokutleMin { get; set; }
            public double? biokutleMax { get; set; }
            public double? biokutleSum { get; set; }
            public double? akarsuAvg { get; set; }
            public double? akarsuMin { get; set; }
            public double? akarsuMax { get; set; }
            public double? akarsuSum { get; set; }
            public double? digerAvg { get; set; }
            public double? digerMin { get; set; }
            public double? digerMax { get; set; }
            public double? digerSum { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, string? bolge, string? organizationEIC, string? uevcbEIC)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/aic?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (bolge != null)
            {
                strReturn += "&bolge=" + bolge;
            }
            if (organizationEIC != null)
            {
                strReturn += "&organizationEIC=" + organizationEIC;
            }
            if (uevcbEIC != null)
            {
                strReturn += "&uevcbEIC=" + uevcbEIC;
            }

            return strReturn;
        }




    }




}
