using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class FixedAssetLedgerEntry
    {
        public int FixedAssetLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public int? GlentryNo { get; set; }
        public string Fano { get; set; }
        public DateTime? FapostingDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? DocumentType { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentNo { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string Description { get; set; }
        public string DepreciationBookCode { get; set; }
        public int? FapostingCategory { get; set; }
        public int? FapostingType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public byte? ReclassificationEntry { get; set; }
        public byte? PartofBookValue { get; set; }
        public byte? PartofDepreciableBasis { get; set; }
        public int? DisposalCalculationMethod { get; set; }
        public int? DisposalEntryNo { get; set; }
        public int? NoofDepreciationDays { get; set; }
        public decimal? Quantity { get; set; }
        public string FanoBudgetedFano { get; set; }
        public string FasubclassCode { get; set; }
        public string FalocationCode { get; set; }
        public string FapostingGroup { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string LocationCode { get; set; }
        public string UserId { get; set; }
        public int? DepreciationMethod { get; set; }
        public DateTime? DepreciationStartingDate { get; set; }
        public decimal? StraightLinePercent { get; set; }
        public decimal? NoofDepreciationYears { get; set; }
        public decimal? FixedDeprAmount { get; set; }
        public decimal? DecliningBalancePercent { get; set; }
        public string DepreciationTableCode { get; set; }
        public string JournalBatchName { get; set; }
        public string SourceCode { get; set; }
        public string ReasonCode { get; set; }
        public int? TransactionNo { get; set; }
        public int? BalAccountType { get; set; }
        public string BalAccountNo { get; set; }
        public decimal? Vatamount { get; set; }
        public int? GenPostingType { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string FaclassCode { get; set; }
        public decimal? FaexchangeRate { get; set; }
        public decimal? AmountLcy { get; set; }
        public int? ResultonDisposal { get; set; }
        public byte? Correction { get; set; }
        public byte? IndexEntry { get; set; }
        public string CanceledfromFano { get; set; }
        public DateTime? DepreciationEndingDate { get; set; }
        public byte? UseFaledgerCheck { get; set; }
        public byte? AutomaticEntry { get; set; }
        public DateTime? DeprStartingDateCustom1 { get; set; }
        public DateTime? DeprEndingDateCustom1 { get; set; }
        public decimal? AccumDeprPercentCustom1 { get; set; }
        public decimal? DeprPercentthisyearCustom1 { get; set; }
        public int? PropertyClassCustom1 { get; set; }
        public string NoSeries { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public byte? UseTax { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public byte? Reversed { get; set; }
        public int? ReversedbyEntryNo { get; set; }
        public int? ReversedEntryNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
