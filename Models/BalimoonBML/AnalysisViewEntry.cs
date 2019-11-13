using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class AnalysisViewEntry
    {
        public int AnalysisViewEntryId { get; set; }
        public string AnalysisViewCode { get; set; }
        public string GlaccountNo { get; set; }
        public string Dimension1ValueCode { get; set; }
        public string Dimension2ValueCode { get; set; }
        public string Dimension3ValueCode { get; set; }
        public string Dimension4ValueCode { get; set; }
        public string BusinessUnitCode { get; set; }
        public DateTime PostingDate { get; set; }
        public int EntryNo { get; set; }
        public decimal Amount { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal AddCurrAmount { get; set; }
        public decimal AddCurrDebitAmount { get; set; }
        public decimal AddCurrCreditAmount { get; set; }
    }
}
