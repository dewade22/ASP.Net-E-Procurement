using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Resource
    {
        public int RecourceId { get; set; }
        public string No { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
        public string SearchName { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string SocialSecurityNo { get; set; }
        public string JobTitle { get; set; }
        public string Education { get; set; }
        public string ContractClass { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public string ResourceGroupNo { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string BaseUnitofMeasure { get; set; }
        public decimal? DirectUnitCost { get; set; }
        public decimal? IndirectCostPercent { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? ProfitPercent { get; set; }
        public int? PriceProfitCalculation { get; set; }
        public decimal? UnitPrice { get; set; }
        public string VendorNo { get; set; }
        public byte? Blocked { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public byte? AutomaticExtTexts { get; set; }
        public string NoSeries { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string Country { get; set; }
        public string IcpartnerPurchGlaccNo { get; set; }
        public string ServiceZoneFilter { get; set; }
        public string WhtproductPostingGroup { get; set; }
        public string ImageFileName { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
