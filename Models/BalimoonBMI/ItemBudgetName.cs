using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemBudgetName
    {
        public int ItemBudgetNameId { get; set; }
        public int AnalysisArea { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Blocked { get; set; }
        public string BudgetDimension1Code { get; set; }
        public string BudgetDimension2Code { get; set; }
        public string BudgetDimension3Code { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public int? BudgetYear { get; set; }
    }
}
