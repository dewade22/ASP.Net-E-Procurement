using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CvledgerEntryBuffer
    {
        public int CvledgerEntryBufferId { get; set; }
        public int EntryNo { get; set; }
        public string Cvno { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public decimal? OriginalAmtLcy { get; set; }
        public decimal? RemainingAmtLcy { get; set; }
        public decimal? AmountLcy { get; set; }
        public decimal? SalesPurchaseLcy { get; set; }
        public decimal? ProfitLcy { get; set; }
        public decimal? InvDiscountLcy { get; set; }
        public string BilltoPaytoCvno { get; set; }
        public string CvpostingGroup { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string SalespersonCode { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string OnHold { get; set; }
        public int? AppliestoDocType { get; set; }
        public string AppliestoDocNo { get; set; }
        public byte? Open { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PmtDiscountDate { get; set; }
        public decimal? OriginalPmtDiscPossible { get; set; }
        public decimal? PmtDiscGivenLcy { get; set; }
        public byte? Positive { get; set; }
        public int? ClosedbyEntryNo { get; set; }
        public DateTime? ClosedatDate { get; set; }
        public decimal? ClosedbyAmount { get; set; }
        public string AppliestoId { get; set; }
        public string JournalBatchName { get; set; }
        public string ReasonCode { get; set; }
        public int? BalAccountType { get; set; }
        public string BalAccountNo { get; set; }
        public int? TransactionNo { get; set; }
        public decimal? ClosedbyAmountLcy { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmountLcy { get; set; }
        public decimal? CreditAmountLcy { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public byte? CalculateInterest { get; set; }
        public byte? ClosingInterestCalculated { get; set; }
        public string NoSeries { get; set; }
        public string ClosedbyCurrencyCode { get; set; }
        public decimal? ClosedbyCurrencyAmount { get; set; }
        public string RoundingCurrency { get; set; }
        public decimal? RoundingAmount { get; set; }
        public decimal? RoundingAmountLcy { get; set; }
        public decimal? AdjustedCurrencyFactor { get; set; }
        public decimal? OriginalCurrencyFactor { get; set; }
        public decimal? OriginalAmount { get; set; }
        public decimal? RemainingPmtDiscPossible { get; set; }
        public DateTime? PmtDiscToleranceDate { get; set; }
        public decimal? MaxPaymentTolerance { get; set; }
        public decimal? AcceptedPaymentTolerance { get; set; }
        public byte? AcceptedPmtDiscTolerance { get; set; }
        public decimal? PmtToleranceLcy { get; set; }
        public decimal? AmounttoApply { get; set; }
        public byte? Prepayment { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
