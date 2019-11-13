using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class StockkeepingUnit
    {
        public int StockkeepingUnitId { get; set; }
        public string LocationCode { get; set; }
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string ShelfNo { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? LastDirectCost { get; set; }
        public string VendorNo { get; set; }
        public string VendorItemNo { get; set; }
        public string LeadTimeCalculation { get; set; }
        public decimal? ReorderPoint { get; set; }
        public decimal? MaximumInventory { get; set; }
        public decimal? ReorderQuantity { get; set; }
        public int? TransferLevelCode { get; set; }
        public decimal? LotSize { get; set; }
        public int? DiscreteOrderQuantity { get; set; }
        public decimal? MinimumOrderQuantity { get; set; }
        public decimal? MaximumOrderQuantity { get; set; }
        public decimal? SafetyStockQuantity { get; set; }
        public decimal? OrderMultiple { get; set; }
        public string SafetyLeadTime { get; set; }
        public string ComponentsatLocation { get; set; }
        public int? FlushingMethod { get; set; }
        public int? ReplenishmentSystem { get; set; }
        public string ReorderCycle { get; set; }
        public int? ReorderingPolicy { get; set; }
        public byte? IncludeInventory { get; set; }
        public int? ManufacturingPolicy { get; set; }
        public string TransferfromCode { get; set; }
        public string SpecialEquipmentCode { get; set; }
        public string PutawayTemplateCode { get; set; }
        public string PutawayUnitofMeasureCode { get; set; }
        public string PhysInvtCountingPeriodCode { get; set; }
        public DateTime? LastCountingPeriodUpdate { get; set; }
        public string NextCountingPeriod { get; set; }
        public byte? UseCrossDocking { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
