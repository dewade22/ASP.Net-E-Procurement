using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class InventoryPosttoGltestBuffer
    {
        public int InventoryPosttoGltestBufferId { get; set; }
        public int SeqLineNo { get; set; }
        public string AccountNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string SourceCode { get; set; }
        public byte? SystemCreatedEntry { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int? AdditionalCurrencyPosting { get; set; }
        public string SourceCurrencyCode { get; set; }
        public decimal? SourceCurrencyAmount { get; set; }
        public int? ValueEntryNo { get; set; }
        public string LocationCode { get; set; }
        public string InvtPostingGroupCode { get; set; }
        public int? InventoryAccountType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
