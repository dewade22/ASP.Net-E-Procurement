using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class StockRequisitionLine
    {
        public int StockRequisitionLineId { get; set; }
        public int StockRequisitionHeaderId { get; set; }
        public string DocumentNo { get; set; }
        public int DocumentType { get; set; }
        public int SeqLineNo { get; set; }
        public string RecordNo { get; set; }
        public string FromLocationCode { get; set; }
        public string ToLocationCode { get; set; }
        public string PostingGroup { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitofMeasure { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? OutstandingQuantity { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Amount { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public decimal? QuantityDelivery { get; set; }
        public string DeliveryNo { get; set; }
        public int? DeliveryLineNo { get; set; }
        public string ProdOrderNo { get; set; }
        public string ProdOrderLineNo { get; set; }
        public int? ProdOrderCompLineNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? OutstandingQtyBase { get; set; }
        public decimal? QtyDeliveryBase { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte? Nonstock { get; set; }
        public string ProductGroupCode { get; set; }
        public byte? CompletelyDelivery { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string ItemNo { get; set; }
    }
}
