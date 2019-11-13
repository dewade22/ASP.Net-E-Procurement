using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class RoutingHeader
    {
        public int RoutingHeaderId { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string SearchDescription { get; set; }
        public int? Type { get; set; }
        public string VersionNos { get; set; }
        public string NoSeries { get; set; }
        public short? RoutingStatus { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
