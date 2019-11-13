using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class MarketingSetup
    {
        public int MarketingSetupId { get; set; }
        public string ContactNos { get; set; }
        public string CampaignNos { get; set; }
        public string SegmentNos { get; set; }
        public string TodoNos { get; set; }
        public string OpportunityNos { get; set; }
        public string PromotionNos { get; set; }
        public string PeriodicDiscountNos { get; set; }
        public string CouponNos { get; set; }
        public string BusRelCodeforCustomers { get; set; }
        public string BusRelCodeforVendors { get; set; }
        public string BusRelCodeforBankAccs { get; set; }
        public byte? InheritSalespersonCode { get; set; }
        public byte? InheritTerritoryCode { get; set; }
        public byte? InheritCountryRegionCode { get; set; }
        public byte? InheritLanguageCode { get; set; }
        public byte? InheritAddressDetails { get; set; }
        public byte? InheritCommunicationDetails { get; set; }
        public string DefaultSalespersonCode { get; set; }
        public string DefaultTerritoryCode { get; set; }
        public string DefaultCountryRegionCode { get; set; }
        public string DefaultLanguageCode { get; set; }
        public string DefaultSalesCycleCode { get; set; }
        public int? AttachmentStorageType { get; set; }
        public string AttachmentStorageLocation { get; set; }
        public byte? AutosearchforDuplicates { get; set; }
        public int? SearchHitPercent { get; set; }
        public byte? MaintainDuplSearchStrings { get; set; }
        public int? MergefieldLanguageId { get; set; }
        public string DefCompanySalutationCode { get; set; }
        public string DefaultPersonSalutationCode { get; set; }
        public int? DefaultCorrespondenceType { get; set; }
        public string EmailLoggingUserId { get; set; }
        public string EmailLoggingProfileName { get; set; }
        public string QueueFolderName { get; set; }
        public string StorageFolderName { get; set; }
        public int? TimeIntervalSec { get; set; }
        public int? IndexMode { get; set; }
        public string Delimiters { get; set; }
        public string DefaultTodoDateCalculation { get; set; }
        public byte? EnableConnector { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
