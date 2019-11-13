using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models.BalimoonBMI.ViewModel
{
    public class PurchaseRequestBMIVM
    {
        public PurchaseRequisitionHeader HeaderTbl { get; set; }
        public PurchaseRequisitionLine LineTbl { get; set; }
        public ItemLedgerEntry LedgerEntryTbl { get; set; }
    }
}
