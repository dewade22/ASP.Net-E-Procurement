using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class Vatentry
    {
        public int VatEntryId { get; set; }
        public int EntryNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public DateTime? PostingDate { get; set; }
        public string DocumentNo { get; set; }
        public int? DocumentType { get; set; }
        public int? Type { get; set; }
        public decimal? Base { get; set; }
        public decimal? Amount { get; set; }
        public int? VatcalculationType { get; set; }
        public string BilltoPaytoNo { get; set; }
        public byte? Eu3partyTrade { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string ReasonCode { get; set; }
        public int? ClosedbyEntryNo { get; set; }
        public byte? Closed { get; set; }
        public string Country { get; set; }
        public string InternalRefNo { get; set; }
        public int? TransactionNo { get; set; }
        public decimal? UnrealizedAmount { get; set; }
        public decimal? UnrealizedBase { get; set; }
        public decimal? RemainingUnrealizedAmount { get; set; }
        public decimal? RemainingUnrealizedBase { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string NoSeries { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public byte? UseTax { get; set; }
        public string TaxJurisdictionCode { get; set; }
        public string TaxGroupUsed { get; set; }
        public int? TaxType { get; set; }
        public byte? TaxonTax { get; set; }
        public int? SalesTaxConnectionNo { get; set; }
        public int? UnrealizedVatentryNo { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public decimal? AdditionalCurrencyAmount { get; set; }
        public decimal? AdditionalCurrencyBase { get; set; }
        public decimal? AddCurrencyUnrealizedAmt { get; set; }
        public decimal? AddCurrencyUnrealizedBase { get; set; }
        public decimal? VatbaseDiscountPercent { get; set; }
        public decimal? AddCurrRemUnrealAmount { get; set; }
        public decimal? AddCurrRemUnrealBase { get; set; }
        public decimal? Vatdifference { get; set; }
        public decimal? AddCurrVatdifference { get; set; }
        public string ShiptoOrderAddressCode { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string VatregistrationNo { get; set; }
        public byte? Reversed { get; set; }
        public int? ReversedbyEntryNo { get; set; }
        public int? ReversedEntryNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
