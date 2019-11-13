using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class InventoryPostingGroup
    {
        public int InventoryPostingGroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte? ForSale { get; set; }
        public byte? ForPurchase { get; set; }
        public byte? ForInventory { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
