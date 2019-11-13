using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PhysInvtItemSelection
    {
        public int PhysInvtItemSelectionId { get; set; }
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string LocationCode { get; set; }
        public string PhysInvtCountingPeriodCode { get; set; }
        public string ShelfNo { get; set; }
        public DateTime? LastCountingDate { get; set; }
        public string NextCountingPeriod { get; set; }
        public int? CountFrequencyperYear { get; set; }
        public byte? Selected { get; set; }
        public int? PhysInvtCountingPeriodType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
