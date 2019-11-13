using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class WarehouseShipmentPostedHeader
    {
        public int WarehouseShipmentPostedHeaderId { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string AssignedUserId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public DateTime? AssignmentTime { get; set; }
        public string NoSeries { get; set; }
        public string BinCode { get; set; }
        public string ZoneCode { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string WhseShipmentNo { get; set; }
        public string ExternalDocumentNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
