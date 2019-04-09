namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>patternedRecurrence</summary>
    public partial class MicrosoftGraphPatternedRecurrence : Sample.API.Models.IMicrosoftGraphPatternedRecurrence
    {
        /// <summary>Backing field for <see cref="Pattern" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecurrencePattern _pattern;

        /// <summary>recurrencePattern</summary>
        public Sample.API.Models.IMicrosoftGraphRecurrencePattern Pattern
        {
            get
            {
                return this._pattern;
            }
            set
            {
                this._pattern = value;
            }
        }
        public int? PatternDayOfMonth
        {
            get
            {
                return /*1*/Pattern/*4*/.DayOfMonth/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.DayOfMonth/*3*/ = value;
            }
        }
        public string[] PatternDaysOfWeek
        {
            get
            {
                return /*1*/Pattern/*4*/.DaysOfWeek/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.DaysOfWeek/*3*/ = value;
            }
        }
        /// <summary>dayOfWeek</summary>
        public string PatternFirstDayOfWeek
        {
            get
            {
                return /*1*/Pattern/*4*/.FirstDayOfWeek/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.FirstDayOfWeek/*3*/ = value;
            }
        }
        /// <summary>weekIndex</summary>
        public string PatternIndex
        {
            get
            {
                return /*1*/Pattern/*4*/.Index/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.Index/*3*/ = value;
            }
        }
        public int? PatternInterval
        {
            get
            {
                return /*1*/Pattern/*4*/.Interval/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.Interval/*3*/ = value;
            }
        }
        public int? PatternMonth
        {
            get
            {
                return /*1*/Pattern/*4*/.Month/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.Month/*3*/ = value;
            }
        }
        /// <summary>recurrencePatternType</summary>
        public string PatternType
        {
            get
            {
                return /*1*/Pattern/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/Pattern/*4*/.Type/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Range" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecurrenceRange _range;

        /// <summary>recurrenceRange</summary>
        public Sample.API.Models.IMicrosoftGraphRecurrenceRange Range
        {
            get
            {
                return this._range;
            }
            set
            {
                this._range = value;
            }
        }
        public System.DateTime? RangeEndDate
        {
            get
            {
                return /*1*/Range/*4*/.EndDate/*3*/;
            }
            set
            {
                /*1*/Range/*4*/.EndDate/*3*/ = value;
            }
        }
        public int? RangeNumberOfOccurrences
        {
            get
            {
                return /*1*/Range/*4*/.NumberOfOccurrences/*3*/;
            }
            set
            {
                /*1*/Range/*4*/.NumberOfOccurrences/*3*/ = value;
            }
        }
        public string RangeRecurrenceTimeZone
        {
            get
            {
                return /*1*/Range/*4*/.RecurrenceTimeZone/*3*/;
            }
            set
            {
                /*1*/Range/*4*/.RecurrenceTimeZone/*3*/ = value;
            }
        }
        public System.DateTime? RangeStartDate
        {
            get
            {
                return /*1*/Range/*4*/.StartDate/*3*/;
            }
            set
            {
                /*1*/Range/*4*/.StartDate/*3*/ = value;
            }
        }
        /// <summary>recurrenceRangeType</summary>
        public string RangeType
        {
            get
            {
                return /*1*/Range/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/Range/*4*/.Type/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPatternedRecurrence" /> instance.</summary>
        public MicrosoftGraphPatternedRecurrence()
        {
        }
    }
    /// patternedRecurrence
    public partial interface IMicrosoftGraphPatternedRecurrence : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphRecurrencePattern Pattern { get; set; }
        int? PatternDayOfMonth { get; set; }
        string[] PatternDaysOfWeek { get; set; }
        string PatternFirstDayOfWeek { get; set; }
        string PatternIndex { get; set; }
        int? PatternInterval { get; set; }
        int? PatternMonth { get; set; }
        string PatternType { get; set; }
        Sample.API.Models.IMicrosoftGraphRecurrenceRange Range { get; set; }
        System.DateTime? RangeEndDate { get; set; }
        int? RangeNumberOfOccurrences { get; set; }
        string RangeRecurrenceTimeZone { get; set; }
        System.DateTime? RangeStartDate { get; set; }
        string RangeType { get; set; }
    }
}