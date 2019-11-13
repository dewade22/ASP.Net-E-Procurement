using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class InventoryPostingBuffer
    {
        public int InventoryPostingBufferId { get; set; }
        public DateTime PostingDate { get; set; }
        public int AccountType { get; set; }
        public string LocationCode { get; set; }
        public string InventoryPostingGroup { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int DimensionEntryNo { get; set; }
        public byte Negative { get; set; }
        public int BalAccountType { get; set; }
        public string ReasonCode { get; set; }
        public string InvAdjustGroup { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountAcy { get; set; }
        public byte? InterimAccount { get; set; }
        public string AccountNo { get; set; }
        public int? EntryNo { get; set; }
        public string JobNo { get; set; }
        public string SourceCode { get; set; }
        public string DocumentNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
