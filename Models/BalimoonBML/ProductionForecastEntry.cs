using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ProductionForecastEntry
    {
        public int ProductionForecastEntryId { get; set; }
        public int EntryNo { get; set; }
        public string ProductionForecastName { get; set; }
        public string ItemNo { get; set; }
        public DateTime? ForecastDate { get; set; }
        public decimal? ForecastQuantity { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public decimal? ForecastQuantityBase { get; set; }
        public string LocationCode { get; set; }
        public byte? ComponentForecast { get; set; }
        public string Description { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
