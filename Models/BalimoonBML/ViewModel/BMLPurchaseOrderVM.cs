using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models.BalimoonBML.ViewModel
{
    public class BMLPurchaseOrderVM
    {
        public ItemLedgerEntry itemLedgerEntry { get; set; }
        public PurchaseRequisitionHeader purchaseRequisitionHeader { get; set; }
        public PurchaseRequisitionLine purchaseRequisitionLine { get; set; }
        public PurchaseContractHeader purchaseContractHeader { get; set; }
        public PurchaseContractLines purchaseContractLines { set; get; }
        public PurchaseCrMemoHeader purchaseCrMemoHeader { set; get; }
        public PurchaseCrMemoLine purchaseCrMemoLine { get; set; }
        public PurchaseInvoiceHeader PurchaseInvoiceHeader { get; set; }
        public PurchaseInvoiceLine purchaseInvoiceLine { get; set; }
        public PurchaseLineDiscount purchaseLineDiscount { get; set; }
        public PurchasePrepaymentPercent purchasePrepaymentPercent { get; set; }
        public PurchasePrice purchasePrice { get; set; }
        public PurchaseRcptHeader purchaseRcptHeader { get; set; }
        public PurchaseRcptLine purchaseRcptLine { get; set; }
        public PurchasesHeader purchasesHeader { get; set; }
        public PurchasesLine purchasesLine { get; set; }
        public PurchasesPayablesSetup purchasesPayablesSetup { get; set; }
        public ApprovalEntry approvalEntry { get; set; }
        public Items items { get; set; }

    }
}
