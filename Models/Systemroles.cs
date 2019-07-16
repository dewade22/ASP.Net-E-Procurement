using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Systemroles
    {
        public int SystemRolesId { get; set; }
        public string CompanyCode { get; set; }
        public string Role { get; set; }
        public string Descriptions { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
