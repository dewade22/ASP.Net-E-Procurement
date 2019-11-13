using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemBudgetEntry
    {
        public int ItemBudgetEntryId { get; set; }
        public int EntryNo { get; set; }
        public int? AnalysisArea { get; set; }
        public string BudgetName { get; set; }
        public DateTime? Date { get; set; }
        public string ItemNo { get; set; }
        public int? SourceType { get; set; }
        public string SourceNo { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Liters { get; set; }
        public decimal? CostAmount { get; set; }
        public decimal? SalesAmount { get; set; }
        public string UserId { get; set; }
        public string LocationCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string BudgetDimension1Code { get; set; }
        public string BudgetDimension2Code { get; set; }
        public string BudgetDimension3Code { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
