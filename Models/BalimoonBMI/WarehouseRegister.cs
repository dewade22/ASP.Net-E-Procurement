using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class WarehouseRegister
    {
        public int WarehouseRegisterId { get; set; }
        public int No { get; set; }
        public int? FromEntryNo { get; set; }
        public int? ToEntryNo { get; set; }
        public DateTime? CreationDate { get; set; }
        public string SourceCode { get; set; }
        public string UserId { get; set; }
        public string JournalBatchName { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
