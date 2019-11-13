using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ApprovalEntry
    {
        public int ApprovalEntryId { get; set; }
        public string TableName { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public int SequenceNo { get; set; }
        public string ApprovalCode { get; set; }
        public string SenderBy { get; set; }
        public string SalespersPurchCode { get; set; }
        public string ApproverBy { get; set; }
        public int Status { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountLcy { get; set; }
        public string CurrencyCode { get; set; }
        public int ApprovalType { get; set; }
        public int LimitType { get; set; }
        public decimal AvailableCreditLimitLcy { get; set; }
        public byte[] RecordIdtoApprove { get; set; }
        public string DelegationDateFormula { get; set; }
        public Guid WorkflowStepInstanceId { get; set; }
        public DateTime DateTimeSentforApproval { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string NextApproval { get; set; }
        [MaxLength(500, ErrorMessage = "You Type Over 500 Character Message")]
        public string Message { get; set; }
    }
}
