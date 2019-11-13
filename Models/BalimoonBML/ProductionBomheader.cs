using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ProductionBomheader
    {
        public int ProductionBomheaderId { get; set; }
        public string ProductionBomheaderNo { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitofMeasureCode { get; set; }
        public int? LowLevelCode { get; set; }
        public int? ProductionBomheaderStatus { get; set; }
        public string VersionNos { get; set; }
        public string NoSeries { get; set; }
        public int? Bomtype { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
