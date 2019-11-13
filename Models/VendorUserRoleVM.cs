using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models
{
    public class VendorUserRoleVM
    {
        public AspNetUsers usertbl { get; set; }
        public AspNetVendor vendortbl { get; set; }
        public AspNetUserRoles userroletbl { get; set; }
        public AspNetRoles roletbl { get; set; }
    }
}
