using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class NoSeries
    {
        public int NoSeriesId { get; set; }
        public string NoSeriesCode { get; set; }
        public string NoSeriesDescription { get; set; }
        public byte? NoSeriesDefaultNos { get; set; }
        public byte? NoSeriesManualNos { get; set; }
        public byte? NoSeriesDateOrder { get; set; }
        public byte? DistLocationPrefix { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
