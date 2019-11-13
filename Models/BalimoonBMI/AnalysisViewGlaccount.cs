using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class AnalysisViewGlaccount
    {
        public int AnalysisViewGlaccountId { get; set; }
        public string AnalysisViewCode { get; set; }
        public string GlaccountNo { get; set; }
        public string Name { get; set; }
        public byte? Blocked { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
