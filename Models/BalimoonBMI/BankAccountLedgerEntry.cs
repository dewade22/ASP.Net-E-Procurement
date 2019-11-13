using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class BankAccountLedgerEntry
    {
        public int BankAccountLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public string BankAccountNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public decimal? AmountLcy { get; set; }
        public string BankAccPostingGroup { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string OurContactCode { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public byte? IsOpen { get; set; }
        public byte? Positive { get; set; }
        public int? ClosedbyEntryNo { get; set; }
        public DateTime? ClosedatDate { get; set; }
        public string JournalBatchName { get; set; }
        public string ReasonCode { get; set; }
        public int? BalAccountType { get; set; }
        public string BalAccountNo { get; set; }
        public int? TransactionNo { get; set; }
        public int? StatementStatus { get; set; }
        public string StatementNo { get; set; }
        public int? StatementSeqLineNo { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmountLcy { get; set; }
        public decimal? CreditAmountLcy { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
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
