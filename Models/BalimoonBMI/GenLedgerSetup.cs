using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class GenLedgerSetup
    {
        public int GenLedgerSetupId { get; set; }
        public DateTime? AllowPostingFrom { get; set; }
        public DateTime? AllowPostingTo { get; set; }
        public byte? RegisterTime { get; set; }
        public byte? PmtDiscExclVat { get; set; }
        public byte? UnrealizedVat { get; set; }
        public byte? AdjustforPaymentDisc { get; set; }
        public byte? MarkCrMemosasCorrections { get; set; }
        public int? LocalAddressFormat { get; set; }
        public decimal? InvRoundingPrecisionLcy { get; set; }
        public int? InvRoundingTypeLcy { get; set; }
        public int? LocalContAddrFormat { get; set; }
        public string BankAccountNos { get; set; }
        public byte? SummarizeGlentries { get; set; }
        public string AmountDecimalPlaces { get; set; }
        public string UnitAmountDecimalPlaces { get; set; }
        public string AdditionalReportingCurrency { get; set; }
        public decimal? VattolerancePercent { get; set; }
        public string Lcycode { get; set; }
        public int? VatexchangeRateAdjustment { get; set; }
        public decimal? AmountRoundingPrecision { get; set; }
        public decimal? UnitAmountRoundingPrecision { get; set; }
        public decimal? ApplnRoundingPrecision { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string ShortcutDimension3Code { get; set; }
        public string ShortcutDimension4Code { get; set; }
        public string ShortcutDimension5Code { get; set; }
        public string ShortcutDimension6Code { get; set; }
        public string ShortcutDimension7Code { get; set; }
        public string ShortcutDimension8Code { get; set; }
        public decimal? MaxVatdifferenceAllowed { get; set; }
        public int? VatroundingType { get; set; }
        public int? PmtDiscTolerancePosting { get; set; }
        public string PaymentDiscountGracePeriod { get; set; }
        public decimal? PaymentTolerancePercent { get; set; }
        public decimal? MaxPaymentToleranceAmount { get; set; }
        public byte? AdaptMainMenutoPermissions { get; set; }
        public DateTime? AllowGlaccDeletionBefore { get; set; }
        public byte? CheckGlaccountUsage { get; set; }
        public int? PaymentTolerancePosting { get; set; }
        public byte? PmtDiscToleranceWarning { get; set; }
        public byte? PaymentToleranceWarning { get; set; }
        public int? LastIctransactionNo { get; set; }
        public int? BilltoSelltoVatcalc { get; set; }
        public byte? PrintVatspecificationinLcy { get; set; }
        public byte? PrepaymentUnrealizedVat { get; set; }
        public byte? BastobeLodgedasaGroup { get; set; }
        public byte? BasgroupCompany { get; set; }
        public decimal? BasgstdivisionFactor { get; set; }
        public byte? AdjustmentMandatory { get; set; }
        public byte? EnableIrdno { get; set; }
        public byte? EnableVatregistrationNo { get; set; }
        public int? AddressValidation { get; set; }
        public int? BarCodeCustomInformation { get; set; }
        public byte? FullGstonPrepayment { get; set; }
        public byte? EnableTaxInvoices { get; set; }
        public byte? PrintTaxInvoicesonPosting { get; set; }
        public byte? ForcePaymentWithInvoice { get; set; }
        public string PostDatedJournalTemplate { get; set; }
        public string PostDatedJournalBatch { get; set; }
        public byte? InterestCalExclVat { get; set; }
        public byte? Gstreport { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
