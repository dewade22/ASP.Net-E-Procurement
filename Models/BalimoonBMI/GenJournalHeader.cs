using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class GenJournalHeader
    {
        public int GenJournalHeaderId { get; set; }
        public string JournalTemplateName { get; set; }
        public string JournalBatchName { get; set; }
        public string DocumentNo { get; set; }
        public int? DocStatus { get; set; }
        public string SourceCode { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string JournalDescription { get; set; }
        public int? AccountType { get; set; }
        public string AccountNo { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public DateTime? PostingDate { get; set; }
    }
}
