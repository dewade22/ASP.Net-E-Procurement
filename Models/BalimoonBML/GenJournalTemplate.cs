using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class GenJournalTemplate
    {
        public int GenJournalTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TestReportId { get; set; }
        public int? FormId { get; set; }
        public int? PostingReportId { get; set; }
        public byte? ForcePostingReport { get; set; }
        public int? Type { get; set; }
        public string SourceCode { get; set; }
        public string ReasonCode { get; set; }
        public byte? Recurring { get; set; }
        public byte? ForceDocBalance { get; set; }
        public int? BalAccountType { get; set; }
        public string BalAccountNo { get; set; }
        public string NoSeries { get; set; }
        public string PostingNoSeries { get; set; }
        public byte? CopyVatsetuptoJnlLines { get; set; }
        public byte? AllowVatdifference { get; set; }
        public int? CustReceiptReportId { get; set; }
        public int? VendorReceiptReportId { get; set; }
        public byte? NotIncreaseBatchName { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
