using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasModels
{
    public static class definitionValues
    {
        public enum type { DAILY, WEEKLY, MONTHLY, YEAR, QUARTER };

        public enum period { DAILY, WEEKLY, MONTHLY, PERIODIC };

        public enum offerType { HOURLY, BLOCK };

        public enum source { FUEL_OIL, MOTORIN, TAS_KOMUR, LINYIT, JEOTERMAL, DOGAL_GAZ, AKARSU, BARAJLI, LNG, BIYOKUTLE, ITHAL_KOMUR, ASFALTIT_KOMUR, RUZGAR, NUKLEER, GUNES, NAFTA, ULUSLARARASI, ATIKISI, ALL };

        public enum messageTypeId { SANTRAL_ARIZASI = 0, SANTRAL_BAKIM = 2 };

        public enum pointType { INPUT, OUTPUT };

        public enum priceType { GAS_REFERENCE, ADDITIONAL_BALANCING_PURCHASE, ADDITIONAL_BALANCING_SALE, BALANCING_GAS_PURCHASE, BALANCING_GAS_SALE, DAY_AHEAD, WEEKLY_GAS_REFERENCE };

        public enum orderType { YAL, YAT, YAL_YAT };

        public enum serviceName { DIP, CONTRACT_PRICE_SUMMARY, TRADE_VALUE, MATCHING_AMOUNT, OPEN_POSITION, TRANSACTION_HISTORY };



    }
}
