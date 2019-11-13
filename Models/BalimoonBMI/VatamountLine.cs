using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class VatamountLine
    {
        public int VatamountLineId { get; set; }
        public string Vatidentifier { get; set; }
        public int VatcalculationType { get; set; }
        public string TaxGroupCode { get; set; }
        public byte UseTax { get; set; }
        public byte Positive { get; set; }
        public decimal? Vatpercent { get; set; }
        public decimal? Vatbase { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? AmountIncludingVat { get; set; }
        public decimal? LineAmount { get; set; }
        public decimal? InvDiscBaseAmount { get; set; }
        public decimal? InvoiceDiscountAmount { get; set; }
        public decimal? Quantity { get; set; }
        public byte? Modified { get; set; }
        public decimal? CalculatedVatamount { get; set; }
        public decimal? Vatdifference { get; set; }
        public byte? IncludesPrepayment { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
