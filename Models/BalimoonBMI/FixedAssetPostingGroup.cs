using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class FixedAssetPostingGroup
    {
        public int FixedAssetPostingGroupId { get; set; }
        public string Code { get; set; }
        public string AcquisitionCostAccount { get; set; }
        public string AccumDepreciationAccount { get; set; }
        public string WriteDownAccount { get; set; }
        public string AppreciationAccount { get; set; }
        public string Custom1Account { get; set; }
        public string Custom2Account { get; set; }
        public string AcqCostAcconDisposal { get; set; }
        public string AccumDeprAcconDisposal { get; set; }
        public string WriteDownAcconDisposal { get; set; }
        public string AppreciationAcconDisposal { get; set; }
        public string Custom1AccountonDisposal { get; set; }
        public string Custom2AccountonDisposal { get; set; }
        public string GainsAcconDisposal { get; set; }
        public string LossesAcconDisposal { get; set; }
        public string BookValAcconDispGain { get; set; }
        public string SalesAcconDispGain { get; set; }
        public string WriteDownBalAcconDisp { get; set; }
        public string ApprecBalAcconDisp { get; set; }
        public string Custom1BalAcconDisposal { get; set; }
        public string Custom2BalAcconDisposal { get; set; }
        public string MaintenanceExpenseAccount { get; set; }
        public string MaintenanceBalAcc { get; set; }
        public string AcquisitionCostBalAcc { get; set; }
        public string DepreciationExpenseAcc { get; set; }
        public string WriteDownExpenseAcc { get; set; }
        public string AppreciationBalAccount { get; set; }
        public string Custom1ExpenseAcc { get; set; }
        public string Custom2ExpenseAcc { get; set; }
        public string SalesBalAcc { get; set; }
        public string SalesAcconDispLoss { get; set; }
        public string BookValAcconDispLoss { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
