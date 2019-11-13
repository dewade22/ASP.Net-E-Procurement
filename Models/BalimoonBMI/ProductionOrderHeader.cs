using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ProductionOrderHeader
    {
        public int ProductionOrderHeaderId { get; set; }
        public int Status { get; set; }
        public string ProdOrderNo { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int? SourceType { get; set; }
        public string SourceNo { get; set; }
        public string RoutingNo { get; set; }
        public string InventoryPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string GenBusPostingGroup { get; set; }
        public DateTime? StartingTime { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingTime { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public byte? Blocked { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string LocationCode { get; set; }
        public string BinCode { get; set; }
        public string ReplanRefNo { get; set; }
        public int? ReplanRefStatus { get; set; }
        public int? LowLevelCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? CostAmount { get; set; }
        public string NoSeries { get; set; }
        public string PlannedOrderNo { get; set; }
        public string FirmPlannedOrderNo { get; set; }
        public string SimulatedOrderNo { get; set; }
        public DateTime? StartingDateTime { get; set; }
        public DateTime? EndingDateTime { get; set; }
        public string AssignedUserId { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
