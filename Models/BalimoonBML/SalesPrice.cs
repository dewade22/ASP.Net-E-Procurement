using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class SalesPrice
    {
        public int SalesPriceId { get; set; }
        public string ItemNo { get; set; }
        public int SalesType { get; set; }
        public string SalesCode { get; set; }
        public DateTime StartingDate { get; set; }
        public string CurrencyCode { get; set; }
        public string VariantCode { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal MinimumQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public byte? PriceIncludesVat { get; set; }
        public byte? AllowInvoiceDisc { get; set; }
        public string VatbusPostingGrPrice { get; set; }
        public DateTime? EndingDate { get; set; }
        public byte? AllowLineDisc { get; set; }
        public decimal? CostplusPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
