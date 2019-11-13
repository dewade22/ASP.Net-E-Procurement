using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class Currency
    {
        public int CurrencyId { get; set; }
        public string Code { get; set; }
        public DateTime? LastDateAdjusted { get; set; }
        public string UnrealizedGainsAcc { get; set; }
        public string RealizedGainsAcc { get; set; }
        public string UnrealizedLossesAcc { get; set; }
        public string RealizedLossesAcc { get; set; }
        public int? InvoiceRoundingPrecision { get; set; }
        public int? InvoiceRoundingType { get; set; }
        public int? AmountRoundingPrecision { get; set; }
        public int? UnitAmountRoundingPrecision { get; set; }
        public string Description { get; set; }
        public string AmountDecimalPlaces { get; set; }
        public string UnitAmountDecimalPlaces { get; set; }
        public string RealizedGlgainsAccount { get; set; }
        public string RealizedGllossesAccount { get; set; }
        public int? ApplnRoundingPrecision { get; set; }
        public byte? Emucurrency { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public string ResidualGainsAccount { get; set; }
        public string ResidualLossesAccount { get; set; }
        public string ConvLcyrndgDebitAcc { get; set; }
        public string ConvLcyrndgCreditAcc { get; set; }
        public decimal? MaxVatdifferenceAllowed { get; set; }
        public int? VatroundingType { get; set; }
        public decimal? PaymentTolerancePercent { get; set; }
        public decimal? MaxPaymentToleranceAmount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
