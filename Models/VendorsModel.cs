using Balimoon_E_Procurement.Models.BalimoonBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models
{
    public class VendorsModel
    {
        public AspNetUsers MainSystemUserTbl { get; set; }
        public Vendors BalimoonBMLVendorTbl { get; set; }
        public AspNetVendor MainSystemVendorTbl { get; set; }
        public AspNetRoles MainSystemRoleTbl { get; set; }
        public AspNetUserRoles MainSystemUserRoleTbl { get; set; }
        public VendorLedgerEntry BalimoonBMLVendorLedgerEntryTbl { get; set; }
        public VendorLedgerEntryDetailed BalimoonBMLVendorLedgerEntryDetailedTbl { get; set; }
        public VendorPostingGroup BalimoonBMLVendorPostingGroupTbl { get; set; }
        public VendorSalesPrice BalimoonBMLVendorSalesPrice { get; set; }
        public VatbusinessPostingGroup BalimoonBMLVatBusinessPostingGroup { get; set; }
        public CountryRegion BalimoonBMLCountry { get; set; }
    }
}
