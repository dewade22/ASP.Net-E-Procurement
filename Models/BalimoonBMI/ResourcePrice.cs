using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ResourcePrice
    {
        public int ResourcePriceId { get; set; }
        public string JobNo { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string WorkTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? UnitPrice { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
