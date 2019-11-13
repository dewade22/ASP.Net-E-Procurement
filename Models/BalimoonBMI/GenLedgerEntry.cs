using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class GenLedgerEntry
    {
        public int GenLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public string GenLedgerAccountNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string BalAccountNo { get; set; }
        public string JournalDescription { get; set; }
        public decimal? Amount { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public byte? PriorYearEntry { get; set; }
        public string JobNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Vatamount { get; set; }
        public string BusinessUnitCode { get; set; }
        public string JournalBatchName { get; set; }
        public string ReasonCode { get; set; }
        public int? GenPostingType { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int? BalAccountType { get; set; }
        public int? TransactionNo { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public int? SourceType { get; set; }
        public string SourceNo { get; set; }
        public string NoSeries { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public byte? UseTax { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public decimal? AdditionalCurrencyAmount { get; set; }
        public decimal? AddCurrencyDebitAmount { get; set; }
        public decimal? AddCurrencyCreditAmount { get; set; }
        public int? CloseIncomeStatementDimId { get; set; }
        public string IcpartnerCode { get; set; }
        public byte? Reversed { get; set; }
        public int? ReversedbyEntryNo { get; set; }
        public int? ReversedEntryNo { get; set; }
        public string ProdOrderNo { get; set; }
        public int? FaentryType { get; set; }
        public int? FaentryNo { get; set; }
        public string BatchNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
