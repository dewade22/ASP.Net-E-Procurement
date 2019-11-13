using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CustomerAmount
    {
        public int CustomerAmountId { get; set; }
        public string CustomerNo { get; set; }
        public decimal AmountLcy { get; set; }
        public decimal Amount2Lcy { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
