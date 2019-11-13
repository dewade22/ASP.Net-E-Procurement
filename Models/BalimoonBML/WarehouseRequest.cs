using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class WarehouseRequest
    {
        public int WarehouseRequestId { get; set; }
        public int Type { get; set; }
        public string LocationCode { get; set; }
        public int SourceType { get; set; }
        public int SourceSubtype { get; set; }
        public string SourceNo { get; set; }
        public int? SourceDocument { get; set; }
        public int? DocumentStatus { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public int? ShippingAdvice { get; set; }
        public int? DestinationType { get; set; }
        public string DestinationNo { get; set; }
        public string ExternalDocumentNo { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public byte? CompletelyHandled { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
