using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemJournalBatch
    {
        public int ItemJournalBatchId { get; set; }
        public string JournalTemplateName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ReasonCode { get; set; }
        public string NoSeries { get; set; }
        public string PostingNoSeries { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
