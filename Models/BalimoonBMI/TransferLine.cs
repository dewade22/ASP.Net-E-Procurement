using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class TransferLine
    {
        public int TransferLineId { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public string ItemNo { get; set; }
        public decimal? Quantity { get; set; }
        public string UnitofMeasure { get; set; }
        public decimal? QtytoShip { get; set; }
        public decimal? QtytoReceive { get; set; }
        public decimal? QuantityShipped { get; set; }
        public decimal? QuantityReceived { get; set; }
        public int? Status { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string Description { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string InventoryPostingGroup { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? OutstandingQtyBase { get; set; }
        public decimal? QtytoShipBase { get; set; }
        public decimal? QtyShippedBase { get; set; }
        public decimal? QtytoReceiveBase { get; set; }
        public decimal? QtyReceivedBase { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? OutstandingQuantity { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? UnitVolume { get; set; }
        public string VariantCode { get; set; }
        public decimal? UnitsperParcel { get; set; }
        public string Description2 { get; set; }
        public string InTransitCode { get; set; }
        public decimal? QtyinTransit { get; set; }
        public decimal? QtyinTransitBase { get; set; }
        public string TransferfromCode { get; set; }
        public string TransfertoCode { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? DerivedFromSeqLineNo { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ShippingTime { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ProductGroupCode { get; set; }
        public byte? CompletelyShipped { get; set; }
        public byte? CompletelyReceived { get; set; }
        public string OutboundWhseHandlingTime { get; set; }
        public string InboundWhseHandlingTime { get; set; }
        public string TransferfromBinCode { get; set; }
        public string TransfertoBinCode { get; set; }
        public string Division { get; set; }
        public decimal? ActualQtytoReceive { get; set; }
        public decimal? ActualQtytoReceiveBase { get; set; }
        public decimal? QtyDifference { get; set; }
        public decimal? QtyDifferenceBase { get; set; }
        public int? InStoreDocumentStatus { get; set; }
        public string ReasonCode { get; set; }
        public int? TransferType { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string ConfigurationId { get; set; }
        public int? PlanningFlexibility { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
