using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ValueEntry
    {
        public int ValueEntryId { get; set; }
        public int EntryNo { get; set; }
        public string ItemNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? ItemLedgerEntryType { get; set; }
        public string SourceNo { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public string InventoryPostingGroup { get; set; }
        public string SourcePostingGroup { get; set; }
        public int? ItemLedgerEntryNo { get; set; }
        public decimal? ValuedQuantity { get; set; }
        public decimal? ItemLedgerEntryQuantity { get; set; }
        public decimal? InvoicedQuantity { get; set; }
        public decimal? CostperUnit { get; set; }
        public decimal? SalesAmountActual { get; set; }
        public string SalespersPurchCode { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public int? AppliestoEntry { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public int? SourceType { get; set; }
        public decimal? CostAmountActual { get; set; }
        public decimal? CostPostedtoGl { get; set; }
        public string ReasonCode { get; set; }
        public byte? DropShipment { get; set; }
        public string JournalBatchName { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public decimal? CostAmountActualAcy { get; set; }
        public decimal? CostPostedtoGlacy { get; set; }
        public decimal? CostperUnitAcy { get; set; }
        public int? DocumentType { get; set; }
        public int? DocumentLineNo { get; set; }
        public byte? ExpectedCost { get; set; }
        public string ItemChargeNo { get; set; }
        public byte? ValuedByAverageCost { get; set; }
        public byte? PartialRevaluation { get; set; }
        public byte? Inventoriable { get; set; }
        public DateTime? ValuationDate { get; set; }
        public int? EntryType { get; set; }
        public int? VarianceType { get; set; }
        public decimal? PurchaseAmountActual { get; set; }
        public decimal? PurchaseAmountExpected { get; set; }
        public decimal? SalesAmountExpected { get; set; }
        public decimal? CostAmountExpected { get; set; }
        public decimal? CostAmountNonInvtbl { get; set; }
        public decimal? CostAmountExpectedAcy { get; set; }
        public decimal? CostAmountNonInvtblAcy { get; set; }
        public decimal? ExpectedCostPostedtoGl { get; set; }
        public decimal? ExpCostPostedtoGlacy { get; set; }
        public string JobNo { get; set; }
        public string JobTaskNo { get; set; }
        public int? JobLedgerEntryNo { get; set; }
        public string ProdOrderNo { get; set; }
        public string VariantCode { get; set; }
        public byte? Adjustment { get; set; }
        public byte? AverageCostException { get; set; }
        public int? CapacityLedgerEntryNo { get; set; }
        public int? Type { get; set; }
        public string No { get; set; }
        public int? ProdOrderLineNo { get; set; }
        public string ReturnReasonCode { get; set; }
        public string OfferNo { get; set; }
        public string ProductGroup { get; set; }
        public string ItemCategory { get; set; }
        public string BatchNo { get; set; }
        public string InvAdjustGroup { get; set; }
        public string Division { get; set; }
        public string VendorNo { get; set; }
        public string PromotionNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
