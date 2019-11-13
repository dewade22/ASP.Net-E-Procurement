using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class RoutingLine
    {
        public int RoutingLineId { get; set; }
        public int? RoutingHeaderId { get; set; }
        public string RoutingNo { get; set; }
        public string VersionCode { get; set; }
        public string OperationNo { get; set; }
        public string NextOperationNo { get; set; }
        public string PreviousOperationNo { get; set; }
        public int? Type { get; set; }
        public string No { get; set; }
        public string WorkCenterNo { get; set; }
        public string WorkCenterGroupCode { get; set; }
        public string Description { get; set; }
        public decimal? SetupTime { get; set; }
        public decimal? RunTime { get; set; }
        public decimal? WaitTime { get; set; }
        public decimal? MoveTime { get; set; }
        public decimal? FixedScrapQuantity { get; set; }
        public decimal? LotSize { get; set; }
        public decimal? ScrapFactorPercent { get; set; }
        public string SetupTimeUnitofMeasCode { get; set; }
        public string RunTimeUnitofMeasCode { get; set; }
        public string WaitTimeUnitofMeasCode { get; set; }
        public string MoveTimeUnitofMeasCode { get; set; }
        public decimal? MinimumProcessTime { get; set; }
        public decimal? MaximumProcessTime { get; set; }
        public decimal? ConcurrentCapacities { get; set; }
        public decimal? SendAheadQuantity { get; set; }
        public string RoutingLinkCode { get; set; }
        public string StandardTaskCode { get; set; }
        public decimal? UnitCostper { get; set; }
        public byte? Recalculate { get; set; }
        public int? SequenceNoForward { get; set; }
        public int? SequenceNoBackward { get; set; }
        public decimal? FixedScrapQtyAccum { get; set; }
        public decimal? ScrapFactorPercentAccumulated { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
