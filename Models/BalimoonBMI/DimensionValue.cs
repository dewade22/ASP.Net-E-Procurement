using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class DimensionValue
    {
        public int DimensionValueId { get; set; }
        public string DimensionCode { get; set; }
        public string DimensionValueCode { get; set; }
        public string DimensionValueName { get; set; }
        public int? DimensionValueType { get; set; }
        public string ParentDimensionValueCode { get; set; }
        public int Indentation { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public short? Blocked { get; set; }
    }
}
