using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class AnalysisType
    {
        public int AnalysisTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ValueType { get; set; }
        public string ItemLedgerEntryTypeFilter { get; set; }
        public string ValueEntryTypeFilter { get; set; }
    }
}
