namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>automaticRepliesSetting</summary>
    public partial class MicrosoftGraphAutomaticRepliesSetting : Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting
    {
        /// <summary>Backing field for <see cref="ExternalAudience" /> property.</summary>
        private string _externalAudience;

        /// <summary>externalAudienceScope</summary>
        public string ExternalAudience
        {
            get
            {
                return this._externalAudience;
            }
            set
            {
                this._externalAudience = value;
            }
        }
        /// <summary>Backing field for <see cref="ExternalReplyMessage" /> property.</summary>
        private string _externalReplyMessage;

        public string ExternalReplyMessage
        {
            get
            {
                return this._externalReplyMessage;
            }
            set
            {
                this._externalReplyMessage = value;
            }
        }
        /// <summary>Backing field for <see cref="InternalReplyMessage" /> property.</summary>
        private string _internalReplyMessage;

        public string InternalReplyMessage
        {
            get
            {
                return this._internalReplyMessage;
            }
            set
            {
                this._internalReplyMessage = value;
            }
        }
        /// <summary>Backing field for <see cref="ScheduledEndDateTime" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _scheduledEndDateTime;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone ScheduledEndDateTime
        {
            get
            {
                return this._scheduledEndDateTime;
            }
            set
            {
                this._scheduledEndDateTime = value;
            }
        }
        public string ScheduledEndDateTimeDateTime
        {
            get
            {
                return /*1*/ScheduledEndDateTime/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/ScheduledEndDateTime/*4*/.DateTime/*3*/ = value;
            }
        }
        public string ScheduledEndDateTimeZone
        {
            get
            {
                return /*1*/ScheduledEndDateTime/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/ScheduledEndDateTime/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ScheduledStartDateTime" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _scheduledStartDateTime;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone ScheduledStartDateTime
        {
            get
            {
                return this._scheduledStartDateTime;
            }
            set
            {
                this._scheduledStartDateTime = value;
            }
        }
        public string ScheduledStartDateTimeDateTime
        {
            get
            {
                return /*1*/ScheduledStartDateTime/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/ScheduledStartDateTime/*4*/.DateTime/*3*/ = value;
            }
        }
        public string ScheduledStartDateTimeZone
        {
            get
            {
                return /*1*/ScheduledStartDateTime/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/ScheduledStartDateTime/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>automaticRepliesStatus</summary>
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAutomaticRepliesSetting" /> instance.</summary>
        public MicrosoftGraphAutomaticRepliesSetting()
        {
        }
    }
    /// automaticRepliesSetting
    public partial interface IMicrosoftGraphAutomaticRepliesSetting : Sample.API.Runtime.IJsonSerializable {
        string ExternalAudience { get; set; }
        string ExternalReplyMessage { get; set; }
        string InternalReplyMessage { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone ScheduledEndDateTime { get; set; }
        string ScheduledEndDateTimeDateTime { get; set; }
        string ScheduledEndDateTimeZone { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone ScheduledStartDateTime { get; set; }
        string ScheduledStartDateTimeDateTime { get; set; }
        string ScheduledStartDateTimeZone { get; set; }
        string Status { get; set; }
    }
}