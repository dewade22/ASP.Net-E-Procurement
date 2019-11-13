using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemVariants
    {
        public int ItemVariantId { get; set; }
        public string ItemNo { get; set; }
        public string ItemVariantCode { get; set; }
        public string ItemVariantDescription { get; set; }
        public string ItemVariantDescription2 { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
