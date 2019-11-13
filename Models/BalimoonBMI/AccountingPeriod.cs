using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class AccountingPeriod
    {
        public int AccountingPeriodId { get; set; }
        public DateTime StartingDate { get; set; }
        public string Name { get; set; }
        public byte? NewFiscalYear { get; set; }
        public byte? Closed { get; set; }
        public byte? DateLocked { get; set; }
        public int? AverageCostCalcType { get; set; }
        public int? AverageCostPeriod { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
