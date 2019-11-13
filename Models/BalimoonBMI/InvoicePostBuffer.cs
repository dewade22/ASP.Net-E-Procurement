using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class InvoicePostBuffer
    {
        public int InvoicePostBufferId { get; set; }
        public int Type { get; set; }
        public string Glaccount { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string TaxAreaCode { get; set; }
        public string TaxGroupCode { get; set; }
        public byte TaxLiable { get; set; }
        public byte UseTax { get; set; }
        public int DimensionEntryNo { get; set; }
        public string JobNo { get; set; }
        public int FixedAssetLineNo { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vatamount { get; set; }
        public int? VatcalculationType { get; set; }
        public decimal? VatbaseAmount { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AmountAcy { get; set; }
        public decimal? VatamountAcy { get; set; }
        public decimal? VatbaseAmountAcy { get; set; }
        public decimal? Vatdifference { get; set; }
        public decimal? Vatpercent { get; set; }
        public DateTime? FapostingDate { get; set; }
        public int? FapostingType { get; set; }
        public string DepreciationBookCode { get; set; }
        public decimal? SalvageValue { get; set; }
        public byte? DepruntilFapostingDate { get; set; }
        public byte? DeprAcquisitionCost { get; set; }
        public string MaintenanceCode { get; set; }
        public string InsuranceNo { get; set; }
        public string BudgetedFano { get; set; }
        public string DuplicateinDepreciationBook { get; set; }
        public byte? UseDuplicationList { get; set; }
        public decimal? LineDiscountAmount { get; set; }
        public decimal? InvDiscountAmount { get; set; }
        public decimal? LineDiscountAmountAcy { get; set; }
        public decimal? InvDiscountAmountAcy { get; set; }
        public string LineDiscountAccount { get; set; }
        public string InvDiscountAccount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
