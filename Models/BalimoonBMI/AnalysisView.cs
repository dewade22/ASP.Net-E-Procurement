using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class AnalysisView
    {
        public int AnalysisViewId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? LastEntryNo { get; set; }
        public int? LastBudgetEntryNo { get; set; }
        public DateTime? LastDateUpdated { get; set; }
        public byte? UpdateonPosting { get; set; }
        public byte? Blocked { get; set; }
        public string GlaccountFilter { get; set; }
        public string BusinessUnitFilter { get; set; }
        public DateTime? StartingDate { get; set; }
        public int? DateCompression { get; set; }
        public string Dimension1Code { get; set; }
        public string Dimension2Code { get; set; }
        public string Dimension3Code { get; set; }
        public string Dimension4Code { get; set; }
        public byte? IncludeBudgets { get; set; }
        public byte? RefreshWhenUnblocked { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
