using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ItemUnitOfMeasures
    {
        public int ItemUnitOfMeasureId { get; set; }
        public string ItemCode { get; set; }
        public string Uomcode { get; set; }
        public decimal QtyperUnitofMeasure { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
