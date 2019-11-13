using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ShopCalendarHoliday
    {
        public int ShopCalendarHolidayId { get; set; }
        public string ShopCalendarCode { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartingTime { get; set; }
        public TimeSpan EndingTime { get; set; }
        public DateTime StartingDateTime { get; set; }
        public DateTime EndingDateTime { get; set; }
        public string Description { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
