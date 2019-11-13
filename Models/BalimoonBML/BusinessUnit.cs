using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class BusinessUnit
    {
        public int BusinessUnitId { get; set; }
        public string Code { get; set; }
        public byte Consolidate { get; set; }
        public decimal ConsolidationPercent { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public decimal IncomeCurrencyFactor { get; set; }
        public decimal BalanceCurrencyFactor { get; set; }
        public string ExchRateLossesAcc { get; set; }
        public string ExchRateGainsAcc { get; set; }
        public string ResidualAccount { get; set; }
        public decimal LastBalanceCurrencyFactor { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CompExchRateGainsAcc { get; set; }
        public string CompExchRateLossesAcc { get; set; }
        public string EquityExchRateGainsAcc { get; set; }
        public string EquityExchRateLossesAcc { get; set; }
        public string MinorityExchRateGainsAcc { get; set; }
        public string MinorityExchRateLossesAcc { get; set; }
        public int CurrencyExchangeRateTable { get; set; }
        public int DataSource { get; set; }
        public int FileFormat { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
