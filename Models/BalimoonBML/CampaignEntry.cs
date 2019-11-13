using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CampaignEntry
    {
        public int CampaignEntryId { get; set; }
        public int EntryNo { get; set; }
        public string CampaignNo { get; set; }
        public string Description { get; set; }
        public DateTime? PostingDate { get; set; }
        public string SegmentNo { get; set; }
        public byte? Canceled { get; set; }
        public string SalespersonCode { get; set; }
        public int? RegisterNo { get; set; }
        public int? DocumentType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
