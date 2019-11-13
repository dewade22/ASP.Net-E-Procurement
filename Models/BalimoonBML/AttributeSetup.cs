using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AttributeSetup
    {
        public int AttributeSetupId { get; set; }
        public int AttributeType { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public string DefaultValue { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public int? Instances { get; set; }
        public int? Creation { get; set; }
        public int? ValueRequired { get; set; }
        public int? TableLink { get; set; }
        public int? FieldLink { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
