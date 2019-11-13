using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PhysInventoryLedgerEntry
    {
        public int PhysInventoryLedgerEntryId { get; set; }
        public int EntryNo { get; set; }
        public string ItemNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public int? EntryType { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public string InventoryPostingGroup { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitAmount { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Amount { get; set; }
        public string SalespersPurchCode { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string JournalBatchName { get; set; }
        public string ReasonCode { get; set; }
        public decimal? QtyCalculated { get; set; }
        public decimal? QtyPhysInventory { get; set; }
        public int? LastItemLedgerEntryNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string NoSeries { get; set; }
        public string VariantCode { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string PhysInvtCountingPeriodCode { get; set; }
        public int? PhysInvtCountingPeriodType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
