using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class PurchasePrice
    {
        public int PurchasePriceId { get; set; }
        public string ItemNo { get; set; }
        public string VendorNo { get; set; }
        public DateTime StartingDate { get; set; }
        public string CurrencyCode { get; set; }
        public string VariantCode { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal MinimumQuantity { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public DateTime? EndingDate { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? DiscountPercent { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
