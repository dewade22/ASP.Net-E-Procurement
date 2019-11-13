using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AccountScheduleName
    {
        public int AccountScheduleNameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DefaultColumnLayout { get; set; }
        public string AnalysisViewName { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
