using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ItemCharge
    {
        public int ItemChargeId { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string SearchDescription { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
