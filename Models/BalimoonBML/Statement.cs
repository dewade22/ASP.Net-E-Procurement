using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Statement
    {
        public int StatementId { get; set; }
        public string StatementNo { get; set; }
        public DateTime? StatementDate { get; set; }
        public string StoreNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? PostedTime { get; set; }
        public int? Method { get; set; }
        public int? ClosingMethod { get; set; }
        public DateTime? CalculatedDate { get; set; }
        public DateTime? CalculatedTime { get; set; }
        public DateTime? TransStartingDate { get; set; }
        public DateTime? TransEndingDate { get; set; }
        public DateTime? TransEndingTime { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string ShiftNo { get; set; }
        public DateTime? TransStartingTime { get; set; }
        public byte? TransAfterMidnight { get; set; }
        public byte? SkipConfirmation { get; set; }
        public string NoSeries { get; set; }
        public string PostingNoSeries { get; set; }
        public string PostingNo { get; set; }
        public int? StatementStatus { get; set; }
        public int? ReplicationCounter { get; set; }
        public byte? Debugmode { get; set; }
        public byte? Recalculate { get; set; }
        public string StaffPostermFilterInternal { get; set; }
        public byte? Replicated { get; set; }
        public byte? Accepted { get; set; }
        public string AcceptedbyUser { get; set; }
        public string AdvancedShiftNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
