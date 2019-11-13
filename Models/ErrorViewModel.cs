using System;

namespace Balimoon_E_Procurement.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string ErrorMessage { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}