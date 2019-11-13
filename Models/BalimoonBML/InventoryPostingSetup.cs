using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class InventoryPostingSetup
    {
        public int InventoryPostingSetupId { get; set; }
        public string LocationCode { get; set; }
        public string InvtPostingGroupCode { get; set; }
        public string InventoryAccount { get; set; }
        public string InventoryAccountInterim { get; set; }
        public string Wipaccount { get; set; }
        public string MaterialVarianceAccount { get; set; }
        public string CapacityVarianceAccount { get; set; }
        public string MfgOverheadVarianceAccount { get; set; }
        public string CapOverheadVarianceAccount { get; set; }
        public string SubcontractedVarianceAccount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
