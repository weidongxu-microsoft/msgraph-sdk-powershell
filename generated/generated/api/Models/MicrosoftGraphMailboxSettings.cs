namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>mailboxSettings</summary>
    public partial class MicrosoftGraphMailboxSettings : Sample.API.Models.IMicrosoftGraphMailboxSettings
    {
        /// <summary>Backing field for <see cref="ArchiveFolder" /> property.</summary>
        private string _archiveFolder;

        public string ArchiveFolder
        {
            get
            {
                return this._archiveFolder;
            }
            set
            {
                this._archiveFolder = value;
            }
        }
        /// <summary>Backing field for <see cref="AutomaticRepliesSetting" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting _automaticRepliesSetting;

        /// <summary>automaticRepliesSetting</summary>
        public Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting AutomaticRepliesSetting
        {
            get
            {
                return this._automaticRepliesSetting;
            }
            set
            {
                this._automaticRepliesSetting = value;
            }
        }
        /// <summary>externalAudienceScope</summary>
        public string AutomaticRepliesSettingExternalAudience
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ExternalAudience/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ExternalAudience/*3*/ = value;
            }
        }
        public string AutomaticRepliesSettingExternalReplyMessage
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ExternalReplyMessage/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ExternalReplyMessage/*3*/ = value;
            }
        }
        public string AutomaticRepliesSettingInternalReplyMessage
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.InternalReplyMessage/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.InternalReplyMessage/*3*/ = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledEndDateTime
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ScheduledEndDateTime/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ScheduledEndDateTime/*3*/ = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledStartDateTime
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ScheduledStartDateTime/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ScheduledStartDateTime/*3*/ = value;
            }
        }
        /// <summary>automaticRepliesStatus</summary>
        public string AutomaticRepliesSettingStatus
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.Status/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.Status/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Language" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphLocaleInfo _language;

        /// <summary>localeInfo</summary>
        public Sample.API.Models.IMicrosoftGraphLocaleInfo Language
        {
            get
            {
                return this._language;
            }
            set
            {
                this._language = value;
            }
        }
        public string LanguageDisplayName
        {
            get
            {
                return /*1*/Language/*4*/.DisplayName/*3*/;
            }
            set
            {
                /*1*/Language/*4*/.DisplayName/*3*/ = value;
            }
        }
        public string LanguageLocale
        {
            get
            {
                return /*1*/Language/*4*/.Locale/*3*/;
            }
            set
            {
                /*1*/Language/*4*/.Locale/*3*/ = value;
            }
        }
        public string ScheduledEndDateTimeDateTime
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ScheduledEndDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ScheduledEndDateTimeDateTime/*3*/ = value;
            }
        }
        public string ScheduledEndDateTimeZone
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ScheduledEndDateTimeZone/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ScheduledEndDateTimeZone/*3*/ = value;
            }
        }
        public string ScheduledStartDateTimeDateTime
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ScheduledStartDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ScheduledStartDateTimeDateTime/*3*/ = value;
            }
        }
        public string ScheduledStartDateTimeZone
        {
            get
            {
                return /*1*/AutomaticRepliesSetting/*4*/.ScheduledStartDateTimeZone/*3*/;
            }
            set
            {
                /*1*/AutomaticRepliesSetting/*4*/.ScheduledStartDateTimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        public string TimeZone
        {
            get
            {
                return this._timeZone;
            }
            set
            {
                this._timeZone = value;
            }
        }
        public string TimeZoneName
        {
            get
            {
                return /*1*/WorkingHours/*4*/.TimeZoneName/*3*/;
            }
            set
            {
                /*1*/WorkingHours/*4*/.TimeZoneName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="WorkingHours" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkingHours _workingHours;

        /// <summary>workingHours</summary>
        public Sample.API.Models.IMicrosoftGraphWorkingHours WorkingHours
        {
            get
            {
                return this._workingHours;
            }
            set
            {
                this._workingHours = value;
            }
        }
        public string[] WorkingHoursDaysOfWeek
        {
            get
            {
                return /*1*/WorkingHours/*4*/.DaysOfWeek/*3*/;
            }
            set
            {
                /*1*/WorkingHours/*4*/.DaysOfWeek/*3*/ = value;
            }
        }
        public string WorkingHoursEndTime
        {
            get
            {
                return /*1*/WorkingHours/*4*/.EndTime/*3*/;
            }
            set
            {
                /*1*/WorkingHours/*4*/.EndTime/*3*/ = value;
            }
        }
        public string WorkingHoursStartTime
        {
            get
            {
                return /*1*/WorkingHours/*4*/.StartTime/*3*/;
            }
            set
            {
                /*1*/WorkingHours/*4*/.StartTime/*3*/ = value;
            }
        }
        /// <summary>timeZoneBase</summary>
        public Sample.API.Models.IMicrosoftGraphTimeZoneBase WorkingHoursTimeZone
        {
            get
            {
                return /*1*/WorkingHours/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/WorkingHours/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphMailboxSettings" /> instance.</summary>
        public MicrosoftGraphMailboxSettings()
        {
        }
    }
    /// mailboxSettings
    public partial interface IMicrosoftGraphMailboxSettings : Sample.API.Runtime.IJsonSerializable {
        string ArchiveFolder { get; set; }
        Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting AutomaticRepliesSetting { get; set; }
        string AutomaticRepliesSettingExternalAudience { get; set; }
        string AutomaticRepliesSettingExternalReplyMessage { get; set; }
        string AutomaticRepliesSettingInternalReplyMessage { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledEndDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledStartDateTime { get; set; }
        string AutomaticRepliesSettingStatus { get; set; }
        Sample.API.Models.IMicrosoftGraphLocaleInfo Language { get; set; }
        string LanguageDisplayName { get; set; }
        string LanguageLocale { get; set; }
        string ScheduledEndDateTimeDateTime { get; set; }
        string ScheduledEndDateTimeZone { get; set; }
        string ScheduledStartDateTimeDateTime { get; set; }
        string ScheduledStartDateTimeZone { get; set; }
        string TimeZone { get; set; }
        string TimeZoneName { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkingHours WorkingHours { get; set; }
        string[] WorkingHoursDaysOfWeek { get; set; }
        string WorkingHoursEndTime { get; set; }
        string WorkingHoursStartTime { get; set; }
        Sample.API.Models.IMicrosoftGraphTimeZoneBase WorkingHoursTimeZone { get; set; }
    }
}