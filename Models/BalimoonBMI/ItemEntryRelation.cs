using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemEntryRelation
    {
        public int ItemEntryRelationId { get; set; }
        public int ItemEntryNo { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubtype { get; set; }
        public string SourceId { get; set; }
        public string SourceBatchName { get; set; }
        public int? SourceProdOrderLine { get; set; }
        public int? SourceRefNo { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public string OrderNo { get; set; }
        public int? OrderSeqLineNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
