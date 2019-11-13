using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class CheckLedgerEntry
    {
        public int CheckLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public string BankAccountNo { get; set; }
        public int? BankAccountLedgerEntryNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckNo { get; set; }
        public int? CheckType { get; set; }
        public int? BankPaymentType { get; set; }
        public int? EntryStatus { get; set; }
        public int? OriginalEntryStatus { get; set; }
        public int? BalAccountType { get; set; }
        public string BalAccountNo { get; set; }
        public byte? IsOpen { get; set; }
        public int? StatementStatus { get; set; }
        public string StatementNo { get; set; }
        public int? StatementSeqLineNo { get; set; }
        public string UserId { get; set; }
        public string ExternalDocumentNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
