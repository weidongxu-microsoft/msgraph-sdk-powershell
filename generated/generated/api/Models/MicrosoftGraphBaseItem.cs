namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphBaseItem : Sample.API.Models.IMicrosoftGraphBaseItem, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphBaseItem" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphBaseitemAllof1 _componentsSchemasMicrosoftGraphBaseitemAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphBaseitemAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphBaseItem" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ApplicationIdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ApplicationIdApplicationId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedByDevice = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUser CreatedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedByUser = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .CreatedDateTime = value;
            }
        }
        public string Description
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .Description;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .Description = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .DeviceIdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .DeviceIdDeviceId = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .DisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .DisplayNameApplicationDisplayName = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .DisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .DisplayNameDeviceDisplayName = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .DisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .DisplayNameUserDisplayName = value;
            }
        }
        public string ETag
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ETag;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ETag = value;
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
        public string IdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .IdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .IdApplicationId = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .IdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .IdDeviceId = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .IdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .IdUserId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedByDevice = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUser LastModifiedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedByUser = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .LastModifiedDateTime = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .Name = value;
            }
        }
        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference ParentReference
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReference;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReference = value;
            }
        }
        public string ParentReferenceDriveId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceDriveId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceDriveId = value;
            }
        }
        public string ParentReferenceDriveType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceDriveType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceDriveType = value;
            }
        }
        public string ParentReferenceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceId = value;
            }
        }
        public string ParentReferenceName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceName = value;
            }
        }
        public string ParentReferencePath
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferencePath;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferencePath = value;
            }
        }
        public string ParentReferenceShareId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceShareId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceShareId = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds ParentReferenceSharepointIds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceSharepointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .ParentReferenceSharepointIds = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsListId = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsListItemId = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsListItemUniqueId = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsSiteId = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsSiteUrl = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .SharepointIdsWebId = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity UserCreatedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserCreatedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserCreatedByUser = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserDisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserIdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserIdUserId = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity UserLastModifiedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserLastModifiedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .UserLastModifiedByUser = value;
            }
        }
        public string WebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphBaseitemAllof1 .WebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphBaseitemAllof1 .WebUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphBaseItem" /> instance.</summary>
        public MicrosoftGraphBaseItem()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphBaseitemAllof1 ), _componentsSchemasMicrosoftGraphBaseitemAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphBaseitemAllof1 ), _componentsSchemasMicrosoftGraphBaseitemAllof1 );
        }
    }
    public partial interface IMicrosoftGraphBaseItem : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphBaseitemAllof1 {

    }
}