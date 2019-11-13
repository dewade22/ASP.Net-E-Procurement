using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class SalesPrepaymentPercent
    {
        public int SalesPrepaymentPercentId { get; set; }
        public string ItemNo { get; set; }
        public int SalesType { get; set; }
        public string SalesCode { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public decimal? PrepaymentPercent { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
