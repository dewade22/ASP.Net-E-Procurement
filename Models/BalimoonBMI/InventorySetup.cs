using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class InventorySetup
    {
        public int InventorySetupId { get; set; }
        public byte? AutomaticCostPosting { get; set; }
        public byte? LocationMandatory { get; set; }
        public string ItemNos { get; set; }
        public int? AutomaticCostAdjustment { get; set; }
        public string TransferOrderNos { get; set; }
        public string PostedTransferShptNos { get; set; }
        public string PostedTransferRcptNos { get; set; }
        public byte? CopyCommentsOrdertoShpt { get; set; }
        public byte? CopyCommentsOrdertoRcpt { get; set; }
        public string NonstockItemNos { get; set; }
        public string OutboundWhseHandlingTime { get; set; }
        public string InboundWhseHandlingTime { get; set; }
        public byte? ExpectedCostPostingtoGl { get; set; }
        public int? AverageCostCalcType { get; set; }
        public int? AverageCostPeriod { get; set; }
        public string ItemGroupDimensionCode { get; set; }
        public string InventoryPutawayNos { get; set; }
        public string InventoryPickNos { get; set; }
        public string PostedInvtPutawayNos { get; set; }
        public string PostedInvtPickNos { get; set; }
        public string KitBomnos { get; set; }
        public byte? AutomaticBuildKitBom { get; set; }
        public int? ComponentsonPickTickets { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string Dimension01Code { get; set; }
        public string Dimension02Code { get; set; }
        public string Dimension03Code { get; set; }
        public string Dimension04Code { get; set; }
        public string Dimension05Code { get; set; }
        public string Dimension06Code { get; set; }
        public string Dimension07Code { get; set; }
        public string Dimension08Code { get; set; }
        public string Dimension09Code { get; set; }
        public string Dimension10Code { get; set; }
    }
}
