using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class MachineCenter
    {
        public int MachineCenterId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string SearchName { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string WorkCenterNo { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? QueueTime { get; set; }
        public string QueueTimeUnitofMeasCode { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? Efficiency { get; set; }
        public decimal? MaximumEfficiency { get; set; }
        public decimal? MinimumEfficiency { get; set; }
        public byte? Blocked { get; set; }
        public decimal? SetupTime { get; set; }
        public decimal? WaitTime { get; set; }
        public decimal? MoveTime { get; set; }
        public decimal? FixedScrapQuantity { get; set; }
        public decimal? ScrapPercent { get; set; }
        public string SetupTimeUnitofMeasCode { get; set; }
        public string WaitTimeUnitofMeasCode { get; set; }
        public decimal? SendAheadQuantity { get; set; }
        public string MoveTimeUnitofMeasCode { get; set; }
        public int? FlushingMethod { get; set; }
        public decimal? MinimumProcessTime { get; set; }
        public decimal? MaximumProcessTime { get; set; }
        public decimal? ConcurrentCapacities { get; set; }
        public string NoSeries { get; set; }
        public decimal? OverheadRate { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string Country { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
