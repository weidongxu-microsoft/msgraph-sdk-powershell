namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphManagedDevice : Sample.API.Models.IMicrosoftGraphManagedDevice, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedDevice" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphManageddeviceAllof1 _componentsSchemasMicrosoftGraphManageddeviceAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphManageddeviceAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedDevice" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>Code that allows the Activation Lock on a device to be bypassed.</summary>
        public string ActivationLockBypassCode
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ActivationLockBypassCode;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ActivationLockBypassCode = value;
            }
        }
        /// <summary>Android security patch level</summary>
        public string AndroidSecurityPatchLevel
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .AndroidSecurityPatchLevel;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .AndroidSecurityPatchLevel = value;
            }
        }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only.</summary>
        public string AzureADDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .AzureADDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .AzureADDeviceId = value;
            }
        }
        /// <summary>Whether the device is Azure Active Directory registered.</summary>
        public bool? AzureADRegistered
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .AzureADRegistered;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .AzureADRegistered = value;
            }
        }
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public System.DateTime? ComplianceGracePeriodExpirationDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ComplianceGracePeriodExpirationDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ComplianceGracePeriodExpirationDateTime = value;
            }
        }
        /// <summary>complianceState</summary>
        public string ComplianceState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ComplianceState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ComplianceState = value;
            }
        }
        /// <summary>configurationManagerClientEnabledFeatures</summary>
        public Sample.API.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeatures;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeatures = value;
            }
        }
        /// <summary>Whether compliance policy is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesCompliancePolicy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesCompliancePolicy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesCompliancePolicy = value;
            }
        }
        /// <summary>Whether device configuration is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesDeviceConfiguration
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesDeviceConfiguration;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesDeviceConfiguration = value;
            }
        }
        /// <summary>Whether inventory is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesInventory
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesInventory;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesInventory = value;
            }
        }
        /// <summary>Whether modern application is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesModernApps
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesModernApps;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesModernApps = value;
            }
        }
        /// <summary>Whether resource access is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesResourceAccess
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesResourceAccess;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesResourceAccess = value;
            }
        }
        /// <summary>Whether Windows Update for Business is managed by Intune</summary>
        public bool? ConfigurationManagerClientEnabledFeaturesWindowsUpdateForBusiness
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesWindowsUpdateForBusiness;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ConfigurationManagerClientEnabledFeaturesWindowsUpdateForBusiness = value;
            }
        }
        /// <summary>List of ComplexType deviceActionResult objects.</summary>
        public Sample.API.Models.IMicrosoftGraphDeviceActionResult[] DeviceActionResults
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceActionResults;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceActionResults = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDeviceCategory DeviceCategory
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceCategory;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceCategory = value;
            }
        }
        /// <summary>Device category display name</summary>
        public string DeviceCategoryDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceCategoryDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceCategoryDisplayName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicyState[] DeviceCompliancePolicyStates
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceCompliancePolicyStates;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceCompliancePolicyStates = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDeviceConfigurationState[] DeviceConfigurationStates
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceConfigurationStates;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceConfigurationStates = value;
            }
        }
        /// <summary>deviceEnrollmentType</summary>
        public string DeviceEnrollmentType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceEnrollmentType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceEnrollmentType = value;
            }
        }
        /// <summary>deviceHealthAttestationState</summary>
        public Sample.API.Models.IMicrosoftGraphDeviceHealthAttestationState DeviceHealthAttestationState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceHealthAttestationState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceHealthAttestationState = value;
            }
        }
        /// <summary>Name of the device</summary>
        public string DeviceName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceName = value;
            }
        }
        /// <summary>deviceRegistrationState</summary>
        public string DeviceRegistrationState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceRegistrationState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .DeviceRegistrationState = value;
            }
        }
        /// <summary>Whether the device is Exchange ActiveSync activated.</summary>
        public bool? EasActivated
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EasActivated;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EasActivated = value;
            }
        }
        /// <summary>Exchange ActivationSync activation time of the device.</summary>
        public System.DateTime? EasActivationDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EasActivationDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EasActivationDateTime = value;
            }
        }
        /// <summary>Exchange ActiveSync Id of the device.</summary>
        public string EasDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EasDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EasDeviceId = value;
            }
        }
        /// <summary>Email(s) for the user associated with the device</summary>
        public string EmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EmailAddress = value;
            }
        }
        /// <summary>Enrollment time of the device.</summary>
        public System.DateTime? EnrolledDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EnrolledDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .EnrolledDateTime = value;
            }
        }
        /// <summary>deviceManagementExchangeAccessState</summary>
        public string ExchangeAccessState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ExchangeAccessState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ExchangeAccessState = value;
            }
        }
        /// <summary>deviceManagementExchangeAccessStateReason</summary>
        public string ExchangeAccessStateReason
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ExchangeAccessStateReason;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ExchangeAccessStateReason = value;
            }
        }
        /// <summary>Last time the device contacted Exchange.</summary>
        public System.DateTime? ExchangeLastSuccessfulSyncDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ExchangeLastSuccessfulSyncDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ExchangeLastSuccessfulSyncDateTime = value;
            }
        }
        /// <summary>Free Storage in Bytes</summary>
        public long? FreeStorageSpaceInBytes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .FreeStorageSpaceInBytes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .FreeStorageSpaceInBytes = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        /// <summary>IMEI</summary>
        public string Imei
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Imei;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Imei = value;
            }
        }
        /// <summary>Device encryption status</summary>
        public bool? IsEncrypted
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .IsEncrypted;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .IsEncrypted = value;
            }
        }
        /// <summary>Device supervised status</summary>
        public bool? IsSupervised
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .IsSupervised;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .IsSupervised = value;
            }
        }
        /// <summary>whether the device is jail broken or rooted.</summary>
        public string JailBroken
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .JailBroken;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .JailBroken = value;
            }
        }
        /// <summary>The date and time that the device last completed a successful sync with Intune.</summary>
        public System.DateTime? LastSyncDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .LastSyncDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .LastSyncDateTime = value;
            }
        }
        /// <summary>
        /// Automatically generated name to identify a device. Can be overwritten to a user friendly name.
        /// </summary>
        public string ManagedDeviceName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ManagedDeviceName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ManagedDeviceName = value;
            }
        }
        /// <summary>managedDeviceOwnerType</summary>
        public string ManagedDeviceOwnerType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ManagedDeviceOwnerType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ManagedDeviceOwnerType = value;
            }
        }
        /// <summary>managementAgentType</summary>
        public string ManagementAgent
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ManagementAgent;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .ManagementAgent = value;
            }
        }
        /// <summary>Manufacturer of the device</summary>
        public string Manufacturer
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Manufacturer;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Manufacturer = value;
            }
        }
        /// <summary>MEID</summary>
        public string Meid
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Meid;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Meid = value;
            }
        }
        /// <summary>Model of the device</summary>
        public string Model
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Model;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .Model = value;
            }
        }
        /// <summary>Operating system of the device. Windows, iOS, etc.</summary>
        public string OperatingSystem
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .OperatingSystem;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .OperatingSystem = value;
            }
        }
        /// <summary>Operating system version of the device.</summary>
        public string OsVersion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .OsVersion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .OsVersion = value;
            }
        }
        /// <summary>managedDevicePartnerReportedHealthState</summary>
        public string PartnerReportedThreatState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .PartnerReportedThreatState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .PartnerReportedThreatState = value;
            }
        }
        /// <summary>Phone number of the device</summary>
        public string PhoneNumber
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .PhoneNumber;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .PhoneNumber = value;
            }
        }
        /// <summary>
        /// An error string that identifies issues when creating Remote Assistance session objects.
        /// </summary>
        public string RemoteAssistanceSessionErrorDetails
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .RemoteAssistanceSessionErrorDetails;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .RemoteAssistanceSessionErrorDetails = value;
            }
        }
        /// <summary>Url that allows a Remote Assistance session to be established with the device.</summary>
        public string RemoteAssistanceSessionUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .RemoteAssistanceSessionUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .RemoteAssistanceSessionUrl = value;
            }
        }
        /// <summary>SerialNumber</summary>
        public string SerialNumber
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .SerialNumber;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .SerialNumber = value;
            }
        }
        /// <summary>Subscriber Carrier</summary>
        public string SubscriberCarrier
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .SubscriberCarrier;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .SubscriberCarrier = value;
            }
        }
        /// <summary>Total Storage in Bytes</summary>
        public long? TotalStorageSpaceInBytes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .TotalStorageSpaceInBytes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .TotalStorageSpaceInBytes = value;
            }
        }
        /// <summary>User display name</summary>
        public string UserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .UserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .UserDisplayName = value;
            }
        }
        /// <summary>Unique Identifier for the user associated with the device</summary>
        public string UserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .UserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .UserId = value;
            }
        }
        /// <summary>Device user principal name</summary>
        public string UserPrincipalName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .UserPrincipalName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .UserPrincipalName = value;
            }
        }
        /// <summary>Wi-Fi MAC</summary>
        public string WiFiMacAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManageddeviceAllof1 .WiFiMacAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManageddeviceAllof1 .WiFiMacAddress = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphManagedDevice" /> instance.</summary>
        public MicrosoftGraphManagedDevice()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphManageddeviceAllof1 ), _componentsSchemasMicrosoftGraphManageddeviceAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphManageddeviceAllof1 ), _componentsSchemasMicrosoftGraphManageddeviceAllof1 );
        }
    }
    public partial interface IMicrosoftGraphManagedDevice : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphManageddeviceAllof1 {

    }
}