using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class ValidationPeriod
    {
        public int ValidationPeriodId { get; set; }
        public string ValidationNo { get; set; }
        public string Description { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime? StartingTime { get; set; }
        public DateTime? EndingTime { get; set; }
        public byte? TimewithinBounds { get; set; }
        public byte? EndingTimeAfterMidnight { get; set; }
        public DateTime? MonStartingTime { get; set; }
        public DateTime? MonEndingTime { get; set; }
        public byte? MonTimewithinBounds { get; set; }
        public byte? MonEndTimeAfterMidnight { get; set; }
        public DateTime? TueStartingTime { get; set; }
        public DateTime? TueEndingTime { get; set; }
        public byte? TueTimewithinBounds { get; set; }
        public byte? TueEndTimeAfterMidnight { get; set; }
        public DateTime? WedStartingTime { get; set; }
        public DateTime? WedEndingTime { get; set; }
        public byte? WedTimewithinBounds { get; set; }
        public byte? WedEndTimeAfterMidnight { get; set; }
        public DateTime? ThuStartingTime { get; set; }
        public DateTime? ThuEndingTime { get; set; }
        public byte? ThuTimewithinBounds { get; set; }
        public byte? ThuEndTimeAfterMidnight { get; set; }
        public DateTime? FriStartingTime { get; set; }
        public DateTime? FriEndingTime { get; set; }
        public byte? FriTimewithinBounds { get; set; }
        public byte? FriEndTimeAfterMidnight { get; set; }
        public DateTime? SatStartingTime { get; set; }
        public DateTime? SatEndingTime { get; set; }
        public byte? SatTimewithinBounds { get; set; }
        public byte? SatEndTimeAfterMidnight { get; set; }
        public DateTime? SunStartingTime { get; set; }
        public DateTime? SunEndingTime { get; set; }
        public byte? SunTimewithinBounds { get; set; }
        public byte? SunEndTimeAfterMidnight { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
