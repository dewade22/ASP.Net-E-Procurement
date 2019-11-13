using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseJournalLine
    {
        public int WarehouseJournalLineId { get; set; }
        public string JournalTemplateName { get; set; }
        public string JournalBatchName { get; set; }
        public string LocationCode { get; set; }
        public int SeqLineNo { get; set; }
        public DateTime? RegisteringDate { get; set; }
        public string FromZoneCode { get; set; }
        public string FromBinCode { get; set; }
        public string Description { get; set; }
        public string ItemNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBase { get; set; }
        public decimal? QtyAbsolute { get; set; }
        public decimal? QtyAbsoluteBase { get; set; }
        public string ZoneCode { get; set; }
        public string BinCode { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubtype { get; set; }
        public string SourceNo { get; set; }
        public int? SourceSeqLineNo { get; set; }
        public int? SourceSubSeqLineNo { get; set; }
        public int? SourceDocument { get; set; }
        public string SourceCode { get; set; }
        public string ToZoneCode { get; set; }
        public string ToBinCode { get; set; }
        public string ReasonCode { get; set; }
        public string RegisteringNoSeries { get; set; }
        public string FromBinTypeCode { get; set; }
        public decimal? Cubage { get; set; }
        public decimal? Weight { get; set; }
        public string WhseDocumentNo { get; set; }
        public int? WhseDocumentType { get; set; }
        public int? WhseDocumentSeqLineNo { get; set; }
        public decimal? QtyCalculated { get; set; }
        public decimal? QtyPhysInventory { get; set; }
        public int? EntryType { get; set; }
        public byte? PhysInventory { get; set; }
        public int? ReferenceDocument { get; set; }
        public string ReferenceNo { get; set; }
        public string UserId { get; set; }
        public decimal? QtyCalculatedBase { get; set; }
        public decimal? QtyPhysInventoryBase { get; set; }
        public string VariantCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string NewSerialNo { get; set; }
        public string NewLotNo { get; set; }
        public DateTime? NewExpirationDate { get; set; }
        public string PhysInvtCountingPeriodCode { get; set; }
        public int? PhysInvtCountingPeriodType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
