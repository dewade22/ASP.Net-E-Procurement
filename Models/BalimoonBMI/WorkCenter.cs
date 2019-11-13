using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class WorkCenter
    {
        public int WorkCenterId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string SearchName { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string AlternateWorkCenter { get; set; }
        public string WorkCenterGroupCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string SubcontractorNo { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? QueueTime { get; set; }
        public string QueueTimeUnitofMeasCode { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? Efficiency { get; set; }
        public decimal? MaximumEfficiency { get; set; }
        public decimal? MinimumEfficiency { get; set; }
        public decimal? CalendarRoundingPrecision { get; set; }
        public int? SimulationType { get; set; }
        public string ShopCalendarCode { get; set; }
        public byte? Blocked { get; set; }
        public int? UnitCostCalculation { get; set; }
        public byte? SpecificUnitCost { get; set; }
        public byte? ConsolidatedCalendar { get; set; }
        public int? FlushingMethod { get; set; }
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
