using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CustomerPostingGroup
    {
        public int CustomerPostingGroupId { get; set; }
        public string Code { get; set; }
        public string ReceivablesAccount { get; set; }
        public string ServiceChargeAcc { get; set; }
        public string PaymentDiscDebitAcc { get; set; }
        public string InvoiceRoundingAccount { get; set; }
        public string AdditionalFeeAccount { get; set; }
        public string InterestAccount { get; set; }
        public string DebitCurrApplnRndgAcc { get; set; }
        public string CreditCurrApplnRndgAcc { get; set; }
        public string DebitRoundingAccount { get; set; }
        public string CreditRoundingAccount { get; set; }
        public string PaymentDiscCreditAcc { get; set; }
        public string PaymentToleranceDebitAcc { get; set; }
        public string PaymentToleranceCreditAcc { get; set; }
        public byte? NonTaxable { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
