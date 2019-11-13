using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ProductionBomline
    {
        public int ProductionBomlineId { get; set; }
        public int ProductionBomheaderId { get; set; }
        public string ProductionBomno { get; set; }
        public string VersionCode { get; set; }
        public int SeqLineNo { get; set; }
        public int? RecordType { get; set; }
        public string RecordNo { get; set; }
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
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Depth { get; set; }
        public int? CalculationFormula { get; set; }
        public decimal? Quantityper { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
