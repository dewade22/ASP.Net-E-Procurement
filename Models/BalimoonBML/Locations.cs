using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Locations
    {
        public int LocationId { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
        public string PhoneNo2 { get; set; }
        public string FaxNo { get; set; }
        public string Contact { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string CountryRegionCode { get; set; }
        public byte? UseAsInTransit { get; set; }
        public byte? RequirePutaway { get; set; }
        public byte? RequirePick { get; set; }
        public string CrossDockDueDateCalc { get; set; }
        public byte? UseCrossDocking { get; set; }
        public byte? RequireReceive { get; set; }
        public byte? RequireShipment { get; set; }
        public byte? BinMandatory { get; set; }
        public byte? DirectedPutawayandPick { get; set; }
        public int? DefaultBinSelection { get; set; }
        public string OutboundWhseHandlingTime { get; set; }
        public string InboundWhseHandlingTime { get; set; }
        public string PutawayTemplateCode { get; set; }
        public byte? UsePutawayWorksheet { get; set; }
        public byte? PickAccordingtoFefo { get; set; }
        public byte? AllowBreakbulk { get; set; }
        public int? BinCapacityPolicy { get; set; }
        public string OpenShopFloorBinCode { get; set; }
        public string InboundProductionBinCode { get; set; }
        public string OutboundProductionBinCode { get; set; }
        public string AdjustmentBinCode { get; set; }
        public byte? AlwaysCreatePutawayLine { get; set; }
        public byte? AlwaysCreatePickLine { get; set; }
        public int? SpecialEquipment { get; set; }
        public string ReceiptBinCode { get; set; }
        public string ShipmentBinCode { get; set; }
        public string CrossDockBinCode { get; set; }
        public string OutboundBombinCode { get; set; }
        public string InboundBombinCode { get; set; }
        public string BaseCalendarCode { get; set; }
        public byte? UseAdcs { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
