using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Systempermission
    {
        public int SystemPermissionId { get; set; }
        public string CompanyCode { get; set; }
        public string RoleId { get; set; }
        public int ObjectId { get; set; }
        public short ReadData { get; set; }
        public short InsertData { get; set; }
        public short ModifyData { get; set; }
        public short DeleteData { get; set; }
        public short ExecuteData { get; set; }
        public short ValueData { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
