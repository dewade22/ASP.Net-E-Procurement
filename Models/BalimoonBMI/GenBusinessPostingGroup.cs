using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class GenBusinessPostingGroup
    {
        public int GenBusinessPostingGroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DefVatbusPostingGroup { get; set; }
        public byte? AutoInsertDefault { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public byte? IsDefault { get; set; }
    }
}
