using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class DimensionBuffer
    {
        public int DimensionBufferId { get; set; }
        public string TableName { get; set; }
        public int EntryNo { get; set; }
        public string DimensionCode { get; set; }
        public string DimensionValueCode { get; set; }
        public string NewDimensionValueCode { get; set; }
        public int? SeqLineNo { get; set; }
        public int? NoOfDimensions { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
