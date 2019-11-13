using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class VendorSalesPrice
    {
        public int VendorSalesPriceId { get; set; }
        public string VendorNo { get; set; }
        public string DivisionCode { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ProductGroupCode { get; set; }
        public decimal SuggestedRetailPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
