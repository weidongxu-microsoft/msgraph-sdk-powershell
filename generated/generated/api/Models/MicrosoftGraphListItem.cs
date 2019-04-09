namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphListItem : Sample.API.Models.IMicrosoftGraphListItem, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphListItem" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemAllof1 _componentsSchemasMicrosoftGraphListitemAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphListitemAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphListItem" /></summary>
        private Sample.API.Models.IMicrosoftGraphBaseItem _microsoftGraphBaseItem = new Sample.API.Models.MicrosoftGraphBaseItem ();
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _microsoftGraphBaseItem .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _microsoftGraphBaseItem .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return _microsoftGraphBaseItem .ApplicationIdApplicationId;
            }
            set
            {
                _microsoftGraphBaseItem .ApplicationIdApplicationId = value;
            }
        }
        /// <summary>contentTypeInfo</summary>
        public Sample.API.Models.IMicrosoftGraphContentTypeInfo ContentType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .ContentType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .ContentType = value;
            }
        }
        public string ContentTypeId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .ContentTypeId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .ContentTypeId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return _microsoftGraphBaseItem .CreatedBy;
            }
            set
            {
                _microsoftGraphBaseItem .CreatedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return _microsoftGraphBaseItem .CreatedByApplication;
            }
            set
            {
                _microsoftGraphBaseItem .CreatedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return _microsoftGraphBaseItem .CreatedByDevice;
            }
            set
            {
                _microsoftGraphBaseItem .CreatedByDevice = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUser CreatedByUser
        {
            get
            {
                return _microsoftGraphBaseItem .CreatedByUser;
            }
            set
            {
                _microsoftGraphBaseItem .CreatedByUser = value;
            }
        }
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _microsoftGraphBaseItem .CreatedDateTime;
            }
            set
            {
                _microsoftGraphBaseItem .CreatedDateTime = value;
            }
        }
        public string Description
        {
            get
            {
                return _microsoftGraphBaseItem .Description;
            }
            set
            {
                _microsoftGraphBaseItem .Description = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _microsoftGraphBaseItem .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _microsoftGraphBaseItem .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return _microsoftGraphBaseItem .DeviceIdDeviceId;
            }
            set
            {
                _microsoftGraphBaseItem .DeviceIdDeviceId = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return _microsoftGraphBaseItem .DisplayNameApplicationDisplayName;
            }
            set
            {
                _microsoftGraphBaseItem .DisplayNameApplicationDisplayName = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return _microsoftGraphBaseItem .DisplayNameDeviceDisplayName;
            }
            set
            {
                _microsoftGraphBaseItem .DisplayNameDeviceDisplayName = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return _microsoftGraphBaseItem .DisplayNameUserDisplayName;
            }
            set
            {
                _microsoftGraphBaseItem .DisplayNameUserDisplayName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDriveItem DriveItem
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .DriveItem;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .DriveItem = value;
            }
        }
        public string ETag
        {
            get
            {
                return _microsoftGraphBaseItem .ETag;
            }
            set
            {
                _microsoftGraphBaseItem .ETag = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphFieldValueSet Fields
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .Fields;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .Fields = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphBaseItem .Id;
            }
            set
            {
                _microsoftGraphBaseItem .Id = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return _microsoftGraphBaseItem .IdApplicationId;
            }
            set
            {
                _microsoftGraphBaseItem .IdApplicationId = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return _microsoftGraphBaseItem .IdDeviceId;
            }
            set
            {
                _microsoftGraphBaseItem .IdDeviceId = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return _microsoftGraphBaseItem .IdUserId;
            }
            set
            {
                _microsoftGraphBaseItem .IdUserId = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return _microsoftGraphBaseItem .LastModifiedBy;
            }
            set
            {
                _microsoftGraphBaseItem .LastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return _microsoftGraphBaseItem .LastModifiedByApplication;
            }
            set
            {
                _microsoftGraphBaseItem .LastModifiedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return _microsoftGraphBaseItem .LastModifiedByDevice;
            }
            set
            {
                _microsoftGraphBaseItem .LastModifiedByDevice = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphUser LastModifiedByUser
        {
            get
            {
                return _microsoftGraphBaseItem .LastModifiedByUser;
            }
            set
            {
                _microsoftGraphBaseItem .LastModifiedByUser = value;
            }
        }
        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return _microsoftGraphBaseItem .LastModifiedDateTime;
            }
            set
            {
                _microsoftGraphBaseItem .LastModifiedDateTime = value;
            }
        }
        public string ListIdSharepointIdsListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsListId = value;
            }
        }
        public string ListItemIdSharepointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsListItemId = value;
            }
        }
        public string ListItemUniqueIdSharepointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsListItemUniqueId = value;
            }
        }
        public string Name
        {
            get
            {
                return _microsoftGraphBaseItem .Name;
            }
            set
            {
                _microsoftGraphBaseItem .Name = value;
            }
        }
        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference ParentReference
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReference;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReference = value;
            }
        }
        public string ParentReferenceDriveId
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferenceDriveId;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferenceDriveId = value;
            }
        }
        public string ParentReferenceDriveType
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferenceDriveType;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferenceDriveType = value;
            }
        }
        public string ParentReferenceId
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferenceId;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferenceId = value;
            }
        }
        public string ParentReferenceName
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferenceName;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferenceName = value;
            }
        }
        public string ParentReferencePath
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferencePath;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferencePath = value;
            }
        }
        public string ParentReferenceShareId
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferenceShareId;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferenceShareId = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds ParentReferenceSharepointIds
        {
            get
            {
                return _microsoftGraphBaseItem .ParentReferenceSharepointIds;
            }
            set
            {
                _microsoftGraphBaseItem .ParentReferenceSharepointIds = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIds = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return _microsoftGraphBaseItem .SharepointIdsListId;
            }
            set
            {
                _microsoftGraphBaseItem .SharepointIdsListId = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return _microsoftGraphBaseItem .SharepointIdsListItemId;
            }
            set
            {
                _microsoftGraphBaseItem .SharepointIdsListItemId = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return _microsoftGraphBaseItem .SharepointIdsListItemUniqueId;
            }
            set
            {
                _microsoftGraphBaseItem .SharepointIdsListItemUniqueId = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return _microsoftGraphBaseItem .SharepointIdsSiteId;
            }
            set
            {
                _microsoftGraphBaseItem .SharepointIdsSiteId = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return _microsoftGraphBaseItem .SharepointIdsSiteUrl;
            }
            set
            {
                _microsoftGraphBaseItem .SharepointIdsSiteUrl = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return _microsoftGraphBaseItem .SharepointIdsWebId;
            }
            set
            {
                _microsoftGraphBaseItem .SharepointIdsWebId = value;
            }
        }
        public string SiteIdSharepointIdsSiteId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsSiteId = value;
            }
        }
        public string SiteUrlSharepointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsSiteUrl = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity UserCreatedByUser
        {
            get
            {
                return _microsoftGraphBaseItem .UserCreatedByUser;
            }
            set
            {
                _microsoftGraphBaseItem .UserCreatedByUser = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return _microsoftGraphBaseItem .UserDisplayNameUserDisplayName;
            }
            set
            {
                _microsoftGraphBaseItem .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return _microsoftGraphBaseItem .UserIdUserId;
            }
            set
            {
                _microsoftGraphBaseItem .UserIdUserId = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity UserLastModifiedByUser
        {
            get
            {
                return _microsoftGraphBaseItem .UserLastModifiedByUser;
            }
            set
            {
                _microsoftGraphBaseItem .UserLastModifiedByUser = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphListItemVersion[] Versions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .Versions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .Versions = value;
            }
        }
        public string WebIdSharepointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListitemAllof1 .SharepointIdsWebId = value;
            }
        }
        public string WebUrl
        {
            get
            {
                return _microsoftGraphBaseItem .WebUrl;
            }
            set
            {
                _microsoftGraphBaseItem .WebUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphListItem" /> instance.</summary>
        public MicrosoftGraphListItem()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphBaseItem ), _microsoftGraphBaseItem );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphBaseItem ), _microsoftGraphBaseItem );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphListitemAllof1 ), _componentsSchemasMicrosoftGraphListitemAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphListitemAllof1 ), _componentsSchemasMicrosoftGraphListitemAllof1 );
        }
    }
    public partial interface IMicrosoftGraphListItem : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphBaseItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphListitemAllof1 {

    }
}