using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Icpartner
    {
        public int IcpartnerId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public int? InboxType { get; set; }
        public string InboxDetails { get; set; }
        public string ReceivablesAccount { get; set; }
        public string PayablesAccount { get; set; }
        public byte? Blocked { get; set; }
        public string CustomerNo { get; set; }
        public string VendorNo { get; set; }
        public int? OutboundSalesItemNoType { get; set; }
        public int? OutboundPurchItemNoType { get; set; }
        public byte? CostDistributioninLcy { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
