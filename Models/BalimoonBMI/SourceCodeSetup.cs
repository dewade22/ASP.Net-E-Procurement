using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class SourceCodeSetup
    {
        public int SourceCodeSetupId { get; set; }
        public string Sales { get; set; }
        public string Purchases { get; set; }
        public string InventoryPostCost { get; set; }
        public string ExchangeRateAdjmt { get; set; }
        public string PostRecognition { get; set; }
        public string PostValue { get; set; }
        public string CloseIncomeStatement { get; set; }
        public string Consolidation { get; set; }
        public string GeneralJournal { get; set; }
        public string SalesJournal { get; set; }
        public string PurchaseJournal { get; set; }
        public string CashReceiptJournal { get; set; }
        public string PaymentJournal { get; set; }
        public string ItemJournal { get; set; }
        public string Bomjournal { get; set; }
        public string ResourceJournal { get; set; }
        public string JobJournal { get; set; }
        public string SalesEntryApplication { get; set; }
        public string PurchaseEntryApplication { get; set; }
        public string Vatsettlement { get; set; }
        public string CompressGl { get; set; }
        public string CompressVatentries { get; set; }
        public string CompressCustLedger { get; set; }
        public string CompressVendLedger { get; set; }
        public string CompressItemLedger { get; set; }
        public string CompressBomledger { get; set; }
        public string CompressResLedger { get; set; }
        public string CompressJobLedger { get; set; }
        public string ItemReclassJournal { get; set; }
        public string PhysInventoryJournal { get; set; }
        public string CompressBankAccLedger { get; set; }
        public string CompressCheckLedger { get; set; }
        public string FinanciallyVoidedCheck { get; set; }
        public string FinanceChargeMemo { get; set; }
        public string Reminder { get; set; }
        public string DeletedDocument { get; set; }
        public string AdjustAddReportingCurrency { get; set; }
        public string TransBankRectoGenJnl { get; set; }
        public string IcgeneralJournal { get; set; }
        public string UnappliedSalesEntryAppln { get; set; }
        public string UnappliedPurchEntryAppln { get; set; }
        public string Reversal { get; set; }
        public string JobGljournal { get; set; }
        public string JobGlwip { get; set; }
        public string ConsumptionJournal { get; set; }
        public string OutputJournal { get; set; }
        public string Flushing { get; set; }
        public string CapacityJournal { get; set; }
        public string ProductionJournal { get; set; }
        public string FixedAssetJournal { get; set; }
        public string FixedAssetGljournal { get; set; }
        public string InsuranceJournal { get; set; }
        public string CompressFaledger { get; set; }
        public string CompressMaintenanceLedger { get; set; }
        public string CompressInsuranceLedger { get; set; }
        public string Transfer { get; set; }
        public string RevaluationJournal { get; set; }
        public string AdjustCost { get; set; }
        public string ServiceManagement { get; set; }
        public string WhseItemJournal { get; set; }
        public string WhsePhysInvtJournal { get; set; }
        public string WhseReclassificationJournal { get; set; }
        public string WhsePutaway { get; set; }
        public string WhsePick { get; set; }
        public string WhseMovement { get; set; }
        public string CompressWhseEntries { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
