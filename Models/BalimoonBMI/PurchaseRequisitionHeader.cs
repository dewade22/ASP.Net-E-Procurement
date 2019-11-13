using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class PurchaseRequisitionHeader
    {
        public int RequisitionHeaderId { get; set; }
        public string RequisitionNo { get; set; }
        public DateTime? DueDate { get; set; }
        public string RequesterId { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }
        public string RequestNotes { get; set; }
        public string PurchaseNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string LocationCode { get; set; }
    }
}
