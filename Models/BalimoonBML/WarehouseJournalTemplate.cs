using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseJournalTemplate
    {
        public int WarehouseJournalTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TestReportId { get; set; }
        public int? FormId { get; set; }
        public int? RegisteringReportId { get; set; }
        public byte? ForceRegisteringReport { get; set; }
        public int? Type { get; set; }
        public string SourceCode { get; set; }
        public string ReasonCode { get; set; }
        public string NoSeries { get; set; }
        public string RegisteringNoSeries { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
