using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class EmployeeLedgerEntry
    {
        public int EmployeeLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public decimal? RemainingAmountLcy { get; set; }
        public decimal? AmountLcy { get; set; }
        public string EmployeePostingGroup { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string SourceCode { get; set; }
        public int? AppliestoDocType { get; set; }
        public string AppliestoDocNo { get; set; }
        public byte? IsOpen { get; set; }
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
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
