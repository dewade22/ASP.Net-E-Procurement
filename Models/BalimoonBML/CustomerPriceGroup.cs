using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CustomerPriceGroup
    {
        public int CustomerPriceGroupId { get; set; }
        public string Code { get; set; }
        public byte? PriceIncludesVat { get; set; }
        public byte? AllowInvoiceDisc { get; set; }
        public string VatbusPostingGrPrice { get; set; }
        public string Description { get; set; }
        public byte? AllowLineDisc { get; set; }
        public string StoreGroup { get; set; }
        public int? DefaultPriority { get; set; }
        public byte? ForecourtPriceGroup { get; set; }
        public decimal? MaxPriceChange { get; set; }
        public byte? RetailPriceGroup { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
