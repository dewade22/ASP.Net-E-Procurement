using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ProductionOrderComponent
    {
        public int ProductionOrderComponentId { get; set; }
        public int ProductionOrderLineId { get; set; }
        public int Status { get; set; }
        public string ProdOrderNo { get; set; }
        public int ProdOrderLineNo { get; set; }
        public int SeqLineNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? Quantity { get; set; }
        public string Position { get; set; }
        public string Position2 { get; set; }
        public string Position3 { get; set; }
        public string ProductionLeadTime { get; set; }
        public string RoutingLinkCode { get; set; }
        public decimal? ScrapPercent { get; set; }
        public string VariantCode { get; set; }
        public decimal? ExpectedQuantity { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public int? FlushingMethod { get; set; }
        public string LocationCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string BinCode { get; set; }
        public int? SuppliedbySeqLineNo { get; set; }
        public int? PlanningLevelCode { get; set; }
        public int? ItemLowLevelCode { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Depth { get; set; }
        public int? CalculationFormula { get; set; }
        public decimal? Quantityper { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? CostAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueTime { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public decimal? RemainingQtyBase { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? ExpectedQtyBase { get; set; }
        public DateTime? DueDateTime { get; set; }
        public string OriginalItemNo { get; set; }
        public string OriginalVariantCode { get; set; }
        public decimal? QtyPicked { get; set; }
        public decimal? QtyPickedBase { get; set; }
        public byte? CompletelyPicked { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public decimal? OverheadRate { get; set; }
        public decimal? DirectCostAmount { get; set; }
        public decimal? OverheadAmount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
