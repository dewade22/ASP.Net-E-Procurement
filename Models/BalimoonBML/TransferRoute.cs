using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class TransferRoute
    {
        public int TransferRouteId { get; set; }
        public string TransferfromCode { get; set; }
        public string TransfertoCode { get; set; }
        public string InTransitCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public short? RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
