using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class StatementLine
    {
        public int StatementLineId { get; set; }
        public string StatementNo { get; set; }
        public int SeqLineNo { get; set; }
        public string StatementCode { get; set; }
        public string StaffId { get; set; }
        public string PosterminalNo { get; set; }
        public string TenderType { get; set; }
        public string TenderTypeCardNo { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CountedAmount { get; set; }
        public decimal? CountedAmountinLcy { get; set; }
        public decimal? RealExchangeRate { get; set; }
        public DateTime? PostedDate { get; set; }
        public string TenderTypeName { get; set; }
        public decimal? TransAmountinLcy { get; set; }
        public decimal? TransAmount { get; set; }
        public decimal? DifferenceinLcy { get; set; }
        public decimal? DifferenceAmount { get; set; }
        public string StoreNo { get; set; }
        public decimal? AddedtoDrawer { get; set; }
        public decimal? RemovedfromDrawer { get; set; }
        public decimal? ChangeTender { get; set; }
        public int? ReplicationCounter { get; set; }
        public byte? TenderDeclaration { get; set; }
        public byte? CountingRequired { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
