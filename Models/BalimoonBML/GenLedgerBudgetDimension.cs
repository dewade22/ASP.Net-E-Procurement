using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class GenLedgerBudgetDimension
    {
        public int GenLedgerBudgetDimensionId { get; set; }
        public int EntryNo { get; set; }
        public string DimensionCode { get; set; }
        public string DimensionValueCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
