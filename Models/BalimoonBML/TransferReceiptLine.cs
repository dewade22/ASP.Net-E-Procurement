using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class TransferReceiptLine
    {
        public int TransferReceiptLineId { get; set; }
        public int TransferReceiptHeaderId { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public string ItemNo { get; set; }
        public decimal? Quantity { get; set; }
        public string UnitofMeasure { get; set; }
        public string Description { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string InventoryPostingGroup { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? UnitVolume { get; set; }
        public string VariantCode { get; set; }
        public decimal? UnitsperParcel { get; set; }
        public string Description2 { get; set; }
        public string TransferOrderNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string InTransitCode { get; set; }
        public string TransferfromCode { get; set; }
        public string TransfertoCode { get; set; }
        public int? ItemRcptEntryNo { get; set; }
        public string ShippingTime { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string TransfertoBinCode { get; set; }
        public string Division { get; set; }
        public decimal? ActualQtytoReceive { get; set; }
        public decimal? ActualQtytoReceiveBase { get; set; }
        public decimal? QtyDifference { get; set; }
        public decimal? QtyDifferenceBase { get; set; }
        public string ReasonCode { get; set; }
        public short? RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
