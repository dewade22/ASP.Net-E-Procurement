using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Systemusermenu
    {
        public int SystemUserMenuId { get; set; }
        public string CompanyCode { get; set; }
        public string RoleId { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
        public int SeqNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
