namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphList : Sample.API.Models.IMicrosoftGraphList, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphList" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphListAllof1 _componentsSchemasMicrosoftGraphListAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphListAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphList" /></summary>
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
        public Sample.API.Models.IMicrosoftGraphColumnDefinition[] Columns
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .Columns;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .Columns = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphContentType[] ContentTypes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .ContentTypes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .ContentTypes = value;
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
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .DisplayName = value;
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
        public Sample.API.Models.IMicrosoftGraphDrive Drive
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .Drive;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .Drive = value;
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
        public Sample.API.Models.IMicrosoftGraphListItem[] Items
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .Items;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .Items = value;
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
        /// <summary>listInfo</summary>
        public Sample.API.Models.IMicrosoftGraphListInfo List
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .List;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .List = value;
            }
        }
        public bool? ListContentTypesEnabled
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .ListContentTypesEnabled;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .ListContentTypesEnabled = value;
            }
        }
        public bool? ListHidden
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .ListHidden;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .ListHidden = value;
            }
        }
        public string ListIdSharepointIdsListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsListId = value;
            }
        }
        public string ListItemIdSharepointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsListItemId = value;
            }
        }
        public string ListItemUniqueIdSharepointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsListItemUniqueId = value;
            }
        }
        public string ListTemplate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .ListTemplate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .ListTemplate = value;
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
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIds = value;
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
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsSiteId = value;
            }
        }
        public string SiteUrlSharepointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsSiteUrl = value;
            }
        }
        /// <summary>systemFacet</summary>
        public Sample.API.Models.IMicrosoftGraphSystemFacet System
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .System;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .System = value;
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
        public string WebIdSharepointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphListAllof1 .SharepointIdsWebId = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphList" /> instance.</summary>
        public MicrosoftGraphList()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphListAllof1 ), _componentsSchemasMicrosoftGraphListAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphListAllof1 ), _componentsSchemasMicrosoftGraphListAllof1 );
        }
    }
    public partial interface IMicrosoftGraphList : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphBaseItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphListAllof1 {

    }
}