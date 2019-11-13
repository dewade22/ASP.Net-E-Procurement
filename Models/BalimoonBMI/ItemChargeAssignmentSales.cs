using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ItemChargeAssignmentSales
    {
        public int ItemChargeAssignmentSalesId { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public int DocumentLineNo { get; set; }
        public int SeqLineNo { get; set; }
        public string ItemChargeNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public decimal QtytoAssign { get; set; }
        public decimal QtyAssigned { get; set; }
        public decimal UnitCost { get; set; }
        public decimal AmounttoAssign { get; set; }
        public int AppliestoDocType { get; set; }
        public string AppliestoDocNo { get; set; }
        public int AppliestoDocLineNo { get; set; }
        public decimal AppliestoDocLineAmount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedTime { get; set; }
    }
}
