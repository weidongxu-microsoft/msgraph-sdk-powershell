namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>recurrenceRange</summary>
    public partial class MicrosoftGraphRecurrenceRange : Sample.API.Models.IMicrosoftGraphRecurrenceRange
    {
        /// <summary>Backing field for <see cref="EndDate" /> property.</summary>
        private System.DateTime? _endDate;

        public System.DateTime? EndDate
        {
            get
            {
                return this._endDate;
            }
            set
            {
                this._endDate = value;
            }
        }
        /// <summary>Backing field for <see cref="NumberOfOccurrences" /> property.</summary>
        private int? _numberOfOccurrences;

        public int? NumberOfOccurrences
        {
            get
            {
                return this._numberOfOccurrences;
            }
            set
            {
                this._numberOfOccurrences = value;
            }
        }
        /// <summary>Backing field for <see cref="RecurrenceTimeZone" /> property.</summary>
        private string _recurrenceTimeZone;

        public string RecurrenceTimeZone
        {
            get
            {
                return this._recurrenceTimeZone;
            }
            set
            {
                this._recurrenceTimeZone = value;
            }
        }
        /// <summary>Backing field for <see cref="StartDate" /> property.</summary>
        private System.DateTime? _startDate;

        public System.DateTime? StartDate
        {
            get
            {
                return this._startDate;
            }
            set
            {
                this._startDate = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>recurrenceRangeType</summary>
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
        /// <summary>Creates an new <see cref="MicrosoftGraphRecurrenceRange" /> instance.</summary>
        public MicrosoftGraphRecurrenceRange()
        {
        }
    }
    /// recurrenceRange
    public partial interface IMicrosoftGraphRecurrenceRange : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? EndDate { get; set; }
        int? NumberOfOccurrences { get; set; }
        string RecurrenceTimeZone { get; set; }
        System.DateTime? StartDate { get; set; }
        string Type { get; set; }
    }
}