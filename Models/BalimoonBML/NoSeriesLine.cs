using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class NoSeriesLine
    {
        public int NoSeriesLineId { get; set; }
        public string NoSeriesCode { get; set; }
        public int SeqLineNo { get; set; }
        public DateTime? StartingDate { get; set; }
        public string StartingNo { get; set; }
        public string EndingNo { get; set; }
        public string WarningNo { get; set; }
        public int? IncrementbyNo { get; set; }
        public string LastNoUsed { get; set; }
        public byte? IsOpen { get; set; }
        public DateTime? LastDateUsed { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
