using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class OpportunityEntry
    {
        public int OpportunityEntryId { get; set; }
        public int EntryNo { get; set; }
        public string OpportunityNo { get; set; }
        public string SalesCycleCode { get; set; }
        public int? SalesCycleStage { get; set; }
        public string ContactNo { get; set; }
        public string ContactCompanyNo { get; set; }
        public string SalespersonCode { get; set; }
        public string CampaignNo { get; set; }
        public DateTime? DateofChange { get; set; }
        public byte? Active { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal? DaysOpen { get; set; }
        public int? ActionTaken { get; set; }
        public decimal? EstimatedValueLcy { get; set; }
        public decimal? CalcdCurrentValueLcy { get; set; }
        public decimal? CompletedPercent { get; set; }
        public decimal? ChancesofSuccessPercent { get; set; }
        public decimal? ProbabilityPercent { get; set; }
        public string CloseOpportunityCode { get; set; }
        public int? PreviousSalesCycleStage { get; set; }
        public DateTime? EstimatedCloseDate { get; set; }
        public int? WizardStep { get; set; }
        public byte? CancelOldToDo { get; set; }
        public int? ActionType { get; set; }
        public string SalesCycleStageDescription { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
