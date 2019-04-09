namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenoteEntityHierarchyModel : Sample.API.Models.IMicrosoftGraphOnenoteEntityHierarchyModel, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteEntityHierarchyModel" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteEntityHierarchyModel" /></summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteEntitySchemaObjectModel _microsoftGraphOnenoteEntitySchemaObjectModel = new Sample.API.Models.MicrosoftGraphOnenoteEntitySchemaObjectModel ();
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .ApplicationIdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .ApplicationIdApplicationId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .CreatedByUser = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphOnenoteEntitySchemaObjectModel .CreatedDateTime;
            }
            set
            {
                _microsoftGraphOnenoteEntitySchemaObjectModel .CreatedDateTime = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DeviceIdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DeviceIdDeviceId = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayName = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayNameApplicationDisplayName = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayNameDeviceDisplayName = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .DisplayNameUserDisplayName = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOnenoteEntitySchemaObjectModel .Id;
            }
            set
            {
                _microsoftGraphOnenoteEntitySchemaObjectModel .Id = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .IdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .IdApplicationId = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .IdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .IdDeviceId = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .IdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .IdUserId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedByUser = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .LastModifiedDateTime = value;
            }
        }
        public string Self
        {
            get
            {
                return _microsoftGraphOnenoteEntitySchemaObjectModel .Self;
            }
            set
            {
                _microsoftGraphOnenoteEntitySchemaObjectModel .Self = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .UserDisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .UserIdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 .UserIdUserId = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphOnenoteEntityHierarchyModel" /> instance.
        /// </summary>
        public MicrosoftGraphOnenoteEntityHierarchyModel()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOnenoteEntitySchemaObjectModel ), _microsoftGraphOnenoteEntitySchemaObjectModel );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOnenoteEntitySchemaObjectModel ), _microsoftGraphOnenoteEntitySchemaObjectModel );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 ), _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 ), _componentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenoteEntityHierarchyModel : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOnenoteEntitySchemaObjectModel, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityhierarchymodelAllof1 {

    }
}