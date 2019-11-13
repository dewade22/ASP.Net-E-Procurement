using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class Dimension
    {
        public int DimensionId { get; set; }
        public string DimensionCode { get; set; }
        public string DimensionName { get; set; }
        public string DimensionDescription { get; set; }
        public string CodeCaption { get; set; }
        public string FilterCaption { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public short? Blocked { get; set; }
    }
}
