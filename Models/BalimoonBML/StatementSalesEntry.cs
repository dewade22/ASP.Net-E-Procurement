using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class StatementSalesEntry
    {
        public int StatementSalesEntryId { get; set; }
        public string StatementNo { get; set; }
        public int SeqLineNo { get; set; }
        public string SalesInvoiceNo { get; set; }
        public int? DocumentType { get; set; }
        public string PaymentTermsCode { get; set; }
        public string SalesOrderNo { get; set; }
        public string BilltoName { get; set; }
        public string SalespersonCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Liter { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Amount { get; set; }
        public decimal? LandedCost { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Payment { get; set; }
        public short? RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
