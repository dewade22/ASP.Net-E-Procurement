using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ItemCategory
    {
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DefGenProdPostingGroup { get; set; }
        public string DefInventoryPostingGroup { get; set; }
        public string DefTaxGroupCode { get; set; }
        public int? DefCostingMethod { get; set; }
        public string DefVatprodPostingGroup { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
