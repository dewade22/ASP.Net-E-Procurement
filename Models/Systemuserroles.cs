using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Systemuserroles
    {
        public int SystemUserRolesId { get; set; }
        public string UserCode { get; set; }
        public string CompanyCode { get; set; }
        public string RoleId { get; set; }
        public byte DefaultCompany { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
