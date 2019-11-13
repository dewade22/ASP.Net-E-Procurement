using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class CountryRegion
    {
        public int CountryRegionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EucountryRegionCode { get; set; }
        public string IntrastatCode { get; set; }
        public int? AddressFormat { get; set; }
        public int? ContactAddressFormat { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
