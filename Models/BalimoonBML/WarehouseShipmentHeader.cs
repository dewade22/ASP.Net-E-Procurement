using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseShipmentHeader
    {
        public int WarehouseShipmentHeaderId { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string AssignedUserId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public DateTime? AssignmentTime { get; set; }
        public int? SortingMethod { get; set; }
        public string NoSeries { get; set; }
        public string BinCode { get; set; }
        public string ZoneCode { get; set; }
        public int? DocumentStatus { get; set; }
        public DateTime? PostingDate { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int? Status { get; set; }
        public string ExternalDocumentNo { get; set; }
        public byte? CreatePostedHeader { get; set; }
        public string ShippingNo { get; set; }
        public string LastShippingNo { get; set; }
        public string ShippingNoSeries { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
