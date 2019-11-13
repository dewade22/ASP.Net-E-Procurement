using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class PurchaseContractLines
    {
        public int PurchaseContractLinesId { get; set; }
        public int PurchaseContractHeaderId { get; set; }
        public int SeqLineNo { get; set; }
        public int? ContractType { get; set; }
        public string ItemCategoryCode { get; set; }
        public string RecordCode { get; set; }
        public string Description { get; set; }
        public decimal? GoalAmount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? PurchaseAmountLcyinternal { get; set; }
        public decimal? PurchaseDiscLcyinternal { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
