using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AccountScheduleLine
    {
        public int AccountScheduleLineId { get; set; }
        public string ScheduleName { get; set; }
        public int SeqLineNo { get; set; }
        public string RowNo { get; set; }
        public string Description { get; set; }
        public string AccountNo { get; set; }
        public string TotalToAccountNo { get; set; }
        public byte NewPage { get; set; }
        public int Show { get; set; }
        public string Dimension1Totaling { get; set; }
        public string Dimension2Totaling { get; set; }
        public string Dimension3Totaling { get; set; }
        public string Dimension4Totaling { get; set; }
        public byte Bold { get; set; }
        public byte Italic { get; set; }
        public byte Underline { get; set; }
        public byte ShowOppositeSign { get; set; }
        public int RowType { get; set; }
        public int AmountType { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
