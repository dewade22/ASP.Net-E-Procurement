using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ProductionOrderLine
    {
        public int ProductionOrderLineId { get; set; }
        public int ProductionOrderHeaderId { get; set; }
        public int Status { get; set; }
        public string ProdOrderNo { get; set; }
        public int SeqLineNo { get; set; }
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string LocationCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string BinCode { get; set; }
        public byte? CostisAdjusted { get; set; }
        public byte? AllowOnlineAdjustment { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? FinishedQuantity { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public decimal? ScrapPercent { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? StartingTime { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime? EndingTime { get; set; }
        public int? PlanningLevelCode { get; set; }
        public int? Priority { get; set; }
        public string ProductionBomno { get; set; }
        public string RoutingNo { get; set; }
        public string InventoryPostingGroup { get; set; }
        public int? RoutingReferenceNo { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? CostAmount { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? FinishedQtyBase { get; set; }
        public decimal? RemainingQtyBase { get; set; }
        public byte? CompletelyInvoiced { get; set; }
        public decimal? CurrencyFactor { get; set; }
        public decimal? SingleLevelMaterialCost { get; set; }
        public decimal? SingleLevelCapacityCost { get; set; }
        public decimal? SingleLevelSubcontrdCost { get; set; }
        public decimal? SingleLevelCapOvhdCost { get; set; }
        public decimal? SingleLevelMfgOvhdCost { get; set; }
        public DateTime? StartingDateTime { get; set; }
        public DateTime? EndingDateTime { get; set; }
        public decimal? CostAmountAcy { get; set; }
        public decimal? UnitCostAcy { get; set; }
        public string ProductionBomversionCode { get; set; }
        public string RoutingVersionCode { get; set; }
        public int? RoutingType { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public byte? Mpsorder { get; set; }
        public int? PlanningFlexibility { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public decimal? OverheadRate { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string VendorCode { get; set; }
    }
}
