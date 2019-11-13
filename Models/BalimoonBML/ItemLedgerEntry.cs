using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ItemLedgerEntry
    {
        public int ItemLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public string ItemNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? EntryType { get; set; }
        public string SourceNo { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? RemainingQuantity { get; set; }
        public decimal? InvoicedQuantity { get; set; }
        public int? AppliestoEntry { get; set; }
        public byte? IsOpen { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public byte? Positive { get; set; }
        public int? SourceType { get; set; }
        public byte? DropShipment { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string CountryRegionCode { get; set; }
        public string EntryExitPoint { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string NoSeries { get; set; }
        public int? DocumentType { get; set; }
        public int? DocumentLineNo { get; set; }
        public string JobNo { get; set; }
        public string JobTaskNo { get; set; }
        public byte? JobPurchase { get; set; }
        public string ProdOrderNo { get; set; }
        public string VariantCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public byte? DerivedfromBlanketOrder { get; set; }
        public string CrossReferenceNo { get; set; }
        public string OriginallyOrderedNo { get; set; }
        public string OriginallyOrderedVarCode { get; set; }
        public byte? OutofStockSubstitution { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte? Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public string TransferOrderNo { get; set; }
        public byte? CompletelyInvoiced { get; set; }
        public DateTime? LastInvoiceDate { get; set; }
        public byte? AppliedEntrytoAdjust { get; set; }
        public byte? Correction { get; set; }
        public decimal? ShippedQtyNotReturned { get; set; }
        public int? ProdOrderLineNo { get; set; }
        public int? ProdOrderCompLineNo { get; set; }
        public string ServiceOrderNo { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? ItemTracking { get; set; }
        public string ReturnReasonCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string DimensionValue01Code { get; set; }
        public string DimensionValue02Code { get; set; }
        public string DimensionValue03Code { get; set; }
        public string DimensionValue04Code { get; set; }
    }
}
