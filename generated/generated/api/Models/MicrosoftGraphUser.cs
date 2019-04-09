namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphUser : Sample.API.Models.IMicrosoftGraphUser, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphUser" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphUserAllof1 _componentsSchemasMicrosoftGraphUserAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphUserAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphUser" /></summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject _microsoftGraphDirectoryObject = new Sample.API.Models.MicrosoftGraphDirectoryObject ();
        public string AboutMe
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AboutMe;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AboutMe = value;
            }
        }
        public bool? AccountEnabled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AccountEnabled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AccountEnabled = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUserActivity[] Activities
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Activities;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Activities = value;
            }
        }
        public string AgeGroup
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AgeGroup;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AgeGroup = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphAssignedLicense[] AssignedLicenses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AssignedLicenses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AssignedLicenses = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphAssignedPlan[] AssignedPlans
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AssignedPlans;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AssignedPlans = value;
            }
        }
        /// <summary>externalAudienceScope</summary>
        public string AutomaticRepliesSettingExternalAudience
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingExternalAudience;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingExternalAudience = value;
            }
        }
        public string AutomaticRepliesSettingExternalReplyMessage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingExternalReplyMessage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingExternalReplyMessage = value;
            }
        }
        public string AutomaticRepliesSettingInternalReplyMessage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingInternalReplyMessage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingInternalReplyMessage = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledEndDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingScheduledEndDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingScheduledEndDateTime = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledStartDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingScheduledStartDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingScheduledStartDateTime = value;
            }
        }
        /// <summary>automaticRepliesStatus</summary>
        public string AutomaticRepliesSettingStatus
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingStatus;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .AutomaticRepliesSettingStatus = value;
            }
        }
        public System.DateTime? Birthday
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Birthday;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Birthday = value;
            }
        }
        public string[] BusinessPhones
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .BusinessPhones;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .BusinessPhones = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphCalendar Calendar
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Calendar;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Calendar = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphCalendarGroup[] CalendarGroups
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .CalendarGroups;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .CalendarGroups = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphEvent[] CalendarView
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .CalendarView;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .CalendarView = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphCalendar[] Calendars
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Calendars;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Calendars = value;
            }
        }
        public string City
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .City;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .City = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .CompanyName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .CompanyName = value;
            }
        }
        public string ConsentProvidedForMinor
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ConsentProvidedForMinor;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ConsentProvidedForMinor = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphContactFolder[] ContactFolders
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ContactFolders;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ContactFolders = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphContact[] Contacts
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Contacts;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Contacts = value;
            }
        }
        public string Country
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Country;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Country = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] CreatedObjects
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .CreatedObjects;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .CreatedObjects = value;
            }
        }
        public System.DateTime? DeletedDateTime
        {
            get
            {
                return _microsoftGraphDirectoryObject .DeletedDateTime;
            }
            set
            {
                _microsoftGraphDirectoryObject .DeletedDateTime = value;
            }
        }
        public string Department
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Department;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Department = value;
            }
        }
        /// <summary>
        /// The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
        /// </summary>
        public int? DeviceEnrollmentLimit
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .DeviceEnrollmentLimit;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .DeviceEnrollmentLimit = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent[] DeviceManagementTroubleshootingEvents
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .DeviceManagementTroubleshootingEvents;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .DeviceManagementTroubleshootingEvents = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] DirectReports
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .DirectReports;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .DirectReports = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .DisplayName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDrive Drive
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Drive;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Drive = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDrive[] Drives
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Drives;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Drives = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphEvent[] Events
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Events;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Events = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphExtension[] Extensions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Extensions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Extensions = value;
            }
        }
        public string GivenName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .GivenName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .GivenName = value;
            }
        }
        public System.DateTime? HireDate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .HireDate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .HireDate = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphDirectoryObject .Id;
            }
            set
            {
                _microsoftGraphDirectoryObject .Id = value;
            }
        }
        public string[] ImAddresses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ImAddresses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ImAddresses = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphInferenceClassification InferenceClassification
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .InferenceClassification;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .InferenceClassification = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOfficeGraphInsights Insights
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Insights;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Insights = value;
            }
        }
        public string[] Interests
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Interests;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Interests = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .JobTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .JobTitle = value;
            }
        }
        public string LanguageDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .LanguageDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .LanguageDisplayName = value;
            }
        }
        public string LanguageLocale
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .LanguageLocale;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .LanguageLocale = value;
            }
        }
        public string LegalAgeGroupClassification
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .LegalAgeGroupClassification;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .LegalAgeGroupClassification = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphLicenseDetails[] LicenseDetails
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .LicenseDetails;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .LicenseDetails = value;
            }
        }
        public string Mail
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Mail;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Mail = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMailFolder[] MailFolders
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailFolders;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailFolders = value;
            }
        }
        public string MailNickname
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailNickname;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailNickname = value;
            }
        }
        /// <summary>mailboxSettings</summary>
        public Sample.API.Models.IMicrosoftGraphMailboxSettings MailboxSettings
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettings;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettings = value;
            }
        }
        public string MailboxSettingsArchiveFolder
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsArchiveFolder;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsArchiveFolder = value;
            }
        }
        /// <summary>automaticRepliesSetting</summary>
        public Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting MailboxSettingsAutomaticRepliesSetting
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsAutomaticRepliesSetting;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsAutomaticRepliesSetting = value;
            }
        }
        /// <summary>localeInfo</summary>
        public Sample.API.Models.IMicrosoftGraphLocaleInfo MailboxSettingsLanguage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsLanguage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsLanguage = value;
            }
        }
        public string MailboxSettingsTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsTimeZone = value;
            }
        }
        /// <summary>workingHours</summary>
        public Sample.API.Models.IMicrosoftGraphWorkingHours MailboxSettingsWorkingHours
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsWorkingHours;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MailboxSettingsWorkingHours = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphManagedAppRegistration[] ManagedAppRegistrations
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ManagedAppRegistrations;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ManagedAppRegistrations = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphManagedDevice[] ManagedDevices
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ManagedDevices;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ManagedDevices = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject Manager
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Manager;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Manager = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] MemberOf
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MemberOf;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MemberOf = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMessage[] Messages
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Messages;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Messages = value;
            }
        }
        public string MobilePhone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MobilePhone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MobilePhone = value;
            }
        }
        public string MySite
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .MySite;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .MySite = value;
            }
        }
        public string OfficeLocation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OfficeLocation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OfficeLocation = value;
            }
        }
        public string OnPremisesDomainName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesDomainName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesDomainName = value;
            }
        }
        /// <summary>onPremisesExtensionAttributes</summary>
        public Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes OnPremisesExtensionAttributes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributes = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute1
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute1;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute1 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute10
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute10;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute10 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute11
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute11;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute11 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute12
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute12;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute12 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute13
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute13;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute13 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute14
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute14;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute14 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute15
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute15;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute15 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute2
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute2;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute2 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute3
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute3;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute3 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute4
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute4;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute4 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute5
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute5;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute5 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute6
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute6;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute6 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute7
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute7;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute7 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute8
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute8;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute8 = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute9
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute9;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesExtensionAttributesExtensionAttribute9 = value;
            }
        }
        public string OnPremisesImmutableId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesImmutableId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesImmutableId = value;
            }
        }
        public System.DateTime? OnPremisesLastSyncDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesLastSyncDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesLastSyncDateTime = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError[] OnPremisesProvisioningErrors
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesProvisioningErrors;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesProvisioningErrors = value;
            }
        }
        public string OnPremisesSamAccountName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesSamAccountName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesSamAccountName = value;
            }
        }
        public string OnPremisesSecurityIdentifier
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesSecurityIdentifier;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesSecurityIdentifier = value;
            }
        }
        public bool? OnPremisesSyncEnabled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesSyncEnabled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesSyncEnabled = value;
            }
        }
        public string OnPremisesUserPrincipalName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesUserPrincipalName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OnPremisesUserPrincipalName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOnenote Onenote
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Onenote;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Onenote = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphOutlookUser Outlook
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Outlook;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Outlook = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] OwnedDevices
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OwnedDevices;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OwnedDevices = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] OwnedObjects
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .OwnedObjects;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .OwnedObjects = value;
            }
        }
        public string PasswordPolicies
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PasswordPolicies;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PasswordPolicies = value;
            }
        }
        /// <summary>passwordProfile</summary>
        public Sample.API.Models.IMicrosoftGraphPasswordProfile PasswordProfile
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PasswordProfile;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PasswordProfile = value;
            }
        }
        public bool? PasswordProfileForceChangePasswordNextSignIn
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PasswordProfileForceChangePasswordNextSignIn;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PasswordProfileForceChangePasswordNextSignIn = value;
            }
        }
        public string PasswordProfilePassword
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PasswordProfilePassword;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PasswordProfilePassword = value;
            }
        }
        public string[] PastProjects
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PastProjects;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PastProjects = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPerson[] People
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .People;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .People = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphProfilePhoto Photo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Photo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Photo = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphProfilePhoto[] Photos
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Photos;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Photos = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphPlannerUser Planner
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Planner;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Planner = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PostalCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PostalCode = value;
            }
        }
        public string PreferredLanguage
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PreferredLanguage;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PreferredLanguage = value;
            }
        }
        public string PreferredName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .PreferredName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .PreferredName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphProvisionedPlan[] ProvisionedPlans
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ProvisionedPlans;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ProvisionedPlans = value;
            }
        }
        public string[] ProxyAddresses
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ProxyAddresses;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ProxyAddresses = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] RegisteredDevices
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .RegisteredDevices;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .RegisteredDevices = value;
            }
        }
        public string[] Responsibilities
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Responsibilities;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Responsibilities = value;
            }
        }
        public string ScheduledEndDateTimeDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledEndDateTimeDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledEndDateTimeDateTime = value;
            }
        }
        public string ScheduledEndDateTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledEndDateTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledEndDateTimeZone = value;
            }
        }
        public string ScheduledStartDateTimeDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledStartDateTimeDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledStartDateTimeDateTime = value;
            }
        }
        public string ScheduledStartDateTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledStartDateTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .ScheduledStartDateTimeZone = value;
            }
        }
        public string[] Schools
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Schools;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Schools = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUserSettings Settings
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Settings;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Settings = value;
            }
        }
        public string[] Skills
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Skills;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Skills = value;
            }
        }
        public string State
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .State;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .State = value;
            }
        }
        public string StreetAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .StreetAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .StreetAddress = value;
            }
        }
        public string Surname
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .Surname;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .Surname = value;
            }
        }
        public string TimeZoneName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .TimeZoneName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .TimeZoneName = value;
            }
        }
        public string UsageLocation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .UsageLocation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .UsageLocation = value;
            }
        }
        public string UserPrincipalName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .UserPrincipalName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .UserPrincipalName = value;
            }
        }
        public string UserType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .UserType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .UserType = value;
            }
        }
        public string[] WorkingHoursDaysOfWeek
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursDaysOfWeek;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursDaysOfWeek = value;
            }
        }
        public string WorkingHoursEndTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursEndTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursEndTime = value;
            }
        }
        public string WorkingHoursStartTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursStartTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursStartTime = value;
            }
        }
        /// <summary>timeZoneBase</summary>
        public Sample.API.Models.IMicrosoftGraphTimeZoneBase WorkingHoursTimeZone
        {
            get
            {
                return _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursTimeZone;
            }
            set
            {
                _componentsSchemasMicrosoftGraphUserAllof1 .WorkingHoursTimeZone = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphUser" /> instance.</summary>
        public MicrosoftGraphUser()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphDirectoryObject ), _microsoftGraphDirectoryObject );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphDirectoryObject ), _microsoftGraphDirectoryObject );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphUserAllof1 ), _componentsSchemasMicrosoftGraphUserAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphUserAllof1 ), _componentsSchemasMicrosoftGraphUserAllof1 );
        }
    }
    public partial interface IMicrosoftGraphUser : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphDirectoryObject, Sample.API.Models.IComponentsSchemasMicrosoftGraphUserAllof1 {

    }
}