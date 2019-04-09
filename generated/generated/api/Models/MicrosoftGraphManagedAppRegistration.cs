namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphManagedAppRegistration : Sample.API.Models.IMicrosoftGraphManagedAppRegistration, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedAppRegistration" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphManagedAppRegistration" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>mobileAppIdentifier</summary>
        public Sample.API.Models.IMicrosoftGraphMobileAppIdentifier AppIdentifier
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .AppIdentifier;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .AppIdentifier = value;
            }
        }
        /// <summary>App version</summary>
        public string ApplicationVersion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .ApplicationVersion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .ApplicationVersion = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] AppliedPolicies
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .AppliedPolicies;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .AppliedPolicies = value;
            }
        }
        /// <summary>Date and time of creation</summary>
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .CreatedDateTime = value;
            }
        }
        /// <summary>Host device name</summary>
        public string DeviceName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .DeviceName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .DeviceName = value;
            }
        }
        /// <summary>
        /// App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in
        /// all conditions.
        /// </summary>
        public string DeviceTag
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .DeviceTag;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .DeviceTag = value;
            }
        }
        /// <summary>Host device type</summary>
        public string DeviceType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .DeviceType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .DeviceType = value;
            }
        }
        /// <summary>
        /// Zero or more reasons an app registration is flagged. E.g. app running on rooted device
        /// </summary>
        public string[] FlaggedReasons
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .FlaggedReasons;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .FlaggedReasons = value;
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
        public Sample.API.Models.IMicrosoftGraphManagedAppPolicy[] IntendedPolicies
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .IntendedPolicies;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .IntendedPolicies = value;
            }
        }
        /// <summary>Date and time of last the app synced with management service.</summary>
        public System.DateTime? LastSyncDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .LastSyncDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .LastSyncDateTime = value;
            }
        }
        /// <summary>App management SDK version</summary>
        public string ManagementSdkVersion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .ManagementSdkVersion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .ManagementSdkVersion = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphManagedAppOperation[] Operations
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .Operations;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .Operations = value;
            }
        }
        /// <summary>Operating System version</summary>
        public string PlatformVersion
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .PlatformVersion;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .PlatformVersion = value;
            }
        }
        /// <summary>The user Id to who this app registration belongs.</summary>
        public string UserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .UserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .UserId = value;
            }
        }
        /// <summary>Version of the entity.</summary>
        public string Version
        {
            get
            {
                return _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .Version;
            }
            set
            {
                _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 .Version = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphManagedAppRegistration" /> instance.</summary>
        public MicrosoftGraphManagedAppRegistration()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphManagedappregistrationAllof1 ), _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphManagedappregistrationAllof1 ), _componentsSchemasMicrosoftGraphManagedappregistrationAllof1 );
        }
    }
    public partial interface IMicrosoftGraphManagedAppRegistration : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappregistrationAllof1 {

    }
}