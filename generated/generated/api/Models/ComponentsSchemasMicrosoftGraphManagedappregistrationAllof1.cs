namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    /// </summary>
    public partial class ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1
    {
        /// <summary>Backing field for <see cref="AppIdentifier" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMobileAppIdentifier _appIdentifier;

        /// <summary>mobileAppIdentifier</summary>
        public Sample.API.Models.IMicrosoftGraphMobileAppIdentifier AppIdentifier
        {
            get
            {
                return this._appIdentifier;
            }
            set
            {
                this._appIdentifier = value;
            }
        }
        /// <summary>Backing field for <see cref="ApplicationVersion" /> property.</summary>
        private string _applicationVersion;

        /// <summary>App version</summary>
        public string ApplicationVersion
        {
            get
            {
                return this._applicationVersion;
            }
            set
            {
                this._applicationVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="AppliedPolicies" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] _appliedPolicies;

        public Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] AppliedPolicies
        {
            get
            {
                return this._appliedPolicies;
            }
            set
            {
                this._appliedPolicies = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        /// <summary>Date and time of creation</summary>
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceName" /> property.</summary>
        private string _deviceName;

        /// <summary>Host device name</summary>
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
        /// <summary>Backing field for <see cref="DeviceTag" /> property.</summary>
        private string _deviceTag;

        /// <summary>
        /// App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in
        /// all conditions.
        /// </summary>
        public string DeviceTag
        {
            get
            {
                return this._deviceTag;
            }
            set
            {
                this._deviceTag = value;
            }
        }
        /// <summary>Backing field for <see cref="DeviceType" /> property.</summary>
        private string _deviceType;

        /// <summary>Host device type</summary>
        public string DeviceType
        {
            get
            {
                return this._deviceType;
            }
            set
            {
                this._deviceType = value;
            }
        }
        /// <summary>Backing field for <see cref="FlaggedReasons" /> property.</summary>
        private string[] _flaggedReasons;

        /// <summary>
        /// Zero or more reasons an app registration is flagged. E.g. app running on rooted device
        /// </summary>
        public string[] FlaggedReasons
        {
            get
            {
                return this._flaggedReasons;
            }
            set
            {
                this._flaggedReasons = value;
            }
        }
        /// <summary>Backing field for <see cref="IntendedPolicies" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] _intendedPolicies;

        public Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] IntendedPolicies
        {
            get
            {
                return this._intendedPolicies;
            }
            set
            {
                this._intendedPolicies = value;
            }
        }
        /// <summary>Backing field for <see cref="LastSyncDateTime" /> property.</summary>
        private System.DateTime? _lastSyncDateTime;

        /// <summary>Date and time of last the app synced with management service.</summary>
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
        /// <summary>Backing field for <see cref="ManagementSdkVersion" /> property.</summary>
        private string _managementSdkVersion;

        /// <summary>App management SDK version</summary>
        public string ManagementSdkVersion
        {
            get
            {
                return this._managementSdkVersion;
            }
            set
            {
                this._managementSdkVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="Operations" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphManagedAppOperation[] _operations;

        public Sample.API.Models.IMicrosoftGraphManagedAppOperation[] Operations
        {
            get
            {
                return this._operations;
            }
            set
            {
                this._operations = value;
            }
        }
        /// <summary>Backing field for <see cref="PlatformVersion" /> property.</summary>
        private string _platformVersion;

        /// <summary>Operating System version</summary>
        public string PlatformVersion
        {
            get
            {
                return this._platformVersion;
            }
            set
            {
                this._platformVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>The user Id to who this app registration belongs.</summary>
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
        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of the entity.</summary>
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1()
        {
        }
    }
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    public partial interface IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphMobileAppIdentifier AppIdentifier { get; set; }
        string ApplicationVersion { get; set; }
        Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] AppliedPolicies { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        string DeviceName { get; set; }
        string DeviceTag { get; set; }
        string DeviceType { get; set; }
        string[] FlaggedReasons { get; set; }
        Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] IntendedPolicies { get; set; }
        System.DateTime? LastSyncDateTime { get; set; }
        string ManagementSdkVersion { get; set; }
        Sample.API.Models.IMicrosoftGraphManagedAppOperation[] Operations { get; set; }
        string PlatformVersion { get; set; }
        string UserId { get; set; }
        string Version { get; set; }
    }
}