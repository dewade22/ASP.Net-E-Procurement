using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Systemusers
    {
        public int SystemUsersId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime? AllowPostingFrom { get; set; }
        public DateTime? AllowPostingTo { get; set; }
        public byte? RegisterTime { get; set; }
        public string SalespersPurchCode { get; set; }
        public string ApproverId { get; set; }
        public int? SalesAmountApprovalLimit { get; set; }
        public int? PurchaseAmountApprovalLimit { get; set; }
        public byte? UnlimitedSalesApproval { get; set; }
        public byte? UnlimitedPurchaseApproval { get; set; }
        public string Substitute { get; set; }
        public string EmailAddress { get; set; }
        public int? RequestAmountApprovalLimit { get; set; }
        public byte? UnlimitedRequestApproval { get; set; }
        public DateTime? AllowFapostingFrom { get; set; }
        public DateTime? AllowFapostingTo { get; set; }
        public string SalesRespCtrFilter { get; set; }
        public string PurchaseRespCtrFilter { get; set; }
        public string ServiceRespCtrFilter { get; set; }
        public string DepartmentCode { get; set; }
        public string LocationCode { get; set; }
        public short? Blocked { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
