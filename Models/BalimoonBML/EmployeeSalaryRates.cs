using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class EmployeeSalaryRates
    {
        public int EmployeeSalaryRatesId { get; set; }
        public string EmployeeNo { get; set; }
        public string WorkRoleCode { get; set; }
        public string WorkCode { get; set; }
        public DateTime DateFrom { get; set; }
        public decimal HourlyCostRate { get; set; }
        public string SalaryCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
