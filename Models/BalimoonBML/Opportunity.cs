using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Opportunity
    {
        public int OpportunityId { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string SalespersonCode { get; set; }
        public string CampaignNo { get; set; }
        public string ContactNo { get; set; }
        public string ContactCompanyNo { get; set; }
        public string SalesCycleCode { get; set; }
        public string SalesDocumentNo { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }
        public byte? Closed { get; set; }
        public DateTime? DateClosed { get; set; }
        public string NoSeries { get; set; }
        public string SegmentNo { get; set; }
        public int? SalesDocumentType { get; set; }
        public int? WizardStep { get; set; }
        public byte? ActivateFirstStage { get; set; }
        public string SegmentDescription { get; set; }
        public decimal? WizardEstimatedValueLcy { get; set; }
        public decimal? WizardChancesofSuccessPercent { get; set; }
        public DateTime? WizardEstimatedClosingDate { get; set; }
        public string WizardContactName { get; set; }
        public string WizardCampaignDescription { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
