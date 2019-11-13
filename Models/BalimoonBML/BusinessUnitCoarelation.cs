using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class BusinessUnitCoarelation
    {
        public int BusinessUnitCoarelationId { get; set; }
        public string Code { get; set; }
        public string GenLedgerAccountNo { get; set; }
        public string BusinessUnitGlaccountNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
