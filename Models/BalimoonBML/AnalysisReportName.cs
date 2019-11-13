using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AnalysisReportName
    {
        public int AnalysisReportNameId { get; set; }
        public int AnalysisArea { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AnalysisLineTemplateName { get; set; }
        public string AnalysisColumnTemplateName { get; set; }
    }
}
