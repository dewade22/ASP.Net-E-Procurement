using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class EmployeeRoles
    {
        public int EmployeeRolesId { get; set; }
        public string EmployeeNo { get; set; }
        public string WorkRoleCode { get; set; }
        public string Qualifications { get; set; }
        public int SkillLevel { get; set; }
        public string WorkArrangementCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
