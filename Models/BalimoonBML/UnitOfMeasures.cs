using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class UnitOfMeasures
    {
        public int UnitOfMeasureId { get; set; }
        public string Uomcode { get; set; }
        public string Uomdescription { get; set; }
        public bool? DefaultUnitOfMeasure { get; set; }
        public byte? WeightUnitOfMeasure { get; set; }
        public decimal? PosminDenominator { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
