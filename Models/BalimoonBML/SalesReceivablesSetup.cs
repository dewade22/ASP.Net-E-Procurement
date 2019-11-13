using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class SalesReceivablesSetup
    {
        public int SalesReceivablesSetupId { get; set; }
        public int? DiscountPosting { get; set; }
        public int? CreditWarnings { get; set; }
        public byte? StockoutWarning { get; set; }
        public byte? ShipmentonInvoice { get; set; }
        public byte? InvoiceRounding { get; set; }
        public byte? ExtDocNoMandatory { get; set; }
        public string CustomerNos { get; set; }
        public string QuoteNos { get; set; }
        public string OrderNos { get; set; }
        public string InvoiceNos { get; set; }
        public string PostedInvoiceNos { get; set; }
        public string CreditMemoNos { get; set; }
        public string PostedCreditMemoNos { get; set; }
        public string PostedShipmentNos { get; set; }
        public string ReminderNos { get; set; }
        public string IssuedReminderNos { get; set; }
        public string FinChrgMemoNos { get; set; }
        public string IssuedFinChrgMemoNos { get; set; }
        public string PostedPrepmtInvNos { get; set; }
        public string PostedPrepmtCrMemoNos { get; set; }
        public string BlanketOrderNos { get; set; }
        public byte? CalcInvDiscount { get; set; }
        public int? ApplnbetweenCurrencies { get; set; }
        public byte? CopyCommentsBlankettoOrder { get; set; }
        public byte? CopyCommentsOrdertoInvoice { get; set; }
        public byte? CopyCommentsOrdertoShpt { get; set; }
        public byte? AllowVatdifference { get; set; }
        public byte? CalcInvDiscperVatid { get; set; }
        public int? LogoPositiononDocuments { get; set; }
        public byte? CheckPrepmtwhenPosting { get; set; }
        public int? DefaultPostingDate { get; set; }
        public int? DefaultQuantitytoShip { get; set; }
        public byte? ArchiveQuotesandOrders { get; set; }
        public string PostedReturnReceiptNos { get; set; }
        public byte? CopyCmtsRetOrdtoRetRcpt { get; set; }
        public byte? CopyCmtsRetOrdtoCrMemo { get; set; }
        public string ReturnOrderNos { get; set; }
        public byte? ReturnReceiptonCreditMemo { get; set; }
        public byte? ExactCostReversingMandatory { get; set; }
        public string CustomerGroupDimensionCode { get; set; }
        public string SalespersonDimensionCode { get; set; }
        public string PreGstprodPostingGroup { get; set; }
        public string PaymentDiscountReasonCode { get; set; }
        public int? ComponentsonSalesOrders { get; set; }
        public int? ComponentsonShipments { get; set; }
        public int? ComponentsonInvoices { get; set; }
        public byte? PrintDialog { get; set; }
        public string PostedTaxInvoiceNos { get; set; }
        public string PostedTaxCreditMemoNos { get; set; }
        public string PostedNonTaxInvoiceNos { get; set; }
        public string PostedNonTaxCreditMemoNos { get; set; }
        public string PostDatedCheckTemplate { get; set; }
        public string PostDatedCheckBatch { get; set; }
        public string FreeOfChargeNos { get; set; }
        public byte? InclPdcinCrLimitCheck { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string PrepaymentAccount { get; set; }
        public string Dimension01Code { get; set; }
        public string Dimension02Code { get; set; }
        public string Dimension03Code { get; set; }
        public string Dimension04Code { get; set; }
        public string Dimension05Code { get; set; }
    }
}
