using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class EmployeeQualification
    {
        public int EmployeeQualificationId { get; set; }
        public string EmployeeNo { get; set; }
        public int SeqLineNo { get; set; }
        public string QualificationCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string InstitutionCompany { get; set; }
        public decimal Cost { get; set; }
        public string CourseGrade { get; set; }
        public int EmployeeStatus { get; set; }
        public DateTime ExpirationDate { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
