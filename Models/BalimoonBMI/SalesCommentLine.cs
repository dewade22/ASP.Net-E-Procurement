using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class SalesCommentLine
    {
        public int SalesCommentLineId { get; set; }
        public int DocumentType { get; set; }
        public string No { get; set; }
        public int DocumentSeqLineNo { get; set; }
        public int SeqLineNo { get; set; }
        public DateTime? Date { get; set; }
        public string Code { get; set; }
        public string Comment { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
