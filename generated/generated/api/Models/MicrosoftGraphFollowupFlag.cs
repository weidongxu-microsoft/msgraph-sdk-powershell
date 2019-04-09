namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>followupFlag</summary>
    public partial class MicrosoftGraphFollowupFlag : Sample.API.Models.IMicrosoftGraphFollowupFlag
    {
        /// <summary>Backing field for <see cref="CompletedDateTime" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _completedDateTime;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone CompletedDateTime
        {
            get
            {
                return this._completedDateTime;
            }
            set
            {
                this._completedDateTime = value;
            }
        }
        public string CompletedDateTimeDateTime
        {
            get
            {
                return /*1*/CompletedDateTime/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/CompletedDateTime/*4*/.DateTime/*3*/ = value;
            }
        }
        public string CompletedDateTimeZone
        {
            get
            {
                return /*1*/CompletedDateTime/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/CompletedDateTime/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DueDateTime" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _dueDateTime;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone DueDateTime
        {
            get
            {
                return this._dueDateTime;
            }
            set
            {
                this._dueDateTime = value;
            }
        }
        public string DueDateTimeDateTime
        {
            get
            {
                return /*1*/DueDateTime/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/DueDateTime/*4*/.DateTime/*3*/ = value;
            }
        }
        public string DueDateTimeZone
        {
            get
            {
                return /*1*/DueDateTime/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/DueDateTime/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="FlagStatus" /> property.</summary>
        private string _flagStatus;

        /// <summary>followupFlagStatus</summary>
        public string FlagStatus
        {
            get
            {
                return this._flagStatus;
            }
            set
            {
                this._flagStatus = value;
            }
        }
        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _startDateTime;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone StartDateTime
        {
            get
            {
                return this._startDateTime;
            }
            set
            {
                this._startDateTime = value;
            }
        }
        public string StartDateTimeDateTime
        {
            get
            {
                return /*1*/StartDateTime/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/StartDateTime/*4*/.DateTime/*3*/ = value;
            }
        }
        public string StartDateTimeZone
        {
            get
            {
                return /*1*/StartDateTime/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/StartDateTime/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphFollowupFlag" /> instance.</summary>
        public MicrosoftGraphFollowupFlag()
        {
        }
    }
    /// followupFlag
    public partial interface IMicrosoftGraphFollowupFlag : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphDateTimeZone CompletedDateTime { get; set; }
        string CompletedDateTimeDateTime { get; set; }
        string CompletedDateTimeZone { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone DueDateTime { get; set; }
        string DueDateTimeDateTime { get; set; }
        string DueDateTimeZone { get; set; }
        string FlagStatus { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone StartDateTime { get; set; }
        string StartDateTimeDateTime { get; set; }
        string StartDateTimeZone { get; set; }
    }
}