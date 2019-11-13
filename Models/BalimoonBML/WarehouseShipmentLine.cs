using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseShipmentLine
    {
        public int WarehouseShipmentLineId { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubtype { get; set; }
        public string SourceNo { get; set; }
        public int? SourceSeqLineNo { get; set; }
        public int? SourceDocument { get; set; }
        public string LocationCode { get; set; }
        public string ShelfNo { get; set; }
        public string BinCode { get; set; }
        public string ZoneCode { get; set; }
        public string ItemNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBase { get; set; }
        public decimal? QtyOutstanding { get; set; }
        public decimal? QtyOutstandingBase { get; set; }
        public decimal? QtytoShip { get; set; }
        public decimal? QtytoShipBase { get; set; }
        public decimal? QtyPicked { get; set; }
        public decimal? QtyPickedBase { get; set; }
        public decimal? QtyShipped { get; set; }
        public decimal? QtyShippedBase { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int? Status { get; set; }
        public int? SortingSequenceNo { get; set; }
        public DateTime? DueDate { get; set; }
        public int? DestinationType { get; set; }
        public string DestinationNo { get; set; }
        public decimal? Cubage { get; set; }
        public decimal? Weight { get; set; }
        public int? ShippingAdvice { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public byte? CompletelyPicked { get; set; }
        public byte? NotupdbySrcDocPost { get; set; }
        public int? PostingfromWhseRef { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
