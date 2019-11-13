using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class GenPostingSetup
    {
        public int GeneralPostingSetupId { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string SalesAccount { get; set; }
        public string SalesLineDiscAccount { get; set; }
        public string SalesInvDiscAccount { get; set; }
        public string SalesPmtDiscDebitAcc { get; set; }
        public string PurchAccount { get; set; }
        public string PurchLineDiscAccount { get; set; }
        public string PurchInvDiscAccount { get; set; }
        public string PurchPmtDiscCreditAcc { get; set; }
        public string Cogsaccount { get; set; }
        public string InventoryAdjmtAccount { get; set; }
        public string JobSalesAdjmtAccount { get; set; }
        public string JobCostAdjmtAccount { get; set; }
        public string SalesCreditMemoAccount { get; set; }
        public string PurchCreditMemoAccount { get; set; }
        public string SalesPmtDiscCreditAcc { get; set; }
        public string PurchPmtDiscDebitAcc { get; set; }
        public string SalesPmtTolDebitAcc { get; set; }
        public string SalesPmtTolCreditAcc { get; set; }
        public string PurchPmtTolDebitAcc { get; set; }
        public string PurchPmtTolCreditAcc { get; set; }
        public string SalesPrepaymentsAccount { get; set; }
        public string PurchPrepaymentsAccount { get; set; }
        public string PurchFadiscAccount { get; set; }
        public string InvtAccrualAccInterim { get; set; }
        public string CogsaccountInterim { get; set; }
        public string DirectCostAppliedAccount { get; set; }
        public string OverheadAppliedAccount { get; set; }
        public string PurchaseVarianceAccount { get; set; }
        public string PoslineDiscAccount { get; set; }
        public string PosinvDiscAccount { get; set; }
        public string PosinfoCodeDiscAccount { get; set; }
        public string PosperiodicDiscAccount { get; set; }
        public string PoscustDiscAccount { get; set; }
        public string PoscoupDiscAccount { get; set; }
        public string PoslineDiscOfferAccount { get; set; }
        public string PostotalDiscOfferAccount { get; set; }
        public string PostenderTypeDiscAccount { get; set; }
        public string SalesLandedCostAccount { get; set; }
        public string PurchaseLandedCostAccount { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string Focaccount { get; set; }
    }
}
