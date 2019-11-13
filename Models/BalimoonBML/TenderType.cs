using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class TenderType
    {
        public int TenderTypeId { get; set; }
        public string StoreNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Function { get; set; }
        public string NoinTransaction { get; set; }
        public string ChangeTendCode { get; set; }
        public string AboveMinChangeTenderType { get; set; }
        public decimal? MinChange { get; set; }
        public int? Rounding { get; set; }
        public decimal? RoundingTo { get; set; }
        public decimal? MinAmountEntered { get; set; }
        public decimal? MaxAmountEntered { get; set; }
        public decimal? MinAmountAllowed { get; set; }
        public decimal? MaxAmountAllowed { get; set; }
        public byte? MayBeUsed { get; set; }
        public byte? ManagerKeyControl { get; set; }
        public byte? KeyboardEntryAllowed { get; set; }
        public byte? OvertenderAllowed { get; set; }
        public decimal? OvertenderMaxAmt { get; set; }
        public byte? UndertenderAllowed { get; set; }
        public byte? ReturnMinusAllowed { get; set; }
        public byte? DrawerOpens { get; set; }
        public byte? EndorseCheck { get; set; }
        public byte? CardAccountNo { get; set; }
        public byte? AskforDate { get; set; }
        public int? SeekAuthorization { get; set; }
        public byte? PrintSeparateInvoice { get; set; }
        public byte? FrontofCheck { get; set; }
        public byte? KeyboardEntryRequired { get; set; }
        public byte? PayAccountBill { get; set; }
        public byte? MarkingOnly { get; set; }
        public byte? ForeignCurrency { get; set; }
        public string EndorsementLine1 { get; set; }
        public string EndorsementLine2 { get; set; }
        public string CheckPayee { get; set; }
        public string SlipBackinPrinter { get; set; }
        public string AskforCardAccount { get; set; }
        public string InvoiceinPrinter { get; set; }
        public string SlipFrontinPrinter { get; set; }
        public string ChangeLineonReceipt { get; set; }
        public byte? PoscountEntries { get; set; }
        public byte? TakentoBank { get; set; }
        public byte? CountingRequired { get; set; }
        public byte? FloatAllowed { get; set; }
        public byte? MultiplyinTenderOperations { get; set; }
        public int? AccountType { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public decimal? ChargePercent { get; set; }
        public string ChargetoAccountNo { get; set; }
        public string DifferenceGlacc { get; set; }
        public byte? CompressPaymEntries { get; set; }
        public byte? PrintinCidreport { get; set; }
        public decimal? PospickupWarningAmount { get; set; }
        public int? BankAccountType { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountName { get; set; }
        public string BankDiffGlacc { get; set; }
        public byte? TakentoSafe { get; set; }
        public string PospickupWarningText { get; set; }
        public byte? CountbyDenominations { get; set; }
        public string RemoveFloatType { get; set; }
        public byte? AutoAccountPaymentTender { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
