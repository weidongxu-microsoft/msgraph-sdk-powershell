namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>user</summary>
    public partial class ComponentsSchemasMicrosoftGraphUserAllof1
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphUserAllof1" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphUserAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_mailboxSettings = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("mailboxSettings"), out var __jsonMailboxSettings) ? Sample.API.Models.MicrosoftGraphMailboxSettings.FromJson(__jsonMailboxSettings) : MailboxSettings;}
            {_onPremisesExtensionAttributes = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("onPremisesExtensionAttributes"), out var __jsonOnPremisesExtensionAttributes) ? Sample.API.Models.MicrosoftGraphOnPremisesExtensionAttributes.FromJson(__jsonOnPremisesExtensionAttributes) : OnPremisesExtensionAttributes;}
            {_passwordProfile = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("passwordProfile"), out var __jsonPasswordProfile) ? Sample.API.Models.MicrosoftGraphPasswordProfile.FromJson(__jsonPasswordProfile) : PasswordProfile;}
            {_aboutMe = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("aboutMe"), out var __jsonAboutMe) ? (string)__jsonAboutMe : (string)AboutMe;}
            {_accountEnabled = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("accountEnabled"), out var __jsonAccountEnabled) ? (bool?)__jsonAccountEnabled : AccountEnabled;}
            {_activities = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("activities"), out var __jsonActivities) ? If( __jsonActivities as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphUserActivity[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphUserActivity) (Sample.API.Models.MicrosoftGraphUserActivity.FromJson(__u) )) ))() : null : Activities;}
            {_ageGroup = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("ageGroup"), out var __jsonAgeGroup) ? (string)__jsonAgeGroup : (string)AgeGroup;}
            {_assignedLicenses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("assignedLicenses"), out var __jsonAssignedLicenses) ? If( __jsonAssignedLicenses as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphAssignedLicense[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphAssignedLicense) (Sample.API.Models.MicrosoftGraphAssignedLicense.FromJson(__p) )) ))() : null : AssignedLicenses;}
            {_assignedPlans = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("assignedPlans"), out var __jsonAssignedPlans) ? If( __jsonAssignedPlans as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphAssignedPlan[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphAssignedPlan) (Sample.API.Models.MicrosoftGraphAssignedPlan.FromJson(__k) )) ))() : null : AssignedPlans;}
            {_birthday = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("birthday"), out var __jsonBirthday) ? System.DateTime.TryParse((string)__jsonBirthday, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonBirthdayValue) ? __jsonBirthdayValue : Birthday : Birthday;}
            {_businessPhones = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("businessPhones"), out var __jsonBusinessPhones) ? If( __jsonBusinessPhones as Sample.API.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(string) (__f is Sample.API.Runtime.Json.JsonString __e ? (string)__e : null)) ))() : null : BusinessPhones;}
            {_calendar = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("calendar"), out var __jsonCalendar) ? Sample.API.Models.MicrosoftGraphCalendar.FromJson(__jsonCalendar) : Calendar;}
            {_calendarGroups = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("calendarGroups"), out var __jsonCalendarGroups) ? If( __jsonCalendarGroups as Sample.API.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphCalendarGroup[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Sample.API.Models.IMicrosoftGraphCalendarGroup) (Sample.API.Models.MicrosoftGraphCalendarGroup.FromJson(__a) )) ))() : null : CalendarGroups;}
            {_calendarView = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("calendarView"), out var __jsonCalendarView) ? If( __jsonCalendarView as Sample.API.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphEvent[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Sample.API.Models.IMicrosoftGraphEvent) (Sample.API.Models.MicrosoftGraphEvent.FromJson(___v) )) ))() : null : CalendarView;}
            {_calendars = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("calendars"), out var __jsonCalendars) ? If( __jsonCalendars as Sample.API.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphCalendar[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(Sample.API.Models.IMicrosoftGraphCalendar) (Sample.API.Models.MicrosoftGraphCalendar.FromJson(___q) )) ))() : null : Calendars;}
            {_city = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("city"), out var __jsonCity) ? (string)__jsonCity : (string)City;}
            {_companyName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("companyName"), out var __jsonCompanyName) ? (string)__jsonCompanyName : (string)CompanyName;}
            {_consentProvidedForMinor = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("consentProvidedForMinor"), out var __jsonConsentProvidedForMinor) ? (string)__jsonConsentProvidedForMinor : (string)ConsentProvidedForMinor;}
            {_contactFolders = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("contactFolders"), out var __jsonContactFolders) ? If( __jsonContactFolders as Sample.API.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphContactFolder[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___m, (___l)=>(Sample.API.Models.IMicrosoftGraphContactFolder) (Sample.API.Models.MicrosoftGraphContactFolder.FromJson(___l) )) ))() : null : ContactFolders;}
            {_contacts = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("contacts"), out var __jsonContacts) ? If( __jsonContacts as Sample.API.Runtime.Json.JsonArray, out var ___h) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphContact[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___h, (___g)=>(Sample.API.Models.IMicrosoftGraphContact) (Sample.API.Models.MicrosoftGraphContact.FromJson(___g) )) ))() : null : Contacts;}
            {_country = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("country"), out var __jsonCountry) ? (string)__jsonCountry : (string)Country;}
            {_createdObjects = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("createdObjects"), out var __jsonCreatedObjects) ? If( __jsonCreatedObjects as Sample.API.Runtime.Json.JsonArray, out var ___c) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___c, (___b)=>(Sample.API.Models.IMicrosoftGraphDirectoryObject) (Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(___b) )) ))() : null : CreatedObjects;}
            {_department = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("department"), out var __jsonDepartment) ? (string)__jsonDepartment : (string)Department;}
            {_deviceEnrollmentLimit = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("deviceEnrollmentLimit"), out var __jsonDeviceEnrollmentLimit) ? (int?)__jsonDeviceEnrollmentLimit : DeviceEnrollmentLimit;}
            {_deviceManagementTroubleshootingEvents = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("deviceManagementTroubleshootingEvents"), out var __jsonDeviceManagementTroubleshootingEvents) ? If( __jsonDeviceManagementTroubleshootingEvents as Sample.API.Runtime.Json.JsonArray, out var ____x) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(____x, (____w)=>(Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent) (Sample.API.Models.MicrosoftGraphDeviceManagementTroubleshootingEvent.FromJson(____w) )) ))() : null : DeviceManagementTroubleshootingEvents;}
            {_directReports = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("directReports"), out var __jsonDirectReports) ? If( __jsonDirectReports as Sample.API.Runtime.Json.JsonArray, out var ____s) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(____s, (____r)=>(Sample.API.Models.IMicrosoftGraphDirectoryObject) (Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(____r) )) ))() : null : DirectReports;}
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_drive = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("drive"), out var __jsonDrive) ? Sample.API.Models.MicrosoftGraphDrive.FromJson(__jsonDrive) : Drive;}
            {_drives = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("drives"), out var __jsonDrives) ? If( __jsonDrives as Sample.API.Runtime.Json.JsonArray, out var ____n) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDrive[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(____n, (____m)=>(Sample.API.Models.IMicrosoftGraphDrive) (Sample.API.Models.MicrosoftGraphDrive.FromJson(____m) )) ))() : null : Drives;}
            {_events = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("events"), out var __jsonEvents) ? If( __jsonEvents as Sample.API.Runtime.Json.JsonArray, out var ____i) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphEvent[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(____i, (____h)=>(Sample.API.Models.IMicrosoftGraphEvent) (Sample.API.Models.MicrosoftGraphEvent.FromJson(____h) )) ))() : null : Events;}
            {_givenName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("givenName"), out var __jsonGivenName) ? (string)__jsonGivenName : (string)GivenName;}
            {_hireDate = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("hireDate"), out var __jsonHireDate) ? System.DateTime.TryParse((string)__jsonHireDate, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonHireDateValue) ? __jsonHireDateValue : HireDate : HireDate;}
            {_imAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("imAddresses"), out var __jsonImAddresses) ? If( __jsonImAddresses as Sample.API.Runtime.Json.JsonArray, out var ____d) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(____d, (____c)=>(string) (____c is Sample.API.Runtime.Json.JsonString ____b ? (string)____b : null)) ))() : null : ImAddresses;}
            {_inferenceClassification = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("inferenceClassification"), out var __jsonInferenceClassification) ? Sample.API.Models.MicrosoftGraphInferenceClassification.FromJson(__jsonInferenceClassification) : InferenceClassification;}
            {_insights = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("insights"), out var __jsonInsights) ? Sample.API.Models.MicrosoftGraphOfficeGraphInsights.FromJson(__jsonInsights) : Insights;}
            {_interests = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("interests"), out var __jsonInterests) ? If( __jsonInterests as Sample.API.Runtime.Json.JsonArray, out var _____y) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_____y, (_____x)=>(string) (_____x is Sample.API.Runtime.Json.JsonString _____w ? (string)_____w : null)) ))() : null : Interests;}
            {_jobTitle = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("jobTitle"), out var __jsonJobTitle) ? (string)__jsonJobTitle : (string)JobTitle;}
            {_legalAgeGroupClassification = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("legalAgeGroupClassification"), out var __jsonLegalAgeGroupClassification) ? (string)__jsonLegalAgeGroupClassification : (string)LegalAgeGroupClassification;}
            {_licenseDetails = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("licenseDetails"), out var __jsonLicenseDetails) ? If( __jsonLicenseDetails as Sample.API.Runtime.Json.JsonArray, out var _____t) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphLicenseDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_____t, (_____s)=>(Sample.API.Models.IMicrosoftGraphLicenseDetails) (Sample.API.Models.MicrosoftGraphLicenseDetails.FromJson(_____s) )) ))() : null : LicenseDetails;}
            {_mail = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("mail"), out var __jsonMail) ? (string)__jsonMail : (string)Mail;}
            {_mailFolders = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("mailFolders"), out var __jsonMailFolders) ? If( __jsonMailFolders as Sample.API.Runtime.Json.JsonArray, out var _____o) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMailFolder[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_____o, (_____n)=>(Sample.API.Models.IMicrosoftGraphMailFolder) (Sample.API.Models.MicrosoftGraphMailFolder.FromJson(_____n) )) ))() : null : MailFolders;}
            {_mailNickname = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("mailNickname"), out var __jsonMailNickname) ? (string)__jsonMailNickname : (string)MailNickname;}
            {_managedAppRegistrations = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("managedAppRegistrations"), out var __jsonManagedAppRegistrations) ? If( __jsonManagedAppRegistrations as Sample.API.Runtime.Json.JsonArray, out var _____j) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphManagedAppRegistration[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_____j, (_____i)=>(Sample.API.Models.IMicrosoftGraphManagedAppRegistration) (Sample.API.Models.MicrosoftGraphManagedAppRegistration.FromJson(_____i) )) ))() : null : ManagedAppRegistrations;}
            {_managedDevices = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("managedDevices"), out var __jsonManagedDevices) ? If( __jsonManagedDevices as Sample.API.Runtime.Json.JsonArray, out var _____e) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphManagedDevice[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_____e, (_____d)=>(Sample.API.Models.IMicrosoftGraphManagedDevice) (Sample.API.Models.MicrosoftGraphManagedDevice.FromJson(_____d) )) ))() : null : ManagedDevices;}
            {_manager = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("manager"), out var __jsonManager) ? Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(__jsonManager) : Manager;}
            {_memberOf = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("memberOf"), out var __jsonMemberOf) ? If( __jsonMemberOf as Sample.API.Runtime.Json.JsonArray, out var ______z) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(______z, (______y)=>(Sample.API.Models.IMicrosoftGraphDirectoryObject) (Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(______y) )) ))() : null : MemberOf;}
            {_messages = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("messages"), out var __jsonMessages) ? If( __jsonMessages as Sample.API.Runtime.Json.JsonArray, out var ______u) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphMessage[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(______u, (______t)=>(Sample.API.Models.IMicrosoftGraphMessage) (Sample.API.Models.MicrosoftGraphMessage.FromJson(______t) )) ))() : null : Messages;}
            {_mobilePhone = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("mobilePhone"), out var __jsonMobilePhone) ? (string)__jsonMobilePhone : (string)MobilePhone;}
            {_mySite = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("mySite"), out var __jsonMySite) ? (string)__jsonMySite : (string)MySite;}
            {_officeLocation = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("officeLocation"), out var __jsonOfficeLocation) ? (string)__jsonOfficeLocation : (string)OfficeLocation;}
            {_onPremisesDomainName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onPremisesDomainName"), out var __jsonOnPremisesDomainName) ? (string)__jsonOnPremisesDomainName : (string)OnPremisesDomainName;}
            {_onPremisesImmutableId = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onPremisesImmutableId"), out var __jsonOnPremisesImmutableId) ? (string)__jsonOnPremisesImmutableId : (string)OnPremisesImmutableId;}
            {_onPremisesLastSyncDateTime = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onPremisesLastSyncDateTime"), out var __jsonOnPremisesLastSyncDateTime) ? System.DateTime.TryParse((string)__jsonOnPremisesLastSyncDateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonOnPremisesLastSyncDateTimeValue) ? __jsonOnPremisesLastSyncDateTimeValue : OnPremisesLastSyncDateTime : OnPremisesLastSyncDateTime;}
            {_onPremisesProvisioningErrors = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("onPremisesProvisioningErrors"), out var __jsonOnPremisesProvisioningErrors) ? If( __jsonOnPremisesProvisioningErrors as Sample.API.Runtime.Json.JsonArray, out var ______p) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(______p, (______o)=>(Sample.API.Models.IMicrosoftGraphOnPremisesProvisioningError) (Sample.API.Models.MicrosoftGraphOnPremisesProvisioningError.FromJson(______o) )) ))() : null : OnPremisesProvisioningErrors;}
            {_onPremisesSamAccountName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onPremisesSamAccountName"), out var __jsonOnPremisesSamAccountName) ? (string)__jsonOnPremisesSamAccountName : (string)OnPremisesSamAccountName;}
            {_onPremisesSecurityIdentifier = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onPremisesSecurityIdentifier"), out var __jsonOnPremisesSecurityIdentifier) ? (string)__jsonOnPremisesSecurityIdentifier : (string)OnPremisesSecurityIdentifier;}
            {_onPremisesSyncEnabled = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("onPremisesSyncEnabled"), out var __jsonOnPremisesSyncEnabled) ? (bool?)__jsonOnPremisesSyncEnabled : OnPremisesSyncEnabled;}
            {_onPremisesUserPrincipalName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("onPremisesUserPrincipalName"), out var __jsonOnPremisesUserPrincipalName) ? (string)__jsonOnPremisesUserPrincipalName : (string)OnPremisesUserPrincipalName;}
            {_onenote = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("onenote"), out var __jsonOnenote) ? Sample.API.Models.MicrosoftGraphOnenote.FromJson(__jsonOnenote) : Onenote;}
            {_outlook = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("outlook"), out var __jsonOutlook) ? Sample.API.Models.MicrosoftGraphOutlookUser.FromJson(__jsonOutlook) : Outlook;}
            {_ownedDevices = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("ownedDevices"), out var __jsonOwnedDevices) ? If( __jsonOwnedDevices as Sample.API.Runtime.Json.JsonArray, out var ______k) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(______k, (______j)=>(Sample.API.Models.IMicrosoftGraphDirectoryObject) (Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(______j) )) ))() : null : OwnedDevices;}
            {_ownedObjects = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("ownedObjects"), out var __jsonOwnedObjects) ? If( __jsonOwnedObjects as Sample.API.Runtime.Json.JsonArray, out var ______f) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(______f, (______e)=>(Sample.API.Models.IMicrosoftGraphDirectoryObject) (Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(______e) )) ))() : null : OwnedObjects;}
            {_passwordPolicies = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("passwordPolicies"), out var __jsonPasswordPolicies) ? (string)__jsonPasswordPolicies : (string)PasswordPolicies;}
            {_pastProjects = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("pastProjects"), out var __jsonPastProjects) ? If( __jsonPastProjects as Sample.API.Runtime.Json.JsonArray, out var ______a) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(______a, (_______z)=>(string) (_______z is Sample.API.Runtime.Json.JsonString _______y ? (string)_______y : null)) ))() : null : PastProjects;}
            {_people = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("people"), out var __jsonPeople) ? If( __jsonPeople as Sample.API.Runtime.Json.JsonArray, out var _______v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphPerson[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_______v, (_______u)=>(Sample.API.Models.IMicrosoftGraphPerson) (Sample.API.Models.MicrosoftGraphPerson.FromJson(_______u) )) ))() : null : People;}
            {_photo = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("photo"), out var __jsonPhoto) ? Sample.API.Models.MicrosoftGraphProfilePhoto.FromJson(__jsonPhoto) : Photo;}
            {_photos = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("photos"), out var __jsonPhotos) ? If( __jsonPhotos as Sample.API.Runtime.Json.JsonArray, out var _______q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphProfilePhoto[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_______q, (_______p)=>(Sample.API.Models.IMicrosoftGraphProfilePhoto) (Sample.API.Models.MicrosoftGraphProfilePhoto.FromJson(_______p) )) ))() : null : Photos;}
            {_planner = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("planner"), out var __jsonPlanner) ? Sample.API.Models.MicrosoftGraphPlannerUser.FromJson(__jsonPlanner) : Planner;}
            {_postalCode = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("postalCode"), out var __jsonPostalCode) ? (string)__jsonPostalCode : (string)PostalCode;}
            {_preferredLanguage = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("preferredLanguage"), out var __jsonPreferredLanguage) ? (string)__jsonPreferredLanguage : (string)PreferredLanguage;}
            {_preferredName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("preferredName"), out var __jsonPreferredName) ? (string)__jsonPreferredName : (string)PreferredName;}
            {_provisionedPlans = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("provisionedPlans"), out var __jsonProvisionedPlans) ? If( __jsonProvisionedPlans as Sample.API.Runtime.Json.JsonArray, out var _______l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphProvisionedPlan[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_______l, (_______k)=>(Sample.API.Models.IMicrosoftGraphProvisionedPlan) (Sample.API.Models.MicrosoftGraphProvisionedPlan.FromJson(_______k) )) ))() : null : ProvisionedPlans;}
            {_proxyAddresses = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("proxyAddresses"), out var __jsonProxyAddresses) ? If( __jsonProxyAddresses as Sample.API.Runtime.Json.JsonArray, out var _______g) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_______g, (_______f)=>(string) (_______f is Sample.API.Runtime.Json.JsonString _______e ? (string)_______e : null)) ))() : null : ProxyAddresses;}
            {_registeredDevices = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("registeredDevices"), out var __jsonRegisteredDevices) ? If( __jsonRegisteredDevices as Sample.API.Runtime.Json.JsonArray, out var _______b) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(_______b, (_______a)=>(Sample.API.Models.IMicrosoftGraphDirectoryObject) (Sample.API.Models.MicrosoftGraphDirectoryObject.FromJson(_______a) )) ))() : null : RegisteredDevices;}
            {_responsibilities = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("responsibilities"), out var __jsonResponsibilities) ? If( __jsonResponsibilities as Sample.API.Runtime.Json.JsonArray, out var ________w) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(________w, (________v)=>(string) (________v is Sample.API.Runtime.Json.JsonString ________u ? (string)________u : null)) ))() : null : Responsibilities;}
            {_schools = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("schools"), out var __jsonSchools) ? If( __jsonSchools as Sample.API.Runtime.Json.JsonArray, out var ________r) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(________r, (________q)=>(string) (________q is Sample.API.Runtime.Json.JsonString ________p ? (string)________p : null)) ))() : null : Schools;}
            {_settings = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("settings"), out var __jsonSettings) ? Sample.API.Models.MicrosoftGraphUserSettings.FromJson(__jsonSettings) : Settings;}
            {_skills = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("skills"), out var __jsonSkills) ? If( __jsonSkills as Sample.API.Runtime.Json.JsonArray, out var ________m) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(________m, (________l)=>(string) (________l is Sample.API.Runtime.Json.JsonString ________k ? (string)________k : null)) ))() : null : Skills;}
            {_state = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_streetAddress = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("streetAddress"), out var __jsonStreetAddress) ? (string)__jsonStreetAddress : (string)StreetAddress;}
            {_surname = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("surname"), out var __jsonSurname) ? (string)__jsonSurname : (string)Surname;}
            {_usageLocation = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("usageLocation"), out var __jsonUsageLocation) ? (string)__jsonUsageLocation : (string)UsageLocation;}
            {_userPrincipalName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userPrincipalName"), out var __jsonUserPrincipalName) ? (string)__jsonUserPrincipalName : (string)UserPrincipalName;}
            {_userType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("userType"), out var __jsonUserType) ? (string)__jsonUserType : (string)UserType;}
            {_extensions = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Sample.API.Runtime.Json.JsonArray, out var ________h) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphExtension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(________h, (________g)=>(Sample.API.Models.IMicrosoftGraphExtension) (Sample.API.Models.MicrosoftGraphExtension.FromJson(________g) )) ))() : null : Extensions;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphUserAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphUserAllof1.</returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphUserAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphUserAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphUserAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphUserAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != MailboxSettings ? (Sample.API.Runtime.Json.JsonNode) MailboxSettings.ToJson(null,serializationMode) : null, "mailboxSettings" ,container.Add );
            AddIf( null != OnPremisesExtensionAttributes ? (Sample.API.Runtime.Json.JsonNode) OnPremisesExtensionAttributes.ToJson(null,serializationMode) : null, "onPremisesExtensionAttributes" ,container.Add );
            AddIf( null != PasswordProfile ? (Sample.API.Runtime.Json.JsonNode) PasswordProfile.ToJson(null,serializationMode) : null, "passwordProfile" ,container.Add );
            AddIf( null != (((object)AboutMe)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AboutMe.ToString()) : null, "aboutMe" ,container.Add );
            AddIf( null != AccountEnabled ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AccountEnabled) : null, "accountEnabled" ,container.Add );
            if (null != Activities)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Activities )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("activities",__w);
            }
            AddIf( null != (((object)AgeGroup)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AgeGroup.ToString()) : null, "ageGroup" ,container.Add );
            if (null != AssignedLicenses)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in AssignedLicenses )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("assignedLicenses",__r);
            }
            if (null != AssignedPlans)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in AssignedPlans )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("assignedPlans",__m);
            }
            AddIf( null != Birthday ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Birthday?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "birthday" ,container.Add );
            if (null != BusinessPhones)
            {
                var __h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __i in BusinessPhones )
                {
                    AddIf(null != (((object)__i)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(__i.ToString()) : null ,__h.Add);
                }
                container.Add("businessPhones",__h);
            }
            AddIf( null != Calendar ? (Sample.API.Runtime.Json.JsonNode) Calendar.ToJson(null,serializationMode) : null, "calendar" ,container.Add );
            if (null != CalendarGroups)
            {
                var __c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __d in CalendarGroups )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("calendarGroups",__c);
            }
            if (null != CalendarView)
            {
                var ___x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___y in CalendarView )
                {
                    AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                }
                container.Add("calendarView",___x);
            }
            if (null != Calendars)
            {
                var ___s = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___t in Calendars )
                {
                    AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                }
                container.Add("calendars",___s);
            }
            AddIf( null != (((object)City)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(City.ToString()) : null, "city" ,container.Add );
            AddIf( null != (((object)CompanyName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(CompanyName.ToString()) : null, "companyName" ,container.Add );
            AddIf( null != (((object)ConsentProvidedForMinor)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(ConsentProvidedForMinor.ToString()) : null, "consentProvidedForMinor" ,container.Add );
            if (null != ContactFolders)
            {
                var ___n = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___o in ContactFolders )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("contactFolders",___n);
            }
            if (null != Contacts)
            {
                var ___i = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___j in Contacts )
                {
                    AddIf(___j?.ToJson(null, serializationMode) ,___i.Add);
                }
                container.Add("contacts",___i);
            }
            AddIf( null != (((object)Country)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Country.ToString()) : null, "country" ,container.Add );
            if (null != CreatedObjects)
            {
                var ___d = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ___e in CreatedObjects )
                {
                    AddIf(___e?.ToJson(null, serializationMode) ,___d.Add);
                }
                container.Add("createdObjects",___d);
            }
            AddIf( null != (((object)Department)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Department.ToString()) : null, "department" ,container.Add );
            AddIf( null != DeviceEnrollmentLimit ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)DeviceEnrollmentLimit) : null, "deviceEnrollmentLimit" ,container.Add );
            if (null != DeviceManagementTroubleshootingEvents)
            {
                var ____y = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ____z in DeviceManagementTroubleshootingEvents )
                {
                    AddIf(____z?.ToJson(null, serializationMode) ,____y.Add);
                }
                container.Add("deviceManagementTroubleshootingEvents",____y);
            }
            if (null != DirectReports)
            {
                var ____t = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ____u in DirectReports )
                {
                    AddIf(____u?.ToJson(null, serializationMode) ,____t.Add);
                }
                container.Add("directReports",____t);
            }
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != Drive ? (Sample.API.Runtime.Json.JsonNode) Drive.ToJson(null,serializationMode) : null, "drive" ,container.Add );
            if (null != Drives)
            {
                var ____o = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ____p in Drives )
                {
                    AddIf(____p?.ToJson(null, serializationMode) ,____o.Add);
                }
                container.Add("drives",____o);
            }
            if (null != Events)
            {
                var ____j = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ____k in Events )
                {
                    AddIf(____k?.ToJson(null, serializationMode) ,____j.Add);
                }
                container.Add("events",____j);
            }
            AddIf( null != (((object)GivenName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(GivenName.ToString()) : null, "givenName" ,container.Add );
            AddIf( null != HireDate ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(HireDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "hireDate" ,container.Add );
            if (null != ImAddresses)
            {
                var ____e = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ____f in ImAddresses )
                {
                    AddIf(null != (((object)____f)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(____f.ToString()) : null ,____e.Add);
                }
                container.Add("imAddresses",____e);
            }
            AddIf( null != InferenceClassification ? (Sample.API.Runtime.Json.JsonNode) InferenceClassification.ToJson(null,serializationMode) : null, "inferenceClassification" ,container.Add );
            AddIf( null != Insights ? (Sample.API.Runtime.Json.JsonNode) Insights.ToJson(null,serializationMode) : null, "insights" ,container.Add );
            if (null != Interests)
            {
                var _____z = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ____a in Interests )
                {
                    AddIf(null != (((object)____a)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(____a.ToString()) : null ,_____z.Add);
                }
                container.Add("interests",_____z);
            }
            AddIf( null != (((object)JobTitle)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(JobTitle.ToString()) : null, "jobTitle" ,container.Add );
            AddIf( null != (((object)LegalAgeGroupClassification)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(LegalAgeGroupClassification.ToString()) : null, "legalAgeGroupClassification" ,container.Add );
            if (null != LicenseDetails)
            {
                var _____u = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _____v in LicenseDetails )
                {
                    AddIf(_____v?.ToJson(null, serializationMode) ,_____u.Add);
                }
                container.Add("licenseDetails",_____u);
            }
            AddIf( null != (((object)Mail)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Mail.ToString()) : null, "mail" ,container.Add );
            if (null != MailFolders)
            {
                var _____p = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _____q in MailFolders )
                {
                    AddIf(_____q?.ToJson(null, serializationMode) ,_____p.Add);
                }
                container.Add("mailFolders",_____p);
            }
            AddIf( null != (((object)MailNickname)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MailNickname.ToString()) : null, "mailNickname" ,container.Add );
            if (null != ManagedAppRegistrations)
            {
                var _____k = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _____l in ManagedAppRegistrations )
                {
                    AddIf(_____l?.ToJson(null, serializationMode) ,_____k.Add);
                }
                container.Add("managedAppRegistrations",_____k);
            }
            if (null != ManagedDevices)
            {
                var _____f = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _____g in ManagedDevices )
                {
                    AddIf(_____g?.ToJson(null, serializationMode) ,_____f.Add);
                }
                container.Add("managedDevices",_____f);
            }
            AddIf( null != Manager ? (Sample.API.Runtime.Json.JsonNode) Manager.ToJson(null,serializationMode) : null, "manager" ,container.Add );
            if (null != MemberOf)
            {
                var _____a = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _____b in MemberOf )
                {
                    AddIf(_____b?.ToJson(null, serializationMode) ,_____a.Add);
                }
                container.Add("memberOf",_____a);
            }
            if (null != Messages)
            {
                var ______v = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ______w in Messages )
                {
                    AddIf(______w?.ToJson(null, serializationMode) ,______v.Add);
                }
                container.Add("messages",______v);
            }
            AddIf( null != (((object)MobilePhone)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MobilePhone.ToString()) : null, "mobilePhone" ,container.Add );
            AddIf( null != (((object)MySite)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(MySite.ToString()) : null, "mySite" ,container.Add );
            AddIf( null != (((object)OfficeLocation)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OfficeLocation.ToString()) : null, "officeLocation" ,container.Add );
            AddIf( null != (((object)OnPremisesDomainName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnPremisesDomainName.ToString()) : null, "onPremisesDomainName" ,container.Add );
            AddIf( null != (((object)OnPremisesImmutableId)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnPremisesImmutableId.ToString()) : null, "onPremisesImmutableId" ,container.Add );
            AddIf( null != OnPremisesLastSyncDateTime ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnPremisesLastSyncDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "onPremisesLastSyncDateTime" ,container.Add );
            if (null != OnPremisesProvisioningErrors)
            {
                var ______q = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ______r in OnPremisesProvisioningErrors )
                {
                    AddIf(______r?.ToJson(null, serializationMode) ,______q.Add);
                }
                container.Add("onPremisesProvisioningErrors",______q);
            }
            AddIf( null != (((object)OnPremisesSamAccountName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnPremisesSamAccountName.ToString()) : null, "onPremisesSamAccountName" ,container.Add );
            AddIf( null != (((object)OnPremisesSecurityIdentifier)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnPremisesSecurityIdentifier.ToString()) : null, "onPremisesSecurityIdentifier" ,container.Add );
            AddIf( null != OnPremisesSyncEnabled ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)OnPremisesSyncEnabled) : null, "onPremisesSyncEnabled" ,container.Add );
            AddIf( null != (((object)OnPremisesUserPrincipalName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(OnPremisesUserPrincipalName.ToString()) : null, "onPremisesUserPrincipalName" ,container.Add );
            AddIf( null != Onenote ? (Sample.API.Runtime.Json.JsonNode) Onenote.ToJson(null,serializationMode) : null, "onenote" ,container.Add );
            AddIf( null != Outlook ? (Sample.API.Runtime.Json.JsonNode) Outlook.ToJson(null,serializationMode) : null, "outlook" ,container.Add );
            if (null != OwnedDevices)
            {
                var ______l = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ______m in OwnedDevices )
                {
                    AddIf(______m?.ToJson(null, serializationMode) ,______l.Add);
                }
                container.Add("ownedDevices",______l);
            }
            if (null != OwnedObjects)
            {
                var ______g = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ______h in OwnedObjects )
                {
                    AddIf(______h?.ToJson(null, serializationMode) ,______g.Add);
                }
                container.Add("ownedObjects",______g);
            }
            AddIf( null != (((object)PasswordPolicies)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PasswordPolicies.ToString()) : null, "passwordPolicies" ,container.Add );
            if (null != PastProjects)
            {
                var ______b = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ______c in PastProjects )
                {
                    AddIf(null != (((object)______c)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(______c.ToString()) : null ,______b.Add);
                }
                container.Add("pastProjects",______b);
            }
            if (null != People)
            {
                var _______w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _______x in People )
                {
                    AddIf(_______x?.ToJson(null, serializationMode) ,_______w.Add);
                }
                container.Add("people",_______w);
            }
            AddIf( null != Photo ? (Sample.API.Runtime.Json.JsonNode) Photo.ToJson(null,serializationMode) : null, "photo" ,container.Add );
            if (null != Photos)
            {
                var _______r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _______s in Photos )
                {
                    AddIf(_______s?.ToJson(null, serializationMode) ,_______r.Add);
                }
                container.Add("photos",_______r);
            }
            AddIf( null != Planner ? (Sample.API.Runtime.Json.JsonNode) Planner.ToJson(null,serializationMode) : null, "planner" ,container.Add );
            AddIf( null != (((object)PostalCode)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PostalCode.ToString()) : null, "postalCode" ,container.Add );
            AddIf( null != (((object)PreferredLanguage)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PreferredLanguage.ToString()) : null, "preferredLanguage" ,container.Add );
            AddIf( null != (((object)PreferredName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PreferredName.ToString()) : null, "preferredName" ,container.Add );
            if (null != ProvisionedPlans)
            {
                var _______m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _______n in ProvisionedPlans )
                {
                    AddIf(_______n?.ToJson(null, serializationMode) ,_______m.Add);
                }
                container.Add("provisionedPlans",_______m);
            }
            if (null != ProxyAddresses)
            {
                var _______h = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _______i in ProxyAddresses )
                {
                    AddIf(null != (((object)_______i)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(_______i.ToString()) : null ,_______h.Add);
                }
                container.Add("proxyAddresses",_______h);
            }
            if (null != RegisteredDevices)
            {
                var _______c = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var _______d in RegisteredDevices )
                {
                    AddIf(_______d?.ToJson(null, serializationMode) ,_______c.Add);
                }
                container.Add("registeredDevices",_______c);
            }
            if (null != Responsibilities)
            {
                var ________x = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ________y in Responsibilities )
                {
                    AddIf(null != (((object)________y)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(________y.ToString()) : null ,________x.Add);
                }
                container.Add("responsibilities",________x);
            }
            if (null != Schools)
            {
                var ________s = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ________t in Schools )
                {
                    AddIf(null != (((object)________t)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(________t.ToString()) : null ,________s.Add);
                }
                container.Add("schools",________s);
            }
            AddIf( null != Settings ? (Sample.API.Runtime.Json.JsonNode) Settings.ToJson(null,serializationMode) : null, "settings" ,container.Add );
            if (null != Skills)
            {
                var ________n = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ________o in Skills )
                {
                    AddIf(null != (((object)________o)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(________o.ToString()) : null ,________n.Add);
                }
                container.Add("skills",________n);
            }
            AddIf( null != (((object)State)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(State.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)StreetAddress)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(StreetAddress.ToString()) : null, "streetAddress" ,container.Add );
            AddIf( null != (((object)Surname)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Surname.ToString()) : null, "surname" ,container.Add );
            AddIf( null != (((object)UsageLocation)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UsageLocation.ToString()) : null, "usageLocation" ,container.Add );
            AddIf( null != (((object)UserPrincipalName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserPrincipalName.ToString()) : null, "userPrincipalName" ,container.Add );
            AddIf( null != (((object)UserType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(UserType.ToString()) : null, "userType" ,container.Add );
            if (null != Extensions)
            {
                var ________i = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var ________j in Extensions )
                {
                    AddIf(________j?.ToJson(null, serializationMode) ,________i.Add);
                }
                container.Add("extensions",________i);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}