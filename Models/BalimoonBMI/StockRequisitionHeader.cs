using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class StockRequisitionHeader
    {
        public int StockRequisitionHeaderId { get; set; }
        public string DocumentNo { get; set; }
        public int DocumentType { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public string FromLocationCode { get; set; }
        public string ToLocationCode { get; set; }
        public string JournalDescription { get; set; }
        public string ProdOrderNo { get; set; }
        public string DeliveryNo { get; set; }
        public int? DocStatus { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string ItemNo { get; set; }
    }
}
