using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CataloqueHeader
    {
        public int CataloqueHeaderId { get; set; }
        public string CataloqueHeaderNo { get; set; }
        public string Descriptions { get; set; }
        public string MarketCode { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Attrib1Code { get; set; }
        public string Attrib2Code { get; set; }
        public string Attrib3Code { get; set; }
        public string Attrib4Code { get; set; }
        public string Attrib5Code { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
