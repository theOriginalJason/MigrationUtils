using System;

namespace MigrationUtils.Dal.Models
{
    public class DateDimension
    {
        public int DateKey { get; set; }

        public DateTime Date { get; set; }

        public byte Day { get; set; }

        public string DaySuffix { get; set; }

        public byte Weekday { get; set; }

        public string WeekDayName { get; set; }

        public bool IsWeekend { get; set; }

        public bool IsHoliday { get; set; }

        public string HolidayText { get; set; }

        public byte DOWInMonth { get; set; }

        public short DayOfYear { get; set; }

        public byte WeekOfMonth { get; set; }

        public byte WeekOfYear { get; set; }

        public byte ISOWeekOfYear { get; set; }

        public byte Month { get; set; }

        public string MonthName { get; set; }

        public byte Quarter { get; set; }

        public string QuarterName { get; set; }

        public int Year { get; set; }

        public string MMYYYY { get; set; }

        public string MonthYear { get; set; }

        public DateTime FirstDayOfMonth { get; set; }

        public DateTime LastDayOfMonth { get; set; }

        public DateTime FirstDayOfQuarter { get; set; }

        public DateTime LastDayOfQuarter { get; set; }

        public DateTime FirstDayOfYear { get; set; }

        public DateTime LastDayOfYear { get; set; }

        public DateTime FirstDayOfNextMonth { get; set; }

         public DateTime FirstDayOfNextYear { get; set; }
    }
}