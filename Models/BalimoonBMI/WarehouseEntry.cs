using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class WarehouseEntry
    {
        public int WarehouseEntryId { get; set; }
        public int EntryNo { get; set; }
        public string JournalBatchName { get; set; }
        public int? SeqLineNo { get; set; }
        public DateTime? RegisteringDate { get; set; }
        public string LocationCode { get; set; }
        public string ZoneCode { get; set; }
        public string BinCode { get; set; }
        public string Description { get; set; }
        public string ItemNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBase { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubtype { get; set; }
        public string SourceNo { get; set; }
        public int? SourceSeqLineNo { get; set; }
        public int? SourceSubSeqLineNo { get; set; }
        public int? SourceDocument { get; set; }
        public string SourceCode { get; set; }
        public string ReasonCode { get; set; }
        public string NoSeries { get; set; }
        public string BinTypeCode { get; set; }
        public decimal? Cubage { get; set; }
        public decimal? Weight { get; set; }
        public string JournalTemplateName { get; set; }
        public string WhseDocumentNo { get; set; }
        public int? WhseDocumentType { get; set; }
        public int? WhseDocumentSeqLineNo { get; set; }
        public int? EntryType { get; set; }
        public int? ReferenceDocument { get; set; }
        public string ReferenceNo { get; set; }
        public string UserId { get; set; }
        public string VariantCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string PhysInvtCountingPeriodCode { get; set; }
        public int? PhysInvtCountingPeriodType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
