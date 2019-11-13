using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AnalysisLine
    {
        public int AnalysisLineId { get; set; }
        public int AnalysisArea { get; set; }
        public string AnalysisLineTemplateName { get; set; }
        public int LineNo { get; set; }
        public string RowRefNo { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string Range { get; set; }
        public byte NewPage { get; set; }
        public int Show { get; set; }
        public byte Bold { get; set; }
        public byte Italic { get; set; }
        public byte Underline { get; set; }
        public byte ShowOppositeSign { get; set; }
        public string Dimension1Totaling { get; set; }
        public string Dimension2Totaling { get; set; }
        public string Dimension3Totaling { get; set; }
        public string GroupDimensionCode { get; set; }
        public int Indentation { get; set; }
    }
}
