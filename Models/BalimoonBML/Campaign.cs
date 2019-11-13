using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Campaign
    {
        public int CampaignId { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public string SalespersonCode { get; set; }
        public string NoSeries { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string StatusCode { get; set; }
        public DateTime? SellinginStartDate { get; set; }
        public DateTime? SellinginEndDate { get; set; }
        public DateTime? VisibleDate { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
