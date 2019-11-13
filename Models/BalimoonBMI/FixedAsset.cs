using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class FixedAsset
    {
        public int FixedAssetId { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string SearchDescription { get; set; }
        public string Description2 { get; set; }
        public string FaclassCode { get; set; }
        public string FasubclassCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string LocationCode { get; set; }
        public string FalocationCode { get; set; }
        public string VendorNo { get; set; }
        public int? MainAssetComponent { get; set; }
        public string ComponentofMainAsset { get; set; }
        public byte? BudgetedAsset { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public string ResponsibleEmployee { get; set; }
        public string SerialNo { get; set; }
        public byte? Blocked { get; set; }
        public string FileNamePicture { get; set; }
        public string MaintenanceVendorNo { get; set; }
        public byte? UnderMaintenance { get; set; }
        public DateTime? NextServiceDate { get; set; }
        public string NoSeries { get; set; }
        public string FapostingGroup { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
