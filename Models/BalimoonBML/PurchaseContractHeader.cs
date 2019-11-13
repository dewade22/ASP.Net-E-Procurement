using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PurchaseContractHeader
    {
        public int PurchaseContractHeaderId { get; set; }
        public string PurchaseContractHeaderNo { get; set; }
        public string VendorNo { get; set; }
        public string VendorName { get; set; }
        public string Description { get; set; }
        public string BuyerId { get; set; }
        public DateTime? ValidFromDate { get; set; }
        public DateTime? ValidToDate { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string BuyerGroupCode { get; set; }
        public int? RtcfilterField { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
