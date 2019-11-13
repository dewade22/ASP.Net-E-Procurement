using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class SalespersonPurchaser
    {
        public int SalesPersonPurchaserId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? CommissionPercent { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string JobTitle { get; set; }
        public string SearchEmail { get; set; }
        public string Email2 { get; set; }
        public decimal? FloatAmount { get; set; }
        public string Store { get; set; }
        public int? AccountType { get; set; }
        public string AccountNo { get; set; }
        public byte? RetailCommissionBlocked { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
