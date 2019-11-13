using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class PaymentTerms
    {
        public int PaymentTermsId { get; set; }
        public string Code { get; set; }
        public string DueDateCalculation { get; set; }
        public string DiscountDateCalculation { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string Description { get; set; }
        public byte? CalcPmtDisconCrMemos { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
