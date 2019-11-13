using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CustomerShipToAddress
    {
        public int CustomerShipToAddressId { get; set; }
        public string CustomerNo { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string PhoneNo { get; set; }
        public string TelexNo { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public string PlaceofExport { get; set; }
        public string Country { get; set; }
        public string LocationCode { get; set; }
        public string FaxNo { get; set; }
        public string TelexAnswerBack { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ServiceZoneCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
