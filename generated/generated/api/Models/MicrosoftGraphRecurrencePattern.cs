namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>recurrencePattern</summary>
    public partial class MicrosoftGraphRecurrencePattern : Sample.API.Models.IMicrosoftGraphRecurrencePattern
    {
        /// <summary>Backing field for <see cref="DayOfMonth" /> property.</summary>
        private int? _dayOfMonth;

        public int? DayOfMonth
        {
            get
            {
                return this._dayOfMonth;
            }
            set
            {
                this._dayOfMonth = value;
            }
        }
        /// <summary>Backing field for <see cref="DaysOfWeek" /> property.</summary>
        private string[] _daysOfWeek;

        public string[] DaysOfWeek
        {
            get
            {
                return this._daysOfWeek;
            }
            set
            {
                this._daysOfWeek = value;
            }
        }
        /// <summary>Backing field for <see cref="FirstDayOfWeek" /> property.</summary>
        private string _firstDayOfWeek;

        /// <summary>dayOfWeek</summary>
        public string FirstDayOfWeek
        {
            get
            {
                return this._firstDayOfWeek;
            }
            set
            {
                this._firstDayOfWeek = value;
            }
        }
        /// <summary>Backing field for <see cref="Index" /> property.</summary>
        private string _index;

        /// <summary>weekIndex</summary>
        public string Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        /// <summary>Backing field for <see cref="Interval" /> property.</summary>
        private int? _interval;

        public int? Interval
        {
            get
            {
                return this._interval;
            }
            set
            {
                this._interval = value;
            }
        }
        /// <summary>Backing field for <see cref="Month" /> property.</summary>
        private int? _month;

        public int? Month
        {
            get
            {
                return this._month;
            }
            set
            {
                this._month = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>recurrencePatternType</summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphRecurrencePattern" /> instance.</summary>
        public MicrosoftGraphRecurrencePattern()
        {
        }
    }
    /// recurrencePattern
    public partial interface IMicrosoftGraphRecurrencePattern : Sample.API.Runtime.IJsonSerializable {
        int? DayOfMonth { get; set; }
        string[] DaysOfWeek { get; set; }
        string FirstDayOfWeek { get; set; }
        string Index { get; set; }
        int? Interval { get; set; }
        int? Month { get; set; }
        string Type { get; set; }
    }
}