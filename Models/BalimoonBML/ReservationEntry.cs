using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ReservationEntry
    {
        public int ReservationEntryId { get; set; }
        public int EntryNo { get; set; }
        public byte Positive { get; set; }
        public string ItemNo { get; set; }
        public string LocationCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public int? ReservationStatus { get; set; }
        public string Description { get; set; }
        public int? TransferredfromEntryNo { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubtype { get; set; }
        public string SourceId { get; set; }
        public string SourceBatchName { get; set; }
        public int? SourceProdOrderLine { get; set; }
        public int? SourceRefNo { get; set; }
        public int? AppltoItemEntry { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string SerialNo { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public decimal? Quantity { get; set; }
        public int? Binding { get; set; }
        public byte? SuppressedActionMsg { get; set; }
        public int? PlanningFlexibility { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? QtytoHandleBase { get; set; }
        public decimal? QtytoInvoiceBase { get; set; }
        public decimal? QuantityInvoicedBase { get; set; }
        public decimal? ReservedPickandShipQty { get; set; }
        public string NewSerialNo { get; set; }
        public string NewLotNo { get; set; }
        public string LotNo { get; set; }
        public string VariantCode { get; set; }
        public int? ApplfromItemEntry { get; set; }
        public byte? Correction { get; set; }
        public DateTime? NewExpirationDate { get; set; }
        public int? ItemTracking { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
