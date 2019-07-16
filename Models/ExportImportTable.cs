using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class ExportImportTable
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string NewFieldName { get; set; }
        public string OldFieldName { get; set; }
    }
}
