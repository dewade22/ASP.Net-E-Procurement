using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class EmployeeAbsence
    {
        public int EmployeeAbsenceId { get; set; }
        public int EntryNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string CauseofAbsenceCode { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal QuantityBase { get; set; }
        public decimal QtyperUnitofMeasure { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
