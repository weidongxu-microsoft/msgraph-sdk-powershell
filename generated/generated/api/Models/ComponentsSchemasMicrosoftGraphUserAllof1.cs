namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>user</summary>
    public partial class ComponentsSchemasMicrosoftGraphUserAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphUserAllof1
    {
        /// <summary>Backing field for <see cref="AboutMe" /> property.</summary>
        private string _aboutMe;

        public string AboutMe
        {
            get
            {
                return this._aboutMe;
            }
            set
            {
                this._aboutMe = value;
            }
        }
        /// <summary>Backing field for <see cref="AccountEnabled" /> property.</summary>
        private bool? _accountEnabled;

        public bool? AccountEnabled
        {
            get
            {
                return this._accountEnabled;
            }
            set
            {
                this._accountEnabled = value;
            }
        }
        /// <summary>Backing field for <see cref="Activities" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUserActivity[] _activities;

        public Sample.API.Models.IMicrosoftGraphUserActivity[] Activities
        {
            get
            {
                return this._activities;
            }
            set
            {
                this._activities = value;
            }
        }
        /// <summary>Backing field for <see cref="AgeGroup" /> property.</summary>
        private string _ageGroup;

        public string AgeGroup
        {
            get
            {
                return this._ageGroup;
            }
            set
            {
                this._ageGroup = value;
            }
        }
        /// <summary>Backing field for <see cref="AssignedLicenses" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAssignedLicense[] _assignedLicenses;

        public Sample.API.Models.IMicrosoftGraphAssignedLicense[] AssignedLicenses
        {
            get
            {
                return this._assignedLicenses;
            }
            set
            {
                this._assignedLicenses = value;
            }
        }
        /// <summary>Backing field for <see cref="AssignedPlans" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAssignedPlan[] _assignedPlans;

        public Sample.API.Models.IMicrosoftGraphAssignedPlan[] AssignedPlans
        {
            get
            {
                return this._assignedPlans;
            }
            set
            {
                this._assignedPlans = value;
            }
        }
        /// <summary>externalAudienceScope</summary>
        public string AutomaticRepliesSettingExternalAudience
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingExternalAudience/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingExternalAudience/*3*/ = value;
            }
        }
        public string AutomaticRepliesSettingExternalReplyMessage
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingExternalReplyMessage/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingExternalReplyMessage/*3*/ = value;
            }
        }
        public string AutomaticRepliesSettingInternalReplyMessage
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingInternalReplyMessage/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingInternalReplyMessage/*3*/ = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledEndDateTime
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingScheduledEndDateTime/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingScheduledEndDateTime/*3*/ = value;
            }
        }
        /// <summary>dateTimeTimeZone</summary>
        public Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledStartDateTime
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingScheduledStartDateTime/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingScheduledStartDateTime/*3*/ = value;
            }
        }
        /// <summary>automaticRepliesStatus</summary>
        public string AutomaticRepliesSettingStatus
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingStatus/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSettingStatus/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Birthday" /> property.</summary>
        private System.DateTime? _birthday;

        public System.DateTime? Birthday
        {
            get
            {
                return this._birthday;
            }
            set
            {
                this._birthday = value;
            }
        }
        /// <summary>Backing field for <see cref="BusinessPhones" /> property.</summary>
        private string[] _businessPhones;

        public string[] BusinessPhones
        {
            get
            {
                return this._businessPhones;
            }
            set
            {
                this._businessPhones = value;
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
        /// <summary>Backing field for <see cref="CalendarGroups" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphCalendarGroup[] _calendarGroups;

        public Sample.API.Models.IMicrosoftGraphCalendarGroup[] CalendarGroups
        {
            get
            {
                return this._calendarGroups;
            }
            set
            {
                this._calendarGroups = value;
            }
        }
        /// <summary>Backing field for <see cref="CalendarView" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEvent[] _calendarView;

        public Sample.API.Models.IMicrosoftGraphEvent[] CalendarView
        {
            get
            {
                return this._calendarView;
            }
            set
            {
                this._calendarView = value;
            }
        }
        /// <summary>Backing field for <see cref="Calendars" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphCalendar[] _calendars;

        public Sample.API.Models.IMicrosoftGraphCalendar[] Calendars
        {
            get
            {
                return this._calendars;
            }
            set
            {
                this._calendars = value;
            }
        }
        /// <summary>Backing field for <see cref="City" /> property.</summary>
        private string _city;

        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        public string CompanyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
            }
        }
        /// <summary>Backing field for <see cref="ConsentProvidedForMinor" /> property.</summary>
        private string _consentProvidedForMinor;

        public string ConsentProvidedForMinor
        {
            get
            {
                return this._consentProvidedForMinor;
            }
            set
            {
                this._consentProvidedForMinor = value;
            }
        }
        /// <summary>Backing field for <see cref="ContactFolders" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContactFolder[] _contactFolders;

        public Sample.API.Models.IMicrosoftGraphContactFolder[] ContactFolders
        {
            get
            {
                return this._contactFolders;
            }
            set
            {
                this._contactFolders = value;
            }
        }
        /// <summary>Backing field for <see cref="Contacts" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContact[] _contacts;

        public Sample.API.Models.IMicrosoftGraphContact[] Contacts
        {
            get
            {
                return this._contacts;
            }
            set
            {
                this._contacts = value;
            }
        }
        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        public string Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedObjects" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject[] _createdObjects;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] CreatedObjects
        {
            get
            {
                return this._createdObjects;
            }
            set
            {
                this._createdObjects = value;
            }
        }
        /// <summary>Backing field for <see cref="Department" /> property.</summary>
        private string _department;

        public string Department
        {
            get
            {
                return this._department;
            }
            set
            {
                this._department = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceEnrollmentLimit" /> property.</summary>
        private int? _deviceEnrollmentLimit;

        /// <summary>
        /// The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
        /// </summary>
        public int? DeviceEnrollmentLimit
        {
            get
            {
                return this._deviceEnrollmentLimit;
            }
            set
            {
                this._deviceEnrollmentLimit = value;
            }
        }
        /// <summary>
        /// Backing field for <see cref="DeviceManagementTroubleshootingEvents" /> property.
        /// </summary>
        private Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent[] _deviceManagementTroubleshootingEvents;

        public Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent[] DeviceManagementTroubleshootingEvents
        {
            get
            {
                return this._deviceManagementTroubleshootingEvents;
            }
            set
            {
                this._deviceManagementTroubleshootingEvents = value;
            }
        }
        /// <summary>Backing field for <see cref="DirectReports" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject[] _directReports;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] DirectReports
        {
            get
            {
                return this._directReports;
            }
            set
            {
                this._directReports = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Drive" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDrive _drive;

        public Sample.API.Models.IMicrosoftGraphDrive Drive
        {
            get
            {
                return this._drive;
            }
            set
            {
                this._drive = value;
            }
        }
        /// <summary>Backing field for <see cref="Drives" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDrive[] _drives;

        public Sample.API.Models.IMicrosoftGraphDrive[] Drives
        {
            get
            {
                return this._drives;
            }
            set
            {
                this._drives = value;
            }
        }
        /// <summary>Backing field for <see cref="Events" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEvent[] _events;

        public Sample.API.Models.IMicrosoftGraphEvent[] Events
        {
            get
            {
                return this._events;
            }
            set
            {
                this._events = value;
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
        /// <summary>Backing field for <see cref="GivenName" /> property.</summary>
        private string _givenName;

        public string GivenName
        {
            get
            {
                return this._givenName;
            }
            set
            {
                this._givenName = value;
            }
        }
        /// <summary>Backing field for <see cref="HireDate" /> property.</summary>
        private System.DateTime? _hireDate;

        public System.DateTime? HireDate
        {
            get
            {
                return this._hireDate;
            }
            set
            {
                this._hireDate = value;
            }
        }
        /// <summary>Backing field for <see cref="ImAddresses" /> property.</summary>
        private string[] _imAddresses;

        public string[] ImAddresses
        {
            get
            {
                return this._imAddresses;
            }
            set
            {
                this._imAddresses = value;
            }
        }
        /// <summary>Backing field for <see cref="InferenceClassification" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphInferenceClassification _inferenceClassification;

        public Sample.API.Models.IMicrosoftGraphInferenceClassification InferenceClassification
        {
            get
            {
                return this._inferenceClassification;
            }
            set
            {
                this._inferenceClassification = value;
            }
        }
        /// <summary>Backing field for <see cref="Insights" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOfficeGraphInsights _insights;

        public Sample.API.Models.IMicrosoftGraphOfficeGraphInsights Insights
        {
            get
            {
                return this._insights;
            }
            set
            {
                this._insights = value;
            }
        }
        /// <summary>Backing field for <see cref="Interests" /> property.</summary>
        private string[] _interests;

        public string[] Interests
        {
            get
            {
                return this._interests;
            }
            set
            {
                this._interests = value;
            }
        }
        /// <summary>Backing field for <see cref="JobTitle" /> property.</summary>
        private string _jobTitle;

        public string JobTitle
        {
            get
            {
                return this._jobTitle;
            }
            set
            {
                this._jobTitle = value;
            }
        }
        public string LanguageDisplayName
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.LanguageDisplayName/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.LanguageDisplayName/*3*/ = value;
            }
        }
        public string LanguageLocale
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.LanguageLocale/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.LanguageLocale/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="LegalAgeGroupClassification" /> property.</summary>
        private string _legalAgeGroupClassification;

        public string LegalAgeGroupClassification
        {
            get
            {
                return this._legalAgeGroupClassification;
            }
            set
            {
                this._legalAgeGroupClassification = value;
            }
        }
        /// <summary>Backing field for <see cref="LicenseDetails" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphLicenseDetails[] _licenseDetails;

        public Sample.API.Models.IMicrosoftGraphLicenseDetails[] LicenseDetails
        {
            get
            {
                return this._licenseDetails;
            }
            set
            {
                this._licenseDetails = value;
            }
        }
        /// <summary>Backing field for <see cref="Mail" /> property.</summary>
        private string _mail;

        public string Mail
        {
            get
            {
                return this._mail;
            }
            set
            {
                this._mail = value;
            }
        }
        /// <summary>Backing field for <see cref="MailFolders" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMailFolder[] _mailFolders;

        public Sample.API.Models.IMicrosoftGraphMailFolder[] MailFolders
        {
            get
            {
                return this._mailFolders;
            }
            set
            {
                this._mailFolders = value;
            }
        }
        /// <summary>Backing field for <see cref="MailNickname" /> property.</summary>
        private string _mailNickname;

        public string MailNickname
        {
            get
            {
                return this._mailNickname;
            }
            set
            {
                this._mailNickname = value;
            }
        }
        /// <summary>Backing field for <see cref="MailboxSettings" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMailboxSettings _mailboxSettings;

        /// <summary>mailboxSettings</summary>
        public Sample.API.Models.IMicrosoftGraphMailboxSettings MailboxSettings
        {
            get
            {
                return this._mailboxSettings;
            }
            set
            {
                this._mailboxSettings = value;
            }
        }
        public string MailboxSettingsArchiveFolder
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.ArchiveFolder/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.ArchiveFolder/*3*/ = value;
            }
        }
        /// <summary>automaticRepliesSetting</summary>
        public Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting MailboxSettingsAutomaticRepliesSetting
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.AutomaticRepliesSetting/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.AutomaticRepliesSetting/*3*/ = value;
            }
        }
        /// <summary>localeInfo</summary>
        public Sample.API.Models.IMicrosoftGraphLocaleInfo MailboxSettingsLanguage
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.Language/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.Language/*3*/ = value;
            }
        }
        public string MailboxSettingsTimeZone
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.TimeZone/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.TimeZone/*3*/ = value;
            }
        }
        /// <summary>workingHours</summary>
        public Sample.API.Models.IMicrosoftGraphWorkingHours MailboxSettingsWorkingHours
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.WorkingHours/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.WorkingHours/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ManagedAppRegistrations" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphManagedAppRegistration[] _managedAppRegistrations;

        public Sample.API.Models.IMicrosoftGraphManagedAppRegistration[] ManagedAppRegistrations
        {
            get
            {
                return this._managedAppRegistrations;
            }
            set
            {
                this._managedAppRegistrations = value;
            }
        }
        /// <summary>Backing field for <see cref="ManagedDevices" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphManagedDevice[] _managedDevices;

        public Sample.API.Models.IMicrosoftGraphManagedDevice[] ManagedDevices
        {
            get
            {
                return this._managedDevices;
            }
            set
            {
                this._managedDevices = value;
            }
        }
        /// <summary>Backing field for <see cref="Manager" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject _manager;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject Manager
        {
            get
            {
                return this._manager;
            }
            set
            {
                this._manager = value;
            }
        }
        /// <summary>Backing field for <see cref="MemberOf" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject[] _memberOf;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] MemberOf
        {
            get
            {
                return this._memberOf;
            }
            set
            {
                this._memberOf = value;
            }
        }
        /// <summary>Backing field for <see cref="Messages" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMessage[] _messages;

        public Sample.API.Models.IMicrosoftGraphMessage[] Messages
        {
            get
            {
                return this._messages;
            }
            set
            {
                this._messages = value;
            }
        }
        /// <summary>Backing field for <see cref="MobilePhone" /> property.</summary>
        private string _mobilePhone;

        public string MobilePhone
        {
            get
            {
                return this._mobilePhone;
            }
            set
            {
                this._mobilePhone = value;
            }
        }
        /// <summary>Backing field for <see cref="MySite" /> property.</summary>
        private string _mySite;

        public string MySite
        {
            get
            {
                return this._mySite;
            }
            set
            {
                this._mySite = value;
            }
        }
        /// <summary>Backing field for <see cref="OfficeLocation" /> property.</summary>
        private string _officeLocation;

        public string OfficeLocation
        {
            get
            {
                return this._officeLocation;
            }
            set
            {
                this._officeLocation = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesDomainName" /> property.</summary>
        private string _onPremisesDomainName;

        public string OnPremisesDomainName
        {
            get
            {
                return this._onPremisesDomainName;
            }
            set
            {
                this._onPremisesDomainName = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesExtensionAttributes" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes _onPremisesExtensionAttributes;

        /// <summary>onPremisesExtensionAttributes</summary>
        public Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes OnPremisesExtensionAttributes
        {
            get
            {
                return this._onPremisesExtensionAttributes;
            }
            set
            {
                this._onPremisesExtensionAttributes = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute1
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute1/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute1/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute10
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute10/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute10/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute11
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute11/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute11/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute12
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute12/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute12/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute13
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute13/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute13/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute14
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute14/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute14/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute15
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute15/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute15/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute2
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute2/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute2/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute3
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute3/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute3/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute4
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute4/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute4/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute5
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute5/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute5/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute6
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute6/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute6/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute7
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute7/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute7/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute8
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute8/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute8/*3*/ = value;
            }
        }
        public string OnPremisesExtensionAttributesExtensionAttribute9
        {
            get
            {
                return /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute9/*3*/;
            }
            set
            {
                /*1*/OnPremisesExtensionAttributes/*4*/.ExtensionAttribute9/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesImmutableId" /> property.</summary>
        private string _onPremisesImmutableId;

        public string OnPremisesImmutableId
        {
            get
            {
                return this._onPremisesImmutableId;
            }
            set
            {
                this._onPremisesImmutableId = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesLastSyncDateTime" /> property.</summary>
        private System.DateTime? _onPremisesLastSyncDateTime;

        public System.DateTime? OnPremisesLastSyncDateTime
        {
            get
            {
                return this._onPremisesLastSyncDateTime;
            }
            set
            {
                this._onPremisesLastSyncDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesProvisioningErrors" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError[] _onPremisesProvisioningErrors;

        public Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError[] OnPremisesProvisioningErrors
        {
            get
            {
                return this._onPremisesProvisioningErrors;
            }
            set
            {
                this._onPremisesProvisioningErrors = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesSamAccountName" /> property.</summary>
        private string _onPremisesSamAccountName;

        public string OnPremisesSamAccountName
        {
            get
            {
                return this._onPremisesSamAccountName;
            }
            set
            {
                this._onPremisesSamAccountName = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesSecurityIdentifier" /> property.</summary>
        private string _onPremisesSecurityIdentifier;

        public string OnPremisesSecurityIdentifier
        {
            get
            {
                return this._onPremisesSecurityIdentifier;
            }
            set
            {
                this._onPremisesSecurityIdentifier = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesSyncEnabled" /> property.</summary>
        private bool? _onPremisesSyncEnabled;

        public bool? OnPremisesSyncEnabled
        {
            get
            {
                return this._onPremisesSyncEnabled;
            }
            set
            {
                this._onPremisesSyncEnabled = value;
            }
        }
        /// <summary>Backing field for <see cref="OnPremisesUserPrincipalName" /> property.</summary>
        private string _onPremisesUserPrincipalName;

        public string OnPremisesUserPrincipalName
        {
            get
            {
                return this._onPremisesUserPrincipalName;
            }
            set
            {
                this._onPremisesUserPrincipalName = value;
            }
        }
        /// <summary>Backing field for <see cref="Onenote" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenote _onenote;

        public Sample.API.Models.IMicrosoftGraphOnenote Onenote
        {
            get
            {
                return this._onenote;
            }
            set
            {
                this._onenote = value;
            }
        }
        /// <summary>Backing field for <see cref="Outlook" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOutlookUser _outlook;

        public Sample.API.Models.IMicrosoftGraphOutlookUser Outlook
        {
            get
            {
                return this._outlook;
            }
            set
            {
                this._outlook = value;
            }
        }
        /// <summary>Backing field for <see cref="OwnedDevices" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject[] _ownedDevices;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] OwnedDevices
        {
            get
            {
                return this._ownedDevices;
            }
            set
            {
                this._ownedDevices = value;
            }
        }
        /// <summary>Backing field for <see cref="OwnedObjects" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject[] _ownedObjects;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] OwnedObjects
        {
            get
            {
                return this._ownedObjects;
            }
            set
            {
                this._ownedObjects = value;
            }
        }
        /// <summary>Backing field for <see cref="PasswordPolicies" /> property.</summary>
        private string _passwordPolicies;

        public string PasswordPolicies
        {
            get
            {
                return this._passwordPolicies;
            }
            set
            {
                this._passwordPolicies = value;
            }
        }
        /// <summary>Backing field for <see cref="PasswordProfile" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPasswordProfile _passwordProfile;

        /// <summary>passwordProfile</summary>
        public Sample.API.Models.IMicrosoftGraphPasswordProfile PasswordProfile
        {
            get
            {
                return this._passwordProfile;
            }
            set
            {
                this._passwordProfile = value;
            }
        }
        public bool? PasswordProfileForceChangePasswordNextSignIn
        {
            get
            {
                return /*1*/PasswordProfile/*4*/.ForceChangePasswordNextSignIn/*3*/;
            }
            set
            {
                /*1*/PasswordProfile/*4*/.ForceChangePasswordNextSignIn/*3*/ = value;
            }
        }
        public string PasswordProfilePassword
        {
            get
            {
                return /*1*/PasswordProfile/*4*/.Password/*3*/;
            }
            set
            {
                /*1*/PasswordProfile/*4*/.Password/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="PastProjects" /> property.</summary>
        private string[] _pastProjects;

        public string[] PastProjects
        {
            get
            {
                return this._pastProjects;
            }
            set
            {
                this._pastProjects = value;
            }
        }
        /// <summary>Backing field for <see cref="People" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPerson[] _people;

        public Sample.API.Models.IMicrosoftGraphPerson[] People
        {
            get
            {
                return this._people;
            }
            set
            {
                this._people = value;
            }
        }
        /// <summary>Backing field for <see cref="Photo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphProfilePhoto _photo;

        public Sample.API.Models.IMicrosoftGraphProfilePhoto Photo
        {
            get
            {
                return this._photo;
            }
            set
            {
                this._photo = value;
            }
        }
        /// <summary>Backing field for <see cref="Photos" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphProfilePhoto[] _photos;

        public Sample.API.Models.IMicrosoftGraphProfilePhoto[] Photos
        {
            get
            {
                return this._photos;
            }
            set
            {
                this._photos = value;
            }
        }
        /// <summary>Backing field for <see cref="Planner" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPlannerUser _planner;

        public Sample.API.Models.IMicrosoftGraphPlannerUser Planner
        {
            get
            {
                return this._planner;
            }
            set
            {
                this._planner = value;
            }
        }
        /// <summary>Backing field for <see cref="PostalCode" /> property.</summary>
        private string _postalCode;

        public string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
            }
        }
        /// <summary>Backing field for <see cref="PreferredLanguage" /> property.</summary>
        private string _preferredLanguage;

        public string PreferredLanguage
        {
            get
            {
                return this._preferredLanguage;
            }
            set
            {
                this._preferredLanguage = value;
            }
        }
        /// <summary>Backing field for <see cref="PreferredName" /> property.</summary>
        private string _preferredName;

        public string PreferredName
        {
            get
            {
                return this._preferredName;
            }
            set
            {
                this._preferredName = value;
            }
        }
        /// <summary>Backing field for <see cref="ProvisionedPlans" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphProvisionedPlan[] _provisionedPlans;

        public Sample.API.Models.IMicrosoftGraphProvisionedPlan[] ProvisionedPlans
        {
            get
            {
                return this._provisionedPlans;
            }
            set
            {
                this._provisionedPlans = value;
            }
        }
        /// <summary>Backing field for <see cref="ProxyAddresses" /> property.</summary>
        private string[] _proxyAddresses;

        public string[] ProxyAddresses
        {
            get
            {
                return this._proxyAddresses;
            }
            set
            {
                this._proxyAddresses = value;
            }
        }
        /// <summary>Backing field for <see cref="RegisteredDevices" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDirectoryObject[] _registeredDevices;

        public Sample.API.Models.IMicrosoftGraphDirectoryObject[] RegisteredDevices
        {
            get
            {
                return this._registeredDevices;
            }
            set
            {
                this._registeredDevices = value;
            }
        }
        /// <summary>Backing field for <see cref="Responsibilities" /> property.</summary>
        private string[] _responsibilities;

        public string[] Responsibilities
        {
            get
            {
                return this._responsibilities;
            }
            set
            {
                this._responsibilities = value;
            }
        }
        public string ScheduledEndDateTimeDateTime
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.ScheduledEndDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.ScheduledEndDateTimeDateTime/*3*/ = value;
            }
        }
        public string ScheduledEndDateTimeZone
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.ScheduledEndDateTimeZone/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.ScheduledEndDateTimeZone/*3*/ = value;
            }
        }
        public string ScheduledStartDateTimeDateTime
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.ScheduledStartDateTimeDateTime/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.ScheduledStartDateTimeDateTime/*3*/ = value;
            }
        }
        public string ScheduledStartDateTimeZone
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.ScheduledStartDateTimeZone/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.ScheduledStartDateTimeZone/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Schools" /> property.</summary>
        private string[] _schools;

        public string[] Schools
        {
            get
            {
                return this._schools;
            }
            set
            {
                this._schools = value;
            }
        }
        /// <summary>Backing field for <see cref="Settings" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUserSettings _settings;

        public Sample.API.Models.IMicrosoftGraphUserSettings Settings
        {
            get
            {
                return this._settings;
            }
            set
            {
                this._settings = value;
            }
        }
        /// <summary>Backing field for <see cref="Skills" /> property.</summary>
        private string[] _skills;

        public string[] Skills
        {
            get
            {
                return this._skills;
            }
            set
            {
                this._skills = value;
            }
        }
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Backing field for <see cref="StreetAddress" /> property.</summary>
        private string _streetAddress;

        public string StreetAddress
        {
            get
            {
                return this._streetAddress;
            }
            set
            {
                this._streetAddress = value;
            }
        }
        /// <summary>Backing field for <see cref="Surname" /> property.</summary>
        private string _surname;

        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
            }
        }
        public string TimeZoneName
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.TimeZoneName/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.TimeZoneName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="UsageLocation" /> property.</summary>
        private string _usageLocation;

        public string UsageLocation
        {
            get
            {
                return this._usageLocation;
            }
            set
            {
                this._usageLocation = value;
            }
        }
        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        public string UserPrincipalName
        {
            get
            {
                return this._userPrincipalName;
            }
            set
            {
                this._userPrincipalName = value;
            }
        }
        /// <summary>Backing field for <see cref="UserType" /> property.</summary>
        private string _userType;

        public string UserType
        {
            get
            {
                return this._userType;
            }
            set
            {
                this._userType = value;
            }
        }
        public string[] WorkingHoursDaysOfWeek
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.WorkingHoursDaysOfWeek/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.WorkingHoursDaysOfWeek/*3*/ = value;
            }
        }
        public string WorkingHoursEndTime
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.WorkingHoursEndTime/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.WorkingHoursEndTime/*3*/ = value;
            }
        }
        public string WorkingHoursStartTime
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.WorkingHoursStartTime/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.WorkingHoursStartTime/*3*/ = value;
            }
        }
        /// <summary>timeZoneBase</summary>
        public Sample.API.Models.IMicrosoftGraphTimeZoneBase WorkingHoursTimeZone
        {
            get
            {
                return /*1*/MailboxSettings/*4*/.WorkingHoursTimeZone/*3*/;
            }
            set
            {
                /*1*/MailboxSettings/*4*/.WorkingHoursTimeZone/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphUserAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphUserAllof1()
        {
        }
    }
    /// user
    public partial interface IComponentsSchemasMicrosoftGraphUserAllof1 : Sample.API.Runtime.IJsonSerializable {
        string AboutMe { get; set; }
        bool? AccountEnabled { get; set; }
        Sample.API.Models.IMicrosoftGraphUserActivity[] Activities { get; set; }
        string AgeGroup { get; set; }
        Sample.API.Models.IMicrosoftGraphAssignedLicense[] AssignedLicenses { get; set; }
        Sample.API.Models.IMicrosoftGraphAssignedPlan[] AssignedPlans { get; set; }
        string AutomaticRepliesSettingExternalAudience { get; set; }
        string AutomaticRepliesSettingExternalReplyMessage { get; set; }
        string AutomaticRepliesSettingInternalReplyMessage { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledEndDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphDateTimeZone AutomaticRepliesSettingScheduledStartDateTime { get; set; }
        string AutomaticRepliesSettingStatus { get; set; }
        System.DateTime? Birthday { get; set; }
        string[] BusinessPhones { get; set; }
        Sample.API.Models.IMicrosoftGraphCalendar Calendar { get; set; }
        Sample.API.Models.IMicrosoftGraphCalendarGroup[] CalendarGroups { get; set; }
        Sample.API.Models.IMicrosoftGraphEvent[] CalendarView { get; set; }
        Sample.API.Models.IMicrosoftGraphCalendar[] Calendars { get; set; }
        string City { get; set; }
        string CompanyName { get; set; }
        string ConsentProvidedForMinor { get; set; }
        Sample.API.Models.IMicrosoftGraphContactFolder[] ContactFolders { get; set; }
        Sample.API.Models.IMicrosoftGraphContact[] Contacts { get; set; }
        string Country { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject[] CreatedObjects { get; set; }
        string Department { get; set; }
        int? DeviceEnrollmentLimit { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent[] DeviceManagementTroubleshootingEvents { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject[] DirectReports { get; set; }
        string DisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphDrive Drive { get; set; }
        Sample.API.Models.IMicrosoftGraphDrive[] Drives { get; set; }
        Sample.API.Models.IMicrosoftGraphEvent[] Events { get; set; }
        Sample.API.Models.IMicrosoftGraphExtension[] Extensions { get; set; }
        string GivenName { get; set; }
        System.DateTime? HireDate { get; set; }
        string[] ImAddresses { get; set; }
        Sample.API.Models.IMicrosoftGraphInferenceClassification InferenceClassification { get; set; }
        Sample.API.Models.IMicrosoftGraphOfficeGraphInsights Insights { get; set; }
        string[] Interests { get; set; }
        string JobTitle { get; set; }
        string LanguageDisplayName { get; set; }
        string LanguageLocale { get; set; }
        string LegalAgeGroupClassification { get; set; }
        Sample.API.Models.IMicrosoftGraphLicenseDetails[] LicenseDetails { get; set; }
        string Mail { get; set; }
        Sample.API.Models.IMicrosoftGraphMailFolder[] MailFolders { get; set; }
        string MailNickname { get; set; }
        Sample.API.Models.IMicrosoftGraphMailboxSettings MailboxSettings { get; set; }
        string MailboxSettingsArchiveFolder { get; set; }
        Sample.API.Models.IMicrosoftGraphAutomaticRepliesSetting MailboxSettingsAutomaticRepliesSetting { get; set; }
        Sample.API.Models.IMicrosoftGraphLocaleInfo MailboxSettingsLanguage { get; set; }
        string MailboxSettingsTimeZone { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkingHours MailboxSettingsWorkingHours { get; set; }
        Sample.API.Models.IMicrosoftGraphManagedAppRegistration[] ManagedAppRegistrations { get; set; }
        Sample.API.Models.IMicrosoftGraphManagedDevice[] ManagedDevices { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject Manager { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject[] MemberOf { get; set; }
        Sample.API.Models.IMicrosoftGraphMessage[] Messages { get; set; }
        string MobilePhone { get; set; }
        string MySite { get; set; }
        string OfficeLocation { get; set; }
        string OnPremisesDomainName { get; set; }
        Sample.API.Models.IMicrosoftGraphOnPremisesExtensionAttributes OnPremisesExtensionAttributes { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute1 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute10 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute11 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute12 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute13 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute14 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute15 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute2 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute3 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute4 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute5 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute6 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute7 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute8 { get; set; }
        string OnPremisesExtensionAttributesExtensionAttribute9 { get; set; }
        string OnPremisesImmutableId { get; set; }
        System.DateTime? OnPremisesLastSyncDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError[] OnPremisesProvisioningErrors { get; set; }
        string OnPremisesSamAccountName { get; set; }
        string OnPremisesSecurityIdentifier { get; set; }
        bool? OnPremisesSyncEnabled { get; set; }
        string OnPremisesUserPrincipalName { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenote Onenote { get; set; }
        Sample.API.Models.IMicrosoftGraphOutlookUser Outlook { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject[] OwnedDevices { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject[] OwnedObjects { get; set; }
        string PasswordPolicies { get; set; }
        Sample.API.Models.IMicrosoftGraphPasswordProfile PasswordProfile { get; set; }
        bool? PasswordProfileForceChangePasswordNextSignIn { get; set; }
        string PasswordProfilePassword { get; set; }
        string[] PastProjects { get; set; }
        Sample.API.Models.IMicrosoftGraphPerson[] People { get; set; }
        Sample.API.Models.IMicrosoftGraphProfilePhoto Photo { get; set; }
        Sample.API.Models.IMicrosoftGraphProfilePhoto[] Photos { get; set; }
        Sample.API.Models.IMicrosoftGraphPlannerUser Planner { get; set; }
        string PostalCode { get; set; }
        string PreferredLanguage { get; set; }
        string PreferredName { get; set; }
        Sample.API.Models.IMicrosoftGraphProvisionedPlan[] ProvisionedPlans { get; set; }
        string[] ProxyAddresses { get; set; }
        Sample.API.Models.IMicrosoftGraphDirectoryObject[] RegisteredDevices { get; set; }
        string[] Responsibilities { get; set; }
        string ScheduledEndDateTimeDateTime { get; set; }
        string ScheduledEndDateTimeZone { get; set; }
        string ScheduledStartDateTimeDateTime { get; set; }
        string ScheduledStartDateTimeZone { get; set; }
        string[] Schools { get; set; }
        Sample.API.Models.IMicrosoftGraphUserSettings Settings { get; set; }
        string[] Skills { get; set; }
        string State { get; set; }
        string StreetAddress { get; set; }
        string Surname { get; set; }
        string TimeZoneName { get; set; }
        string UsageLocation { get; set; }
        string UserPrincipalName { get; set; }
        string UserType { get; set; }
        string[] WorkingHoursDaysOfWeek { get; set; }
        string WorkingHoursEndTime { get; set; }
        string WorkingHoursStartTime { get; set; }
        Sample.API.Models.IMicrosoftGraphTimeZoneBase WorkingHoursTimeZone { get; set; }
    }
}