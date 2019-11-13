using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class CustInvoiceDisc
    {
        public int CustInvoiceDiscId { get; set; }
        public string Code { get; set; }
        public string CurrencyCode { get; set; }
        public decimal MinimumAmount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? ServiceCharge { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
