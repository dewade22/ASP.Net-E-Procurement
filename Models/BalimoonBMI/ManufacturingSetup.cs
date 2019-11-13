using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ManufacturingSetup
    {
        public int ManufacturingSetupId { get; set; }
        public TimeSpan? NormalStartingTime { get; set; }
        public TimeSpan? NormalEndingTime { get; set; }
        public byte? DocNoIsProdOrderNo { get; set; }
        public byte? CostInclSetup { get; set; }
        public byte? DynamicLowLevelCode { get; set; }
        public byte? PlanningWarning { get; set; }
        public string SimulatedOrderNos { get; set; }
        public string PlannedOrderNos { get; set; }
        public string FirmPlannedOrderNos { get; set; }
        public string ReleasedOrderNos { get; set; }
        public string WorkCenterNos { get; set; }
        public string MachineCenterNos { get; set; }
        public string ProductionBomnos { get; set; }
        public string RoutingNos { get; set; }
        public string CurrentProductionForecast { get; set; }
        public byte? UseForecastonLocations { get; set; }
        public byte? CombinedMpsmrpcalculation { get; set; }
        public string ComponentsatLocation { get; set; }
        public string DampenerTime { get; set; }
        public decimal? DampenerPercentofLotSize { get; set; }
        public string DefaultSafetyLeadTime { get; set; }
        public int? PresetOutputQuantity { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
