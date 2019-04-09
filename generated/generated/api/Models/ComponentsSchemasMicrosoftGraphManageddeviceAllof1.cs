namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Devices that are managed or pre-enrolled through Intune</summary>
    public partial class ComponentsSchemasMicrosoftGraphManageddeviceAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphManageddeviceAllof1
    {
        /// <summary>Backing field for <see cref="ActivationLockBypassCode" /> property.</summary>
        private string _activationLockBypassCode;

        /// <summary>Code that allows the Activation Lock on a device to be bypassed.</summary>
        public string ActivationLockBypassCode
        {
            get
            {
                return this._activationLockBypassCode;
            }
            set
            {
                this._activationLockBypassCode = value;
            }
        }
        /// <summary>Backing field for <see cref="AndroidSecurityPatchLevel" /> property.</summary>
        private string _androidSecurityPatchLevel;

        /// <summary>Android security patch level</summary>
        public string AndroidSecurityPatchLevel
        {
            get
            {
                return this._androidSecurityPatchLevel;
            }
            set
            {
                this._androidSecurityPatchLevel = value;
            }
        }
        /// <summary>Backing field for <see cref="AzureADDeviceId" /> property.</summary>
        private string _azureADDeviceId;

        /// <summary>The unique identifier for the Azure Active Directory device. Read only.</summary>
        public string AzureADDeviceId
        {
            get
            {
                return this._azureADDeviceId;
            }
            set
            {
                this._azureADDeviceId = value;
            }
        }
        /// <summary>Backing field for <see cref="AzureADRegistered" /> property.</summary>
        private bool? _azureADRegistered;

        /// <summary>Whether the device is Azure Active Directory registered.</summary>
        public bool? AzureADRegistered
        {
            get
            {
                return this._azureADRegistered;
            }
            set
            {
                this._azureADRegistered = value;
            }
        }
        /// <summary>
        /// Backing field for <see cref="ComplianceGracePeriodExpirationDateTime" /> property.
        /// </summary>
        private System.DateTime? _complianceGracePeriodExpirationDateTime;

        /// <summary>The DateTime when device compliance grace period expires</summary>
        public System.DateTime? ComplianceGracePeriodExpirationDateTime
        {
            get
            {
                return this._complianceGracePeriodExpirationDateTime;
            }
            set
            {
                this._complianceGracePeriodExpirationDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="ComplianceState" /> property.</summary>
        private string _complianceState;

        /// <summary>complianceState</summary>
        public string ComplianceState
        {
            get
            {
                return this._complianceState;
            }
            set
            {
                this._complianceState = value;
            }
        }
        /// <summary>
        /// Backing field for <see cref="ConfigurationManagerClientEnabledFeatures" /> property.
        /// </summary>
        private Sample.API.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures _configurationManagerClientEnabledFeatures;

        /// <summary>configurationManagerClientEnabledFeatures</summary>
        public Sample.API.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures
        {
            get
            {
                return this._configurationManagerClientEnabledFeatures;
            }
            set
            {
                this._configurationManagerClientEnabledFeatures = value;
            }
        }
        /// <summary>Whether compliance policy is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesCompliancePolicy
        {
            get
            {
                return /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.CompliancePolicy/*3*/;
            }
            set
            {
                /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.CompliancePolicy/*3*/ = value;
            }
        }
        /// <summary>Whether device configuration is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesDeviceConfiguration
        {
            get
            {
                return /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.DeviceConfiguration/*3*/;
            }
            set
            {
                /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.DeviceConfiguration/*3*/ = value;
            }
        }
        /// <summary>Whether inventory is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesInventory
        {
            get
            {
                return /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.Inventory/*3*/;
            }
            set
            {
                /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.Inventory/*3*/ = value;
            }
        }
        /// <summary>Whether modern application is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesModernApps
        {
            get
            {
                return /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.ModernApps/*3*/;
            }
            set
            {
                /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.ModernApps/*3*/ = value;
            }
        }
        /// <summary>Whether resource access is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesResourceAccess
        {
            get
            {
                return /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.ResourceAccess/*3*/;
            }
            set
            {
                /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.ResourceAccess/*3*/ = value;
            }
        }
        /// <summary>Whether Windows Update for Business is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesWindowsUpdateForBusiness
        {
            get
            {
                return /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.WindowsUpdateForBusiness/*3*/;
            }
            set
            {
                /*1*/ConfigurationManagerClientEnabledFeatures/*4*/.WindowsUpdateForBusiness/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceActionResults" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeviceActionResult[] _deviceActionResults;

        /// <summary>List of ComplexType deviceActionResult objects.</summary>
        public Sample.API.Models.IMicrosoftGraphDeviceActionResult[] DeviceActionResults
        {
            get
            {
                return this._deviceActionResults;
            }
            set
            {
                this._deviceActionResults = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceCategory" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeviceCategory _deviceCategory;

        public Sample.API.Models.IMicrosoftGraphDeviceCategory DeviceCategory
        {
            get
            {
                return this._deviceCategory;
            }
            set
            {
                this._deviceCategory = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceCategoryDisplayName" /> property.</summary>
        private string _deviceCategoryDisplayName;

        /// <summary>Device category display name</summary>
        public string DeviceCategoryDisplayName
        {
            get
            {
                return this._deviceCategoryDisplayName;
            }
            set
            {
                this._deviceCategoryDisplayName = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceCompliancePolicyStates" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState[] _deviceCompliancePolicyStates;

        public Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState[] DeviceCompliancePolicyStates
        {
            get
            {
                return this._deviceCompliancePolicyStates;
            }
            set
            {
                this._deviceCompliancePolicyStates = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceConfigurationStates" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeviceConfigurationState[] _deviceConfigurationStates;

        public Sample.API.Models.IMicrosoftGraphDeviceConfigurationState[] DeviceConfigurationStates
        {
            get
            {
                return this._deviceConfigurationStates;
            }
            set
            {
                this._deviceConfigurationStates = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceEnrollmentType" /> property.</summary>
        private string _deviceEnrollmentType;

        /// <summary>deviceEnrollmentType</summary>
        public string DeviceEnrollmentType
        {
            get
            {
                return this._deviceEnrollmentType;
            }
            set
            {
                this._deviceEnrollmentType = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceHealthAttestationState" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState _deviceHealthAttestationState;

        /// <summary>deviceHealthAttestationState</summary>
        public Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState DeviceHealthAttestationState
        {
            get
            {
                return this._deviceHealthAttestationState;
            }
            set
            {
                this._deviceHealthAttestationState = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceName" /> property.</summary>
        private string _deviceName;

        /// <summary>Name of the device</summary>
        public string DeviceName
        {
            get
            {
                return this._deviceName;
            }
            set
            {
                this._deviceName = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceRegistrationState" /> property.</summary>
        private string _deviceRegistrationState;

        /// <summary>deviceRegistrationState</summary>
        public string DeviceRegistrationState
        {
            get
            {
                return this._deviceRegistrationState;
            }
            set
            {
                this._deviceRegistrationState = value;
            }
        }
        /// <summary>Backing field for <see cref="EasActivated" /> property.</summary>
        private bool? _easActivated;

        /// <summary>Whether the device is Exchange ActiveSync activated.</summary>
        public bool? EasActivated
        {
            get
            {
                return this._easActivated;
            }
            set
            {
                this._easActivated = value;
            }
        }
        /// <summary>Backing field for <see cref="EasActivationDateTime" /> property.</summary>
        private System.DateTime? _easActivationDateTime;

        /// <summary>Exchange ActivationSync activation time of the device.</summary>
        public System.DateTime? EasActivationDateTime
        {
            get
            {
                return this._easActivationDateTime;
            }
            set
            {
                this._easActivationDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="EasDeviceId" /> property.</summary>
        private string _easDeviceId;

        /// <summary>Exchange ActiveSync Id of the device.</summary>
        public string EasDeviceId
        {
            get
            {
                return this._easDeviceId;
            }
            set
            {
                this._easDeviceId = value;
            }
        }
        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private string _emailAddress;

        /// <summary>Email(s) for the user associated with the device</summary>
        public string EmailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                this._emailAddress = value;
            }
        }
        /// <summary>Backing field for <see cref="EnrolledDateTime" /> property.</summary>
        private System.DateTime? _enrolledDateTime;

        /// <summary>Enrollment time of the device.</summary>
        public System.DateTime? EnrolledDateTime
        {
            get
            {
                return this._enrolledDateTime;
            }
            set
            {
                this._enrolledDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="ExchangeAccessState" /> property.</summary>
        private string _exchangeAccessState;

        /// <summary>deviceManagementExchangeAccessState</summary>
        public string ExchangeAccessState
        {
            get
            {
                return this._exchangeAccessState;
            }
            set
            {
                this._exchangeAccessState = value;
            }
        }
        /// <summary>Backing field for <see cref="ExchangeAccessStateReason" /> property.</summary>
        private string _exchangeAccessStateReason;

        /// <summary>deviceManagementExchangeAccessStateReason</summary>
        public string ExchangeAccessStateReason
        {
            get
            {
                return this._exchangeAccessStateReason;
            }
            set
            {
                this._exchangeAccessStateReason = value;
            }
        }
        /// <summary>Backing field for <see cref="ExchangeLastSuccessfulSyncDateTime" /> property.</summary>
        private System.DateTime? _exchangeLastSuccessfulSyncDateTime;

        /// <summary>Last time the device contacted Exchange.</summary>
        public System.DateTime? ExchangeLastSuccessfulSyncDateTime
        {
            get
            {
                return this._exchangeLastSuccessfulSyncDateTime;
            }
            set
            {
                this._exchangeLastSuccessfulSyncDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="FreeStorageSpaceInBytes" /> property.</summary>
        private long? _freeStorageSpaceInBytes;

        /// <summary>Free Storage in Bytes</summary>
        public long? FreeStorageSpaceInBytes
        {
            get
            {
                return this._freeStorageSpaceInBytes;
            }
            set
            {
                this._freeStorageSpaceInBytes = value;
            }
        }
        /// <summary>Backing field for <see cref="Imei" /> property.</summary>
        private string _imei;

        /// <summary>IMEI</summary>
        public string Imei
        {
            get
            {
                return this._imei;
            }
            set
            {
                this._imei = value;
            }
        }
        /// <summary>Backing field for <see cref="IsEncrypted" /> property.</summary>
        private bool? _isEncrypted;

        /// <summary>Device encryption status</summary>
        public bool? IsEncrypted
        {
            get
            {
                return this._isEncrypted;
            }
            set
            {
                this._isEncrypted = value;
            }
        }
        /// <summary>Backing field for <see cref="IsSupervised" /> property.</summary>
        private bool? _isSupervised;

        /// <summary>Device supervised status</summary>
        public bool? IsSupervised
        {
            get
            {
                return this._isSupervised;
            }
            set
            {
                this._isSupervised = value;
            }
        }
        /// <summary>Backing field for <see cref="JailBroken" /> property.</summary>
        private string _jailBroken;

        /// <summary>whether the device is jail broken or rooted.</summary>
        public string JailBroken
        {
            get
            {
                return this._jailBroken;
            }
            set
            {
                this._jailBroken = value;
            }
        }
        /// <summary>Backing field for <see cref="LastSyncDateTime" /> property.</summary>
        private System.DateTime? _lastSyncDateTime;

        /// <summary>The date and time that the device last completed a successful sync with Intune.</summary>
        public System.DateTime? LastSyncDateTime
        {
            get
            {
                return this._lastSyncDateTime;
            }
            set
            {
                this._lastSyncDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="ManagedDeviceName" /> property.</summary>
        private string _managedDeviceName;

        /// <summary>
        /// Automatically generated name to identify a device. Can be overwritten to a user friendly name.
        /// </summary>
        public string ManagedDeviceName
        {
            get
            {
                return this._managedDeviceName;
            }
            set
            {
                this._managedDeviceName = value;
            }
        }
        /// <summary>Backing field for <see cref="ManagedDeviceOwnerType" /> property.</summary>
        private string _managedDeviceOwnerType;

        /// <summary>managedDeviceOwnerType</summary>
        public string ManagedDeviceOwnerType
        {
            get
            {
                return this._managedDeviceOwnerType;
            }
            set
            {
                this._managedDeviceOwnerType = value;
            }
        }
        /// <summary>Backing field for <see cref="ManagementAgent" /> property.</summary>
        private string _managementAgent;

        /// <summary>managementAgentType</summary>
        public string ManagementAgent
        {
            get
            {
                return this._managementAgent;
            }
            set
            {
                this._managementAgent = value;
            }
        }
        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        /// <summary>Manufacturer of the device</summary>
        public string Manufacturer
        {
            get
            {
                return this._manufacturer;
            }
            set
            {
                this._manufacturer = value;
            }
        }
        /// <summary>Backing field for <see cref="Meid" /> property.</summary>
        private string _meid;

        /// <summary>MEID</summary>
        public string Meid
        {
            get
            {
                return this._meid;
            }
            set
            {
                this._meid = value;
            }
        }
        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the device</summary>
        public string Model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }
        /// <summary>Backing field for <see cref="OperatingSystem" /> property.</summary>
        private string _operatingSystem;

        /// <summary>Operating system of the device. Windows, iOS, etc.</summary>
        public string OperatingSystem
        {
            get
            {
                return this._operatingSystem;
            }
            set
            {
                this._operatingSystem = value;
            }
        }
        /// <summary>Backing field for <see cref="OsVersion" /> property.</summary>
        private string _osVersion;

        /// <summary>Operating system version of the device.</summary>
        public string OsVersion
        {
            get
            {
                return this._osVersion;
            }
            set
            {
                this._osVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="PartnerReportedThreatState" /> property.</summary>
        private string _partnerReportedThreatState;

        /// <summary>managedDevicePartnerReportedHealthState</summary>
        public string PartnerReportedThreatState
        {
            get
            {
                return this._partnerReportedThreatState;
            }
            set
            {
                this._partnerReportedThreatState = value;
            }
        }
        /// <summary>Backing field for <see cref="PhoneNumber" /> property.</summary>
        private string _phoneNumber;

        /// <summary>Phone number of the device</summary>
        public string PhoneNumber
        {
            get
            {
                return this._phoneNumber;
            }
            set
            {
                this._phoneNumber = value;
            }
        }
        /// <summary>Backing field for <see cref="RemoteAssistanceSessionErrorDetails" /> property.</summary>
        private string _remoteAssistanceSessionErrorDetails;

        /// <summary>
        /// An error string that identifies issues when creating Remote Assistance session objects.
        /// </summary>
        public string RemoteAssistanceSessionErrorDetails
        {
            get
            {
                return this._remoteAssistanceSessionErrorDetails;
            }
            set
            {
                this._remoteAssistanceSessionErrorDetails = value;
            }
        }
        /// <summary>Backing field for <see cref="RemoteAssistanceSessionUrl" /> property.</summary>
        private string _remoteAssistanceSessionUrl;

        /// <summary>Url that allows a Remote Assistance session to be established with the device.</summary>
        public string RemoteAssistanceSessionUrl
        {
            get
            {
                return this._remoteAssistanceSessionUrl;
            }
            set
            {
                this._remoteAssistanceSessionUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>SerialNumber</summary>
        public string SerialNumber
        {
            get
            {
                return this._serialNumber;
            }
            set
            {
                this._serialNumber = value;
            }
        }
        /// <summary>Backing field for <see cref="SubscriberCarrier" /> property.</summary>
        private string _subscriberCarrier;

        /// <summary>Subscriber Carrier</summary>
        public string SubscriberCarrier
        {
            get
            {
                return this._subscriberCarrier;
            }
            set
            {
                this._subscriberCarrier = value;
            }
        }
        /// <summary>Backing field for <see cref="TotalStorageSpaceInBytes" /> property.</summary>
        private long? _totalStorageSpaceInBytes;

        /// <summary>Total Storage in Bytes</summary>
        public long? TotalStorageSpaceInBytes
        {
            get
            {
                return this._totalStorageSpaceInBytes;
            }
            set
            {
                this._totalStorageSpaceInBytes = value;
            }
        }
        /// <summary>Backing field for <see cref="UserDisplayName" /> property.</summary>
        private string _userDisplayName;

        /// <summary>User display name</summary>
        public string UserDisplayName
        {
            get
            {
                return this._userDisplayName;
            }
            set
            {
                this._userDisplayName = value;
            }
        }
        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>Unique Identifier for the user associated with the device</summary>
        public string UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;
            }
        }
        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>Device user principal name</summary>
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
        /// <summary>Backing field for <see cref="WiFiMacAddress" /> property.</summary>
        private string _wiFiMacAddress;

        /// <summary>Wi-Fi MAC</summary>
        public string WiFiMacAddress
        {
            get
            {
                return this._wiFiMacAddress;
            }
            set
            {
                this._wiFiMacAddress = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphManageddeviceAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphManageddeviceAllof1()
        {
        }
    }
    /// Devices that are managed or pre-enrolled through Intune
    public partial interface IComponentsSchemasMicrosoftGraphManageddeviceAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ActivationLockBypassCode { get; set; }
        string AndroidSecurityPatchLevel { get; set; }
        string AzureADDeviceId { get; set; }
        bool? AzureADRegistered { get; set; }
        System.DateTime? ComplianceGracePeriodExpirationDateTime { get; set; }
        string ComplianceState { get; set; }
        Sample.API.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures { get; set; }
        bool? ConfigurationManagerClientEnabledFeaturesCompliancePolicy { get; set; }
        bool? ConfigurationManagerClientEnabledFeaturesDeviceConfiguration { get; set; }
        bool? ConfigurationManagerClientEnabledFeaturesInventory { get; set; }
        bool? ConfigurationManagerClientEnabledFeaturesModernApps { get; set; }
        bool? ConfigurationManagerClientEnabledFeaturesResourceAccess { get; set; }
        bool? ConfigurationManagerClientEnabledFeaturesWindowsUpdateForBusiness { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceActionResult[] DeviceActionResults { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceCategory DeviceCategory { get; set; }
        string DeviceCategoryDisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState[] DeviceCompliancePolicyStates { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceConfigurationState[] DeviceConfigurationStates { get; set; }
        string DeviceEnrollmentType { get; set; }
        Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState DeviceHealthAttestationState { get; set; }
        string DeviceName { get; set; }
        string DeviceRegistrationState { get; set; }
        bool? EasActivated { get; set; }
        System.DateTime? EasActivationDateTime { get; set; }
        string EasDeviceId { get; set; }
        string EmailAddress { get; set; }
        System.DateTime? EnrolledDateTime { get; set; }
        string ExchangeAccessState { get; set; }
        string ExchangeAccessStateReason { get; set; }
        System.DateTime? ExchangeLastSuccessfulSyncDateTime { get; set; }
        long? FreeStorageSpaceInBytes { get; set; }
        string Imei { get; set; }
        bool? IsEncrypted { get; set; }
        bool? IsSupervised { get; set; }
        string JailBroken { get; set; }
        System.DateTime? LastSyncDateTime { get; set; }
        string ManagedDeviceName { get; set; }
        string ManagedDeviceOwnerType { get; set; }
        string ManagementAgent { get; set; }
        string Manufacturer { get; set; }
        string Meid { get; set; }
        string Model { get; set; }
        string OperatingSystem { get; set; }
        string OsVersion { get; set; }
        string PartnerReportedThreatState { get; set; }
        string PhoneNumber { get; set; }
        string RemoteAssistanceSessionErrorDetails { get; set; }
        string RemoteAssistanceSessionUrl { get; set; }
        string SerialNumber { get; set; }
        string SubscriberCarrier { get; set; }
        long? TotalStorageSpaceInBytes { get; set; }
        string UserDisplayName { get; set; }
        string UserId { get; set; }
        string UserPrincipalName { get; set; }
        string WiFiMacAddress { get; set; }
    }
}