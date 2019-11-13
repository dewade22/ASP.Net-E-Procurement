using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class PurchasesPayablesSetup
    {
        public int PurchasesPayablesSetupId { get; set; }
        public int? DiscountPosting { get; set; }
        public byte? ReceiptonInvoice { get; set; }
        public byte? InvoiceRounding { get; set; }
        public byte? ExtDocNoMandatory { get; set; }
        public string VendorNos { get; set; }
        public string RequisitionNos { get; set; }
        public string QuoteNos { get; set; }
        public string OrderNos { get; set; }
        public string InvoiceNos { get; set; }
        public string PostedInvoiceNos { get; set; }
        public string CreditMemoNos { get; set; }
        public string PostedCreditMemoNos { get; set; }
        public string PostedReceiptNos { get; set; }
        public string BlanketOrderNos { get; set; }
        public byte? CalcInvDiscount { get; set; }
        public int? ApplnbetweenCurrencies { get; set; }
        public byte? CopyCommentsBlankettoOrder { get; set; }
        public byte? CopyCommentsOrdertoInvoice { get; set; }
        public byte? CopyCommentsOrdertoReceipt { get; set; }
        public byte? AllowVatdifference { get; set; }
        public byte? CalcInvDiscperVatid { get; set; }
        public string PostedPrepmtInvNos { get; set; }
        public string PostedPrepmtCrMemoNos { get; set; }
        public byte? CheckPrepmtwhenPosting { get; set; }
        public int? DefaultPostingDate { get; set; }
        public int? DefaultQtytoShipRcv { get; set; }
        public byte? ArchiveQuotesandOrders { get; set; }
        public string PostedReturnShptNos { get; set; }
        public byte? CopyCmtsRetOrdtoRetShpt { get; set; }
        public byte? CopyCmtsRetOrdtoCrMemo { get; set; }
        public string ReturnOrderNos { get; set; }
        public byte? ReturnShipmentonCreditMemo { get; set; }
        public byte? ExactCostReversingMandatory { get; set; }
        public string GstprodPostingGroup { get; set; }
        public string PreGstprodPostingGroup { get; set; }
        public byte? VendorRegistrationWarning { get; set; }
        public string PaymentDiscountReasonCode { get; set; }
        public byte? PrintDialog { get; set; }
        public string PostedTaxInvoiceNos { get; set; }
        public string PostedTaxCreditMemoNos { get; set; }
        public string PostedNonTaxInvoiceNos { get; set; }
        public string PostedNonTaxCreditMemoNos { get; set; }
        public byte? EnableVendorGstamountAcy { get; set; }
        public string PostDatedCheckTemplate { get; set; }
        public string PostDatedCheckBatch { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string PrepaymentAccount { get; set; }
    }
}
