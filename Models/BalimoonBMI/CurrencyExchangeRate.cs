using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class CurrencyExchangeRate
    {
        public int CurrencyExchangeRateId { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime StartingDate { get; set; }
        public decimal? ExchangeRateAmount { get; set; }
        public decimal? AdjustmentExchRateAmount { get; set; }
        public string RelationalCurrencyCode { get; set; }
        public decimal? RelationalExchRateAmount { get; set; }
        public int? FixExchangeRateAmount { get; set; }
        public decimal? RelationalAdjmtExchRateAmt { get; set; }
        public decimal? RelationalSettRateAmount { get; set; }
        public decimal? SettlementRateAmount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
