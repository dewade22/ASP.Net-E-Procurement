using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ShopCalendarWorkingDays
    {
        public int ShopCalendarWorkingDaysId { get; set; }
        public string ShopCalendarCode { get; set; }
        public int Day { get; set; }
        public TimeSpan StartingTime { get; set; }
        public TimeSpan EndingTime { get; set; }
        public string WorkShiftCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
