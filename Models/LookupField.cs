using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class LookupField
    {
        public int LookupFieldId { get; set; }
        public string LookupGroup { get; set; }
        public string LookupCode { get; set; }
        public string LookupDescription { get; set; }
        public int? SeqNo { get; set; }
        public string IndexBy { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
