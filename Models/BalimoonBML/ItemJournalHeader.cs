using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ItemJournalHeader
    {
        public int ItemJournalHeaderId { get; set; }
        public string JournalTemplateName { get; set; }
        public string JournalBatchName { get; set; }
        public string DocumentNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public string LocationCode { get; set; }
        public string SourceCode { get; set; }
        public string Department { get; set; }
        public string JournalDescription { get; set; }
        public int? ItemJournalHeaderStatus { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string ProdOrderNo { get; set; }
        public int? ProdOrderSeqLineNo { get; set; }
    }
}
