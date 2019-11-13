using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class AspNetVendor
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string NpwpNo { get; set; }
        public string SiupNo { get; set; }
        public string SuplierType { get; set; }
        public string ContactName { get; set; }
        public string Contact { get; set; }
        public string ContactEmail { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceContact { get; set; }
        public string InvoiceEmail { get; set; }
        public string FileLocation { get; set; }
        public string VendorNo { get; set; }
        public string swiftcode { get; set; }
    }
}
