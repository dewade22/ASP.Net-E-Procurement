using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class RoutingQualityMeasure
    {
        public int RoutingQualityMeasureId { get; set; }
        public string RoutingNo { get; set; }
        public string VersionCode { get; set; }
        public string OperationNo { get; set; }
        public int SeqLineNo { get; set; }
        public string QltyMeasureCode { get; set; }
        public string Description { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public decimal? MeanTolerance { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
