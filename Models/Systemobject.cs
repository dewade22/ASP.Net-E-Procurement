using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Systemobject
    {
        public int SystemObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string ObjectDesc { get; set; }
        public string ObjectSystemName { get; set; }
        public string ObjectSystemArg { get; set; }
        public string ObjectSystemImageFileName { get; set; }
        public string UrlObjectName { get; set; }
        public byte ObjectSeqNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
