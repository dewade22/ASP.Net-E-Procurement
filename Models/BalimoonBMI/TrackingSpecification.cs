using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class TrackingSpecification
    {
        public int TrackingSpecificationId { get; set; }
        public int EntryNo { get; set; }
        public string ItemNo { get; set; }
        public string LocationCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubtype { get; set; }
        public string SourceId { get; set; }
        public string SourceBatchName { get; set; }
        public int? SourceProdOrderLine { get; set; }
        public int? SourceRefNo { get; set; }
        public int? AppltoItemEntry { get; set; }
        public int? TransferItemEntryNo { get; set; }
        public string SerialNo { get; set; }
        public byte? Positive { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? QtytoHandleBase { get; set; }
        public decimal? QtytoInvoiceBase { get; set; }
        public decimal? QuantityHandledBase { get; set; }
        public decimal? QuantityInvoicedBase { get; set; }
        public decimal? QtytoHandle { get; set; }
        public decimal? QtytoInvoice { get; set; }
        public int? BufferStatus { get; set; }
        public int? BufferStatus2 { get; set; }
        public decimal? BufferValue1 { get; set; }
        public decimal? BufferValue2 { get; set; }
        public decimal? BufferValue3 { get; set; }
        public decimal? BufferValue4 { get; set; }
        public decimal? BufferValue5 { get; set; }
        public string NewSerialNo { get; set; }
        public string NewLotNo { get; set; }
        public string LotNo { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public int? ApplfromItemEntry { get; set; }
        public byte? Correction { get; set; }
        public DateTime? NewExpirationDate { get; set; }
        public decimal? QuantityactualHandledBase { get; set; }
        public decimal? QtyDifference { get; set; }
        public decimal? QtyDifferenceBase { get; set; }
        public int? InStoreDocumentStatus { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
