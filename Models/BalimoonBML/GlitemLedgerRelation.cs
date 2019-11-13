using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class GlitemLedgerRelation
    {
        public int GlitemLedgerRelationId { get; set; }
        public int GlentryNo { get; set; }
        public int ValueEntryNo { get; set; }
        public int? GlregisterNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
