namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>event</summary>
    public partial class ComponentsSchemasMicrosoftGraphEventAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphEventAllof1
    {
        public string AddressCity
        {
            get
            {
                return /*1*/Location/*4*/.AddressCity/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.AddressCity/*3*/ = value;
            }
        }
        public string AddressCountryOrRegion
        {
            get
            {
                return /*1*/Location/*4*/.AddressCountryOrRegion/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.AddressCountryOrRegion/*3*/ = value;
            }
        }
        public string AddressEmailAddress
        {
            get
            {
                return /*1*/Organizer/*4*/.AddressEmailAddress/*3*/;
            }
            set
            {
                /*1*/Organizer/*4*/.AddressEmailAddress/*3*/ = value;
            }
        }
        public string AddressPostalCode
        {
            get
            {
                return /*1*/Location/*4*/.AddressPostalCode/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.AddressPostalCode/*3*/ = value;
            }
        }
        public string AddressState
        {
            get
            {
                return /*1*/Location/*4*/.AddressState/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.AddressState/*3*/ = value;
            }
        }
        public string AddressStreet
        {
            get
            {
                return /*1*/Location/*4*/.AddressStreet/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.AddressStreet/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Attachments" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAttachment[] _attachments;

        public Sample.API.Models.IMicrosoftGraphAttachment[] Attachments
        {
            get
            {
                return this._attachments;
            }
            set
            {
                this._attachments = value;
            }
        }
        /// <summary>Backing field for <see cref="Attendees" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAttendee[] _attendees;

        public Sample.API.Models.IMicrosoftGraphAttendee[] Attendees
        {
            get
            {
                return this._attendees;
            }
            set
            {
                this._attendees = value;
            }
        }
        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphItemBody _body;

        /// <summary>itemBody</summary>
        public Sample.API.Models.IMicrosoftGraphItemBody Body
        {
            get
            {
                return this._body;
            }
            set
            {
                this._body = value;
            }
        }
        public string BodyContent
        {
            get
            {
                return /*1*/Body/*4*/.Content/*3*/;
            }
            set
            {
                /*1*/Body/*4*/.Content/*3*/ = value;
            }
        }
        /// <summary>bodyType</summary>
        public string BodyContentType
        {
            get
            {
                return /*1*/Body/*4*/.ContentType/*3*/;
            }
            set
            {
                /*1*/Body/*4*/.ContentType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="BodyPreview" /> property.</summary>
        private string _bodyPreview;

        public string BodyPreview
        {
            get
            {
                return this._bodyPreview;
            }
            set
            {
                this._bodyPreview = value;
            }
        }
        /// <summary>Backing field for <see cref="Calendar" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphCalendar _calendar;

        public Sample.API.Models.IMicrosoftGraphCalendar Calendar
        {
            get
            {
                return this._calendar;
            }
            set
            {
                this._calendar = value;
            }
        }
        public double? CoordinatesAccuracy
        {
            get
            {
                return /*1*/Location/*4*/.CoordinatesAccuracy/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.CoordinatesAccuracy/*3*/ = value;
            }
        }
        public double? CoordinatesAltitude
        {
            get
            {
                return /*1*/Location/*4*/.CoordinatesAltitude/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.CoordinatesAltitude/*3*/ = value;
            }
        }
        public double? CoordinatesAltitudeAccuracy
        {
            get
            {
                return /*1*/Location/*4*/.CoordinatesAltitudeAccuracy/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.CoordinatesAltitudeAccuracy/*3*/ = value;
            }
        }
        public double? CoordinatesLatitude
        {
            get
            {
                return /*1*/Location/*4*/.CoordinatesLatitude/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.CoordinatesLatitude/*3*/ = value;
            }
        }
        public double? CoordinatesLongitude
        {
            get
            {
                return /*1*/Location/*4*/.CoordinatesLongitude/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.CoordinatesLongitude/*3*/ = value;
            }
        }
        public string EmailAddressName
        {
            get
            {
                return /*1*/Organizer/*4*/.EmailAddressName/*3*/;
            }
            set
            {
                /*1*/Organizer/*4*/.EmailAddressName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="End" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _end;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        public string EndDateTime
        {
            get
            {
                return /*1*/End/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/End/*4*/.DateTime/*3*/ = value;
            }
        }
        public string EndTimeZone
        {
            get
            {
                return /*1*/End/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/End/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Extensions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphExtension[] _extensions;

        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return this._extensions;
            }
            set
            {
                this._extensions = value;
            }
        }
        /// <summary>Backing field for <see cref="HasAttachments" /> property.</summary>
        private bool? _hasAttachments;

        public bool? HasAttachments
        {
            get
            {
                return this._hasAttachments;
            }
            set
            {
                this._hasAttachments = value;
            }
        }
        /// <summary>Backing field for <see cref="ICalUId" /> property.</summary>
        private string _iCalUId;

        public string ICalUId
        {
            get
            {
                return this._iCalUId;
            }
            set
            {
                this._iCalUId = value;
            }
        }
        /// <summary>Backing field for <see cref="Importance" /> property.</summary>
        private string _importance;

        /// <summary>importance</summary>
        public string Importance
        {
            get
            {
                return this._importance;
            }
            set
            {
                this._importance = value;
            }
        }
        /// <summary>Backing field for <see cref="Instances" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEvent[] _instances;

        public Sample.API.Models.IMicrosoftGraphEvent[] Instances
        {
            get
            {
                return this._instances;
            }
            set
            {
                this._instances = value;
            }
        }
        /// <summary>Backing field for <see cref="IsAllDay" /> property.</summary>
        private bool? _isAllDay;

        public bool? IsAllDay
        {
            get
            {
                return this._isAllDay;
            }
            set
            {
                this._isAllDay = value;
            }
        }
        /// <summary>Backing field for <see cref="IsCancelled" /> property.</summary>
        private bool? _isCancelled;

        public bool? IsCancelled
        {
            get
            {
                return this._isCancelled;
            }
            set
            {
                this._isCancelled = value;
            }
        }
        /// <summary>Backing field for <see cref="IsOrganizer" /> property.</summary>
        private bool? _isOrganizer;

        public bool? IsOrganizer
        {
            get
            {
                return this._isOrganizer;
            }
            set
            {
                this._isOrganizer = value;
            }
        }
        /// <summary>Backing field for <see cref="IsReminderOn" /> property.</summary>
        private bool? _isReminderOn;

        public bool? IsReminderOn
        {
            get
            {
                return this._isReminderOn;
            }
            set
            {
                this._isReminderOn = value;
            }
        }
        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphLocation _location;

        /// <summary>location</summary>
        public Sample.API.Models.IMicrosoftGraphLocation Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress LocationAddress
        {
            get
            {
                return /*1*/Location/*4*/.Address/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.Address/*3*/ = value;
            }
        }
        /// <summary>outlookGeoCoordinates</summary>
        public Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates LocationCoordinates
        {
            get
            {
                return /*1*/Location/*4*/.Coordinates/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.Coordinates/*3*/ = value;
            }
        }
        public string LocationDisplayName
        {
            get
            {
                return /*1*/Location/*4*/.DisplayName/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.DisplayName/*3*/ = value;
            }
        }
        public string LocationEmailAddress
        {
            get
            {
                return /*1*/Location/*4*/.LocationEmailAddress/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.LocationEmailAddress/*3*/ = value;
            }
        }
        /// <summary>locationType</summary>
        public string LocationType
        {
            get
            {
                return /*1*/Location/*4*/.LocationType/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.LocationType/*3*/ = value;
            }
        }
        public string LocationUniqueId
        {
            get
            {
                return /*1*/Location/*4*/.UniqueId/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.UniqueId/*3*/ = value;
            }
        }
        /// <summary>locationUniqueIdType</summary>
        public string LocationUniqueIdType
        {
            get
            {
                return /*1*/Location/*4*/.UniqueIdType/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.UniqueIdType/*3*/ = value;
            }
        }
        public string LocationUri
        {
            get
            {
                return /*1*/Location/*4*/.LocationUri/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.LocationUri/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Locations" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphLocation[] _locations;

        public Sample.API.Models.IMicrosoftGraphLocation[] Locations
        {
            get
            {
                return this._locations;
            }
            set
            {
                this._locations = value;
            }
        }
        /// <summary>Backing field for <see cref="MultiValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] _multiValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return this._multiValueExtendedProperties;
            }
            set
            {
                this._multiValueExtendedProperties = value;
            }
        }
        /// <summary>Backing field for <see cref="OnlineMeetingUrl" /> property.</summary>
        private string _onlineMeetingUrl;

        public string OnlineMeetingUrl
        {
            get
            {
                return this._onlineMeetingUrl;
            }
            set
            {
                this._onlineMeetingUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="Organizer" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRecipient _organizer;

        /// <summary>recipient</summary>
        public Sample.API.Models.IMicrosoftGraphRecipient Organizer
        {
            get
            {
                return this._organizer;
            }
            set
            {
                this._organizer = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress OrganizerEmailAddress
        {
            get
            {
                return /*1*/Organizer/*4*/.EmailAddress/*3*/;
            }
            set
            {
                /*1*/Organizer/*4*/.EmailAddress/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="OriginalEndTimeZone" /> property.</summary>
        private string _originalEndTimeZone;

        public string OriginalEndTimeZone
        {
            get
            {
                return this._originalEndTimeZone;
            }
            set
            {
                this._originalEndTimeZone = value;
            }
        }
        /// <summary>Backing field for <see cref="OriginalStart" /> property.</summary>
        private System.DateTime? _originalStart;

        public System.DateTime? OriginalStart
        {
            get
            {
                return this._originalStart;
            }
            set
            {
                this._originalStart = value;
            }
        }
        /// <summary>Backing field for <see cref="OriginalStartTimeZone" /> property.</summary>
        private string _originalStartTimeZone;

        public string OriginalStartTimeZone
        {
            get
            {
                return this._originalStartTimeZone;
            }
            set
            {
                this._originalStartTimeZone = value;
            }
        }
        public int? PatternDayOfMonth
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternDayOfMonth/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternDayOfMonth/*3*/ = value;
            }
        }
        public string[] PatternDaysOfWeek
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternDaysOfWeek/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternDaysOfWeek/*3*/ = value;
            }
        }
        /// <summary>dayOfWeek</summary>
        public string PatternFirstDayOfWeek
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternFirstDayOfWeek/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternFirstDayOfWeek/*3*/ = value;
            }
        }
        /// <summary>weekIndex</summary>
        public string PatternIndex
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternIndex/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternIndex/*3*/ = value;
            }
        }
        public int? PatternInterval
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternInterval/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternInterval/*3*/ = value;
            }
        }
        public int? PatternMonth
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternMonth/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternMonth/*3*/ = value;
            }
        }
        /// <summary>recurrencePatternType</summary>
        public string PatternType
        {
            get
            {
                return /*1*/Recurrence/*4*/.PatternType/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.PatternType/*3*/ = value;
            }
        }
        public System.DateTime? RangeEndDate
        {
            get
            {
                return /*1*/Recurrence/*4*/.RangeEndDate/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.RangeEndDate/*3*/ = value;
            }
        }
        public int? RangeNumberOfOccurrences
        {
            get
            {
                return /*1*/Recurrence/*4*/.RangeNumberOfOccurrences/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.RangeNumberOfOccurrences/*3*/ = value;
            }
        }
        public string RangeRecurrenceTimeZone
        {
            get
            {
                return /*1*/Recurrence/*4*/.RangeRecurrenceTimeZone/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.RangeRecurrenceTimeZone/*3*/ = value;
            }
        }
        public System.DateTime? RangeStartDate
        {
            get
            {
                return /*1*/Recurrence/*4*/.RangeStartDate/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.RangeStartDate/*3*/ = value;
            }
        }
        /// <summary>recurrenceRangeType</summary>
        public string RangeType
        {
            get
            {
                return /*1*/Recurrence/*4*/.RangeType/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.RangeType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Recurrence" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPatternedRecurrence _recurrence;

        /// <summary>patternedRecurrence</summary>
        public Sample.API.Models.IMicrosoftGraphPatternedRecurrence Recurrence
        {
            get
            {
                return this._recurrence;
            }
            set
            {
                this._recurrence = value;
            }
        }
        /// <summary>recurrencePattern</summary>
        public Sample.API.Models.IMicrosoftGraphRecurrencePattern RecurrencePattern
        {
            get
            {
                return /*1*/Recurrence/*4*/.Pattern/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.Pattern/*3*/ = value;
            }
        }
        /// <summary>recurrenceRange</summary>
        public Sample.API.Models.IMicrosoftGraphRecurrenceRange RecurrenceRange
        {
            get
            {
                return /*1*/Recurrence/*4*/.Range/*3*/;
            }
            set
            {
                /*1*/Recurrence/*4*/.Range/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ReminderMinutesBeforeStart" /> property.</summary>
        private int? _reminderMinutesBeforeStart;

        public int? ReminderMinutesBeforeStart
        {
            get
            {
                return this._reminderMinutesBeforeStart;
            }
            set
            {
                this._reminderMinutesBeforeStart = value;
            }
        }
        /// <summary>Backing field for <see cref="ResponseRequested" /> property.</summary>
        private bool? _responseRequested;

        public bool? ResponseRequested
        {
            get
            {
                return this._responseRequested;
            }
            set
            {
                this._responseRequested = value;
            }
        }
        /// <summary>Backing field for <see cref="ResponseStatus" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphResponseStatus _responseStatus;

        /// <summary>responseStatus</summary>
        public Sample.API.Models.IMicrosoftGraphResponseStatus ResponseStatus
        {
            get
            {
                return this._responseStatus;
            }
            set
            {
                this._responseStatus = value;
            }
        }
        /// <summary>responseType</summary>
        public string ResponseStatusResponse
        {
            get
            {
                return /*1*/ResponseStatus/*4*/.Response/*3*/;
            }
            set
            {
                /*1*/ResponseStatus/*4*/.Response/*3*/ = value;
            }
        }
        public System.DateTime? ResponseStatusTime
        {
            get
            {
                return /*1*/ResponseStatus/*4*/.Time/*3*/;
            }
            set
            {
                /*1*/ResponseStatus/*4*/.Time/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Sensitivity" /> property.</summary>
        private string _sensitivity;

        /// <summary>sensitivity</summary>
        public string Sensitivity
        {
            get
            {
                return this._sensitivity;
            }
            set
            {
                this._sensitivity = value;
            }
        }
        /// <summary>Backing field for <see cref="SeriesMasterId" /> property.</summary>
        private string _seriesMasterId;

        public string SeriesMasterId
        {
            get
            {
                return this._seriesMasterId;
            }
            set
            {
                this._seriesMasterId = value;
            }
        }
        /// <summary>Backing field for <see cref="ShowAs" /> property.</summary>
        private string _showAs;

        /// <summary>freeBusyStatus</summary>
        public string ShowAs
        {
            get
            {
                return this._showAs;
            }
            set
            {
                this._showAs = value;
            }
        }
        /// <summary>Backing field for <see cref="SingleValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] _singleValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return this._singleValueExtendedProperties;
            }
            set
            {
                this._singleValueExtendedProperties = value;
            }
        }
        /// <summary>Backing field for <see cref="Start" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDateTimeZone _start;

        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        public string StartDateTime
        {
            get
            {
                return /*1*/Start/*4*/.DateTime/*3*/;
            }
            set
            {
                /*1*/Start/*4*/.DateTime/*3*/ = value;
            }
        }
        public string StartTimeZone
        {
            get
            {
                return /*1*/Start/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/Start/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        public string Subject
        {
            get
            {
                return this._subject;
            }
            set
            {
                this._subject = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>eventType</summary>
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
        /// <summary>Backing field for <see cref="WebLink" /> property.</summary>
        private string _webLink;

        public string WebLink
        {
            get
            {
                return this._webLink;
            }
            set
            {
                this._webLink = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphEventAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphEventAllof1()
        {
        }
    }
    /// event
    public partial interface IComponentsSchemasMicrosoftGraphEventAllof1 : Sample.API.Runtime.IJsonSerializable {
        string AddressCity { get; set; }
        string AddressCountryOrRegion { get; set; }
        string AddressEmailAddress { get; set; }
        string AddressPostalCode { get; set; }
        string AddressState { get; set; }
        string AddressStreet { get; set; }
        Sample.API.Models.IMicrosoftGraphAttachment[] Attachments { get; set; }
        Sample.API.Models.IMicrosoftGraphAttendee[] Attendees { get; set; }
        Sample.API.Models.IMicrosoftGraphItemBody Body { get; set; }
        string BodyContent { get; set; }
        string BodyContentType { get; set; }
        string BodyPreview { get; set; }
        Sample.API.Models.IMicrosoftGraphCalendar Calendar { get; set; }
        double? CoordinatesAccuracy { get; set; }
        double? CoordinatesAltitude { get; set; }
        double? CoordinatesAltitudeAccuracy { get; set; }
        double? CoordinatesLatitude { get; set; }
        double? CoordinatesLongitude { get; set; }
        string EmailAddressName { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone End { get; set; }
        string EndDateTime { get; set; }
        string EndTimeZone { get; set; }
        Sample.API.Models.IMicrosoftGraphExtension[] Extensions { get; set; }
        bool? HasAttachments { get; set; }
        string ICalUId { get; set; }
        string Importance { get; set; }
        Sample.API.Models.IMicrosoftGraphEvent[] Instances { get; set; }
        bool? IsAllDay { get; set; }
        bool? IsCancelled { get; set; }
        bool? IsOrganizer { get; set; }
        bool? IsReminderOn { get; set; }
        Sample.API.Models.IMicrosoftGraphLocation Location { get; set; }
        Sample.API.Models.IMicrosoftGraphPhysicalAddress LocationAddress { get; set; }
        Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates LocationCoordinates { get; set; }
        string LocationDisplayName { get; set; }
        string LocationEmailAddress { get; set; }
        string LocationType { get; set; }
        string LocationUniqueId { get; set; }
        string LocationUniqueIdType { get; set; }
        string LocationUri { get; set; }
        Sample.API.Models.IMicrosoftGraphLocation[] Locations { get; set; }
        Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get; set; }
        string OnlineMeetingUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphRecipient Organizer { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress OrganizerEmailAddress { get; set; }
        string OriginalEndTimeZone { get; set; }
        System.DateTime? OriginalStart { get; set; }
        string OriginalStartTimeZone { get; set; }
        int? PatternDayOfMonth { get; set; }
        string[] PatternDaysOfWeek { get; set; }
        string PatternFirstDayOfWeek { get; set; }
        string PatternIndex { get; set; }
        int? PatternInterval { get; set; }
        int? PatternMonth { get; set; }
        string PatternType { get; set; }
        System.DateTime? RangeEndDate { get; set; }
        int? RangeNumberOfOccurrences { get; set; }
        string RangeRecurrenceTimeZone { get; set; }
        System.DateTime? RangeStartDate { get; set; }
        string RangeType { get; set; }
        Sample.API.Models.IMicrosoftGraphPatternedRecurrence Recurrence { get; set; }
        Sample.API.Models.IMicrosoftGraphRecurrencePattern RecurrencePattern { get; set; }
        Sample.API.Models.IMicrosoftGraphRecurrenceRange RecurrenceRange { get; set; }
        int? ReminderMinutesBeforeStart { get; set; }
        bool? ResponseRequested { get; set; }
        Sample.API.Models.IMicrosoftGraphResponseStatus ResponseStatus { get; set; }
        string ResponseStatusResponse { get; set; }
        System.DateTime? ResponseStatusTime { get; set; }
        string Sensitivity { get; set; }
        string SeriesMasterId { get; set; }
        string ShowAs { get; set; }
        Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone Start { get; set; }
        string StartDateTime { get; set; }
        string StartTimeZone { get; set; }
        string Subject { get; set; }
        string Type { get; set; }
        string WebLink { get; set; }
    }
}