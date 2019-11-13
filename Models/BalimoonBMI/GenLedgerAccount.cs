using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class GenLedgerAccount
    {
        public int GenLedgerAccountId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string SearchName { get; set; }
        public int? AccountType { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public int? IncomeBalance { get; set; }
        public int? DebitCredit { get; set; }
        public string No2 { get; set; }
        public byte? Blocked { get; set; }
        public byte? DirectPosting { get; set; }
        public byte? ReconciliationAccount { get; set; }
        public byte? NewPage { get; set; }
        public int? NoofBlankLines { get; set; }
        public int? Indentation { get; set; }
        public string ConsolidationtoId { get; set; }
        public int? ConsolTranslationMethod { get; set; }
        public string ConsolDebitAcc { get; set; }
        public string ConsolCreditAcc { get; set; }
        public int? GenPostingType { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string PictureFileName { get; set; }
        public byte? AutomaticExtTexts { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public int? ExchangeRateAdjustment { get; set; }
        public string DefaultIcpartnerGenLedgerAccNo { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public int? AccountCategory { get; set; }
        public int? AccountSubCategory { get; set; }
    }
}
