using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class TransferHeader
    {
        public int TransferHeaderId { get; set; }
        public string No { get; set; }
        public string TransferfromCode { get; set; }
        public string TransferfromName { get; set; }
        public string TransferfromName2 { get; set; }
        public string TransferfromAddress { get; set; }
        public string TransferfromAddress2 { get; set; }
        public string TransferfromPostCode { get; set; }
        public string TransferfromCity { get; set; }
        public string TransferfromCounty { get; set; }
        public string TransferfromCountry { get; set; }
        public string TransfertoCode { get; set; }
        public string TransfertoName { get; set; }
        public string TransfertoName2 { get; set; }
        public string TransfertoAddress { get; set; }
        public string TransfertoAddress2 { get; set; }
        public string TransfertoPostCode { get; set; }
        public string TransfertoCity { get; set; }
        public string TransfertoCounty { get; set; }
        public string TransfertoCountry { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? Status { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string InTransitCode { get; set; }
        public string NoSeries { get; set; }
        public string LastShipmentNo { get; set; }
        public string LastReceiptNo { get; set; }
        public string TransferfromContact { get; set; }
        public string TransfertoContact { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ShippingTime { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string EntryExitPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public int? ShippingAdvice { get; set; }
        public int? PostingfromWhseRef { get; set; }
        public string OutboundWhseHandlingTime { get; set; }
        public string InboundWhseHandlingTime { get; set; }
        public string AssignedUserId { get; set; }
        public string Storeto { get; set; }
        public string Storefrom { get; set; }
        public int? AllocationStatus { get; set; }
        public string PreReceiveReferenceNo { get; set; }
        public byte? InStoreCreatedEntry { get; set; }
        public int? RetailStatus { get; set; }
        public string RecivingPickingNo { get; set; }
        public string TransferfromDepartCode { get; set; }
        public string TransfertoDepartCode { get; set; }
        public int? RtcfilteringType { get; set; }
        public string BuyerId { get; set; }
        public string BuyerGroupCode { get; set; }
        public string CreatedBySourceCode { get; set; }
        public int? TransferType { get; set; }
        public string VendorNo { get; set; }
        public int? SpotransferStatus { get; set; }
        public byte? RetailSpecialOrder { get; set; }
        public byte? SpocreatedEntry { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
