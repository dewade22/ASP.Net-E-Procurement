using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class WarehouseSetup
    {
        public int WarehouseSetupId { get; set; }
        public string WhseReceiptNos { get; set; }
        public string WhsePutawayNos { get; set; }
        public string WhsePickNos { get; set; }
        public string WhseShipNos { get; set; }
        public string RegisteredWhsePickNos { get; set; }
        public string RegisteredWhsePutawayNos { get; set; }
        public byte? RequireReceive { get; set; }
        public byte? RequirePutaway { get; set; }
        public byte? RequirePick { get; set; }
        public byte? RequireShipment { get; set; }
        public int? LastWhsePostingRefNo { get; set; }
        public int? ReceiptPostingPolicy { get; set; }
        public int? ShipmentPostingPolicy { get; set; }
        public string PostedWhseReceiptNos { get; set; }
        public string PostedWhseShipmentNos { get; set; }
        public string WhseInternalPutawayNos { get; set; }
        public string WhseInternalPickNos { get; set; }
        public string WhseMovementNos { get; set; }
        public string RegisteredWhseMovementNos { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
