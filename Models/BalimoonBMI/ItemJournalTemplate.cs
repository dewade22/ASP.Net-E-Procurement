using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemJournalTemplate
    {
        public int ItemJournalTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TestReportName { get; set; }
        public string FormName { get; set; }
        public string PostingReportName { get; set; }
        public byte? ForcePostingReport { get; set; }
        public int? Type { get; set; }
        public string SourceCode { get; set; }
        public string ReasonCode { get; set; }
        public byte? Recurring { get; set; }
        public string NoSeries { get; set; }
        public string PostingNoSeries { get; set; }
        public string WhseRegisterReportName { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
