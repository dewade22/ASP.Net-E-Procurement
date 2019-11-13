using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class VatpostingSetup
    {
        public int VatpostingSetupId { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public int? VatcalculationType { get; set; }
        public decimal? Vatpercent { get; set; }
        public int? UnrealizedVattype { get; set; }
        public byte? AdjustforPaymentDiscount { get; set; }
        public string SalesVataccount { get; set; }
        public string SalesVatunrealAccount { get; set; }
        public string PurchaseVataccount { get; set; }
        public string PurchVatunrealAccount { get; set; }
        public string ReverseChrgVatacc { get; set; }
        public string ReverseChrgVatunrealAcc { get; set; }
        public string Vatidentifier { get; set; }
        public string PosterminalVatcode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
