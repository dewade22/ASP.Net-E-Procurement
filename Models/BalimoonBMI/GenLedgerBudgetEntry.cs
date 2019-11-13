using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class GenLedgerBudgetEntry
    {
        public int GenLedgerBudgetEntryId { get; set; }
        public int EntryNo { get; set; }
        public string BudgetName { get; set; }
        public string GenLedgerAccountNo { get; set; }
        public DateTime Date { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string BusinessUnitCode { get; set; }
        public string BudgetDimension1Code { get; set; }
        public string BudgetDimension2Code { get; set; }
        public string BudgetDimension3Code { get; set; }
        public string BudgetDimension4Code { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
