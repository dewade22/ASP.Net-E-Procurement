using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class HumanResourcesSetup
    {
        public int HumanResourcesSetupId { get; set; }
        public string EmployeeNos { get; set; }
        public string BaseUnitofMeasure { get; set; }
        public short? RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
