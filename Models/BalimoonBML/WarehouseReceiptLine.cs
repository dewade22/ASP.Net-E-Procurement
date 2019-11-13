using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseReceiptLine
    {
        public int WarehouseReceiptLineId { get; set; }
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
        public decimal? QtytoReceive { get; set; }
        public decimal? QtytoReceiveBase { get; set; }
        public decimal? QtyReceived { get; set; }
        public decimal? QtyReceivedBase { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int? Status { get; set; }
        public int? SortingSequenceNo { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartingDate { get; set; }
        public decimal? Cubage { get; set; }
        public decimal? Weight { get; set; }
        public byte? NotupdbySrcDocPost { get; set; }
        public int? PostingfromWhseRef { get; set; }
        public decimal? QtytoCrossDock { get; set; }
        public decimal? QtytoCrossDockBase { get; set; }
        public string CrossDockZoneCode { get; set; }
        public string CrossDockBinCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
