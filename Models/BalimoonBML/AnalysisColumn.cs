using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AnalysisColumn
    {
        public int AnalysisColumnId { get; set; }
        public int AnalysisArea { get; set; }
        public string AnalysisColumnTemplate { get; set; }
        public int LineNo { get; set; }
        public string ColumnNo { get; set; }
        public string ColumnHeader { get; set; }
        public int ColumnType { get; set; }
        public int LedgerEntryType { get; set; }
        public string Formula { get; set; }
        public string ComparisonDateFormula { get; set; }
        public byte ShowOppositeSign { get; set; }
        public int Show { get; set; }
        public int RoundingFactor { get; set; }
        public string ComparisonPeriodFormula { get; set; }
        public string AnalysisTypeCode { get; set; }
        public string ItemLedgerEntryTypeFilter { get; set; }
        public string ValueEntryTypeFilter { get; set; }
        public int ValueType { get; set; }
        public byte Invoiced { get; set; }
    }
}
