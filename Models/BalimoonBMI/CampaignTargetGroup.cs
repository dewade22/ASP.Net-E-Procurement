using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class CampaignTargetGroup
    {
        public int CampaignTargetGroupId { get; set; }
        public int Type { get; set; }
        public string No { get; set; }
        public string CampaignNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
