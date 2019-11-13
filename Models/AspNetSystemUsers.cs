using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class AspNetSystemUsers
    {
        public string UserId { get; set; }
        public string ApproverId { get; set; }
        public int? SalesAmountApprovalLimit { get; set; }
        public int? PurchaseAmountApprovalLimit { get; set; }
        public byte? UnlimitedSalesApproval { get; set; }
        public byte? UnlimitedPurchaseApproval { get; set; }
        public string Substitute { get; set; }
        public int? RequestAmountApprovalLimit { get; set; }
        public byte? UnlimitedRequestApproval { get; set; }
        public string DepartmentCode { get; set; }
        public string LocationCode { get; set; }
    }
}
