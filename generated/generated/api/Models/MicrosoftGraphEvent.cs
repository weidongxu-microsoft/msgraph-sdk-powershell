namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphEvent : Sample.API.Models.IMicrosoftGraphEvent, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphEvent" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphEventAllof1 _componentsSchemasMicrosoftGraphEventAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphEventAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphEvent" /></summary>
        private Sample.API.Models.IMicrosoftGraphOutlookItem _microsoftGraphOutlookItem = new Sample.API.Models.MicrosoftGraphOutlookItem ();
        public string AddressCity
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .AddressCity;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .AddressCity = value;
            }
        }
        public string AddressCountryOrRegion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .AddressCountryOrRegion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .AddressCountryOrRegion = value;
            }
        }
        public string AddressEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .AddressEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .AddressEmailAddress = value;
            }
        }
        public string AddressPostalCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .AddressPostalCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .AddressPostalCode = value;
            }
        }
        public string AddressState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .AddressState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .AddressState = value;
            }
        }
        public string AddressStreet
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .AddressStreet;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .AddressStreet = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphAttachment[] Attachments
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Attachments;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Attachments = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphAttendee[] Attendees
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Attendees;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Attendees = value;
            }
        }
        /// <summary>itemBody</summary>
        public Sample.API.Models.IMicrosoftGraphItemBody Body
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Body;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Body = value;
            }
        }
        public string BodyContent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .BodyContent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .BodyContent = value;
            }
        }
        /// <summary>bodyType</summary>
        public string BodyContentType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .BodyContentType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .BodyContentType = value;
            }
        }
        public string BodyPreview
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .BodyPreview;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .BodyPreview = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphCalendar Calendar
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Calendar;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Calendar = value;
            }
        }
        public string[] Categories
        {
            get
            {
                return _microsoftGraphOutlookItem .Categories;
            }
            set
            {
                _microsoftGraphOutlookItem .Categories = value;
            }
        }
        public string ChangeKey
        {
            get
            {
                return _microsoftGraphOutlookItem .ChangeKey;
            }
            set
            {
                _microsoftGraphOutlookItem .ChangeKey = value;
            }
        }
        public double? CoordinatesAccuracy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesAccuracy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesAccuracy = value;
            }
        }
        public double? CoordinatesAltitude
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesAltitude;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesAltitude = value;
            }
        }
        public double? CoordinatesAltitudeAccuracy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesAltitudeAccuracy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesAltitudeAccuracy = value;
            }
        }
        public double? CoordinatesLatitude
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesLatitude;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesLatitude = value;
            }
        }
        public double? CoordinatesLongitude
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesLongitude;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .CoordinatesLongitude = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOutlookItem .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOutlookItem .CreatedDateTime = value;
            }
        }
        public string EmailAddressName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .EmailAddressName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .EmailAddressName = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone End
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .End;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .End = value;
            }
        }
        public string EndDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .EndDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .EndDateTime = value;
            }
        }
        public string EndTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .EndTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .EndTimeZone = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Extensions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Extensions = value;
            }
        }
        public bool? HasAttachments
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .HasAttachments;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .HasAttachments = value;
            }
        }
        public string ICalUId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ICalUId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ICalUId = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOutlookItem .Id;
            }
            set
            {
                _microsoftGraphOutlookItem .Id = value;
            }
        }
        /// <summary>importance</summary>
        public string Importance
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Importance;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Importance = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphEvent[] Instances
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Instances;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Instances = value;
            }
        }
        public bool? IsAllDay
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .IsAllDay;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .IsAllDay = value;
            }
        }
        public bool? IsCancelled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .IsCancelled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .IsCancelled = value;
            }
        }
        public bool? IsOrganizer
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .IsOrganizer;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .IsOrganizer = value;
            }
        }
        public bool? IsReminderOn
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .IsReminderOn;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .IsReminderOn = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _microsoftGraphOutlookItem .LastModifiedDateTime;
            }
            set
            {
                _microsoftGraphOutlookItem .LastModifiedDateTime = value;
            }
        }
        /// <summary>location</summary>
        public Sample.API.Models.IMicrosoftGraphLocation Location
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Location;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Location = value;
            }
        }
        /// <summary>physicalAddress</summary>
        public Sample.API.Models.IMicrosoftGraphPhysicalAddress LocationAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationAddress = value;
            }
        }
        /// <summary>outlookGeoCoordinates</summary>
        public Sample.API.Models.IMicrosoftGraphOutlookGeoCoordinates LocationCoordinates
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationCoordinates;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationCoordinates = value;
            }
        }
        public string LocationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationDisplayName = value;
            }
        }
        public string LocationEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationEmailAddress = value;
            }
        }
        /// <summary>locationType</summary>
        public string LocationType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationType = value;
            }
        }
        public string LocationUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationUniqueId = value;
            }
        }
        /// <summary>locationUniqueIdType</summary>
        public string LocationUniqueIdType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationUniqueIdType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationUniqueIdType = value;
            }
        }
        public string LocationUri
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .LocationUri;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .LocationUri = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphLocation[] Locations
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Locations;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Locations = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .MultiValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .MultiValueExtendedProperties = value;
            }
        }
        public string OnlineMeetingUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .OnlineMeetingUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .OnlineMeetingUrl = value;
            }
        }
        /// <summary>recipient</summary>
        public Sample.API.Models.IMicrosoftGraphRecipient Organizer
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Organizer;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Organizer = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress OrganizerEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .OrganizerEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .OrganizerEmailAddress = value;
            }
        }
        public string OriginalEndTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .OriginalEndTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .OriginalEndTimeZone = value;
            }
        }
        public System.DateTime? OriginalStart
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .OriginalStart;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .OriginalStart = value;
            }
        }
        public string OriginalStartTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .OriginalStartTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .OriginalStartTimeZone = value;
            }
        }
        public int? PatternDayOfMonth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternDayOfMonth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternDayOfMonth = value;
            }
        }
        public string[] PatternDaysOfWeek
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternDaysOfWeek;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternDaysOfWeek = value;
            }
        }
        /// <summary>dayOfWeek</summary>
        public string PatternFirstDayOfWeek
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternFirstDayOfWeek;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternFirstDayOfWeek = value;
            }
        }
        /// <summary>weekIndex</summary>
        public string PatternIndex
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternIndex;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternIndex = value;
            }
        }
        public int? PatternInterval
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternInterval;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternInterval = value;
            }
        }
        public int? PatternMonth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternMonth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternMonth = value;
            }
        }
        /// <summary>recurrencePatternType</summary>
        public string PatternType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .PatternType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .PatternType = value;
            }
        }
        public System.DateTime? RangeEndDate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RangeEndDate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RangeEndDate = value;
            }
        }
        public int? RangeNumberOfOccurrences
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RangeNumberOfOccurrences;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RangeNumberOfOccurrences = value;
            }
        }
        public string RangeRecurrenceTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RangeRecurrenceTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RangeRecurrenceTimeZone = value;
            }
        }
        public System.DateTime? RangeStartDate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RangeStartDate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RangeStartDate = value;
            }
        }
        /// <summary>recurrenceRangeType</summary>
        public string RangeType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RangeType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RangeType = value;
            }
        }
        /// <summary>patternedRecurrence</summary>
        public Sample.API.Models.IMicrosoftGraphPatternedRecurrence Recurrence
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Recurrence;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Recurrence = value;
            }
        }
        /// <summary>recurrencePattern</summary>
        public Sample.API.Models.IMicrosoftGraphRecurrencePattern RecurrencePattern
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RecurrencePattern;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RecurrencePattern = value;
            }
        }
        /// <summary>recurrenceRange</summary>
        public Sample.API.Models.IMicrosoftGraphRecurrenceRange RecurrenceRange
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .RecurrenceRange;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .RecurrenceRange = value;
            }
        }
        public int? ReminderMinutesBeforeStart
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ReminderMinutesBeforeStart;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ReminderMinutesBeforeStart = value;
            }
        }
        public bool? ResponseRequested
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ResponseRequested;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ResponseRequested = value;
            }
        }
        /// <summary>responseStatus</summary>
        public Sample.API.Models.IMicrosoftGraphResponseStatus ResponseStatus
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ResponseStatus;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ResponseStatus = value;
            }
        }
        /// <summary>responseType</summary>
        public string ResponseStatusResponse
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ResponseStatusResponse;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ResponseStatusResponse = value;
            }
        }
        public System.DateTime? ResponseStatusTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ResponseStatusTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ResponseStatusTime = value;
            }
        }
        /// <summary>sensitivity</summary>
        public string Sensitivity
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Sensitivity;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Sensitivity = value;
            }
        }
        public string SeriesMasterId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .SeriesMasterId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .SeriesMasterId = value;
            }
        }
        /// <summary>freeBusyStatus</summary>
        public string ShowAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .ShowAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .ShowAs = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .SingleValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .SingleValueExtendedProperties = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone Start
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Start;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Start = value;
            }
        }
        public string StartDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .StartDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .StartDateTime = value;
            }
        }
        public string StartTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .StartTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .StartTimeZone = value;
            }
        }
        public string Subject
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Subject;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Subject = value;
            }
        }
        /// <summary>eventType</summary>
        public string Type
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .Type;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .Type = value;
            }
        }
        public string WebLink
        {
            get
            {
                return _componentsSchemasMicrosoftGraphEventAllof1 .WebLink;
            }
            set
            {
                _componentsSchemasMicrosoftGraphEventAllof1 .WebLink = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphEvent" /> instance.</summary>
        public MicrosoftGraphEvent()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphOutlookItem ), _microsoftGraphOutlookItem );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOutlookItem ), _microsoftGraphOutlookItem );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphEventAllof1 ), _componentsSchemasMicrosoftGraphEventAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphEventAllof1 ), _componentsSchemasMicrosoftGraphEventAllof1 );
        }
    }
    public partial interface IMicrosoftGraphEvent : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOutlookItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphEventAllof1 {

    }
}