using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class WarehouseReceiptPostedLine
    {
        public int WarehouseReceiptPostedLineId { get; set; }
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
        public decimal? QtyPutAway { get; set; }
        public decimal? QtyPutAwayBase { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartingDate { get; set; }
        public decimal? QtyCrossDocked { get; set; }
        public decimal? QtyCrossDockedBase { get; set; }
        public string CrossDockZoneCode { get; set; }
        public string CrossDockBinCode { get; set; }
        public int? PostedSourceDocument { get; set; }
        public string PostedSourceNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public string VendorShipmentNo { get; set; }
        public string WhseReceiptNo { get; set; }
        public int? WhseReceiptSeqLineNo { get; set; }
        public int? Status { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
