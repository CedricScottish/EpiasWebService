using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels.Production
{
    /// <summary>
    /// 1.118. Piyasa Mesaj Sistem Rest Servisi
    /// </summary>
    public class urgentMarketMessageResponse
    {
        public string resultCode { get; set; }
        public string resultDescription { get; set; }
        public Body body { get; set; }


        public class Body
        {
            public Urgentmarketmessagelist[] urgentMarketMessageList { get; set; }
        }

        public class Urgentmarketmessagelist
        {
            public int id { get; set; }
            public DateTime caseAddDate { get; set; }
            public DateTime caseStartDate { get; set; }
            public DateTime caseEndDate { get; set; }
            public string powerPlantName { get; set; }
            public int messageType { get; set; }
            public string region { get; set; }
            public double? capacityAtCaseTime { get; set; }
            public object caseVaguenessTime { get; set; }
            public int validityStatus { get; set; }
            public string reason { get; set; }
            public double? operatorPower { get; set; }
            public string uevcbName { get; set; }
            public string fuelType { get; set; }
            public int fuelTypeId { get; set; }
            public string city { get; set; }
            public int cityId { get; set; }
            public Faultdetail[] faultDetails { get; set; }
            public string orgName { get; set; }
        }

        public class Faultdetail
        {
            public int hour { get; set; }
            public double? remainingCapacity { get; set; }
            public DateTime date { get; set; }
            public double? preFaultPower { get; set; }
            public double? faultCausedPowerLoss { get; set; }
            public double? faultCausedEnergyLoss { get; set; }
        }

        public string getURL(DateTime startDate, DateTime endDate, definitionValues.messageTypeId? messageTypeId, string? organizationEIC, int? regionId, int? uevcbId)
        {
            string strReturn = @"https://seffaflik.epias.com.tr/transparency/service/production/urgent-market-message?startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd");

            if (messageTypeId != null)
            {
                strReturn += "&messageTypeId=" + Convert.ToInt64(messageTypeId);
            }

            if (organizationEIC != null)
            {
                strReturn += "&organizationEIC=" + organizationEIC.ToString();
            }

            if (regionId != null)
            {
                strReturn += "&regionId=" + regionId.ToString();
            }
            if (uevcbId != null)
            {
                strReturn += "&uevcbId=" + uevcbId.ToString();
            }


            return strReturn;
        }




    }






}
