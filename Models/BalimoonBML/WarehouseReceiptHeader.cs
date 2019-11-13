using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseReceiptHeader
    {
        public int WarehouseReceiptHeaderId { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string AssignedUserId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public DateTime? AssignmentTime { get; set; }
        public int? SortingMethod { get; set; }
        public string NoSeries { get; set; }
        public string ZoneCode { get; set; }
        public string BinCode { get; set; }
        public int? DocumentStatus { get; set; }
        public DateTime? PostingDate { get; set; }
        public string VendorShipmentNo { get; set; }
        public string CrossDockZoneCode { get; set; }
        public string CrossDockBinCode { get; set; }
        public byte? CreatePostedHeader { get; set; }
        public string ReceivingNo { get; set; }
        public string LastReceivingNo { get; set; }
        public string ReceivingNoSeries { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
