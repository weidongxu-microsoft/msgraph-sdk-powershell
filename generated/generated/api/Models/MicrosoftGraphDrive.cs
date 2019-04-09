namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDrive : Sample.API.Models.IMicrosoftGraphDrive, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDrive" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveAllof1 _componentsSchemasMicrosoftGraphDriveAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDriveAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDrive" /></summary>
        private Sample.API.Models.IMicrosoftGraphBaseItem _microsoftGraphBaseItem = new Sample.API.Models.MicrosoftGraphBaseItem ();
        public string ApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .ApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .ApplicationDisplayName = value;
            }
        }
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
        public string ApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .ApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .ApplicationId = value;
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
        public string DeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .DeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .DeviceDisplayName = value;
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
        public string DeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .DeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .DeviceId = value;
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
        public string DriveType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .DriveType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .DriveType = value;
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
        public Sample.API.Models.IMicrosoftGraphDriveItem[] Items
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .Items;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .Items = value;
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
        public Sample.API.Models.IMicrosoftGraphList List
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .List;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .List = value;
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
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet Owner
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .Owner;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .Owner = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .OwnerApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .OwnerApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .OwnerDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .OwnerDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .OwnerUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .OwnerUser = value;
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
        /// <summary>quota</summary>
        public Sample.API.Models.IMicrosoftGraphQuota Quota
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .Quota;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .Quota = value;
            }
        }
        public long? QuotaDeleted
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaDeleted;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaDeleted = value;
            }
        }
        public long? QuotaRemaining
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaRemaining;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaRemaining = value;
            }
        }
        public string QuotaState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaState = value;
            }
        }
        public long? QuotaTotal
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaTotal;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaTotal = value;
            }
        }
        public long? QuotaUsed
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaUsed;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .QuotaUsed = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDriveItem Root
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .Root;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .Root = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds SharePointIds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIds = value;
            }
        }
        public string SharePointIdsListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsListId = value;
            }
        }
        public string SharePointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsListItemId = value;
            }
        }
        public string SharePointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsListItemUniqueId = value;
            }
        }
        public string SharePointIdsSiteId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsSiteId = value;
            }
        }
        public string SharePointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsSiteUrl = value;
            }
        }
        public string SharePointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .SharePointIdsWebId = value;
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
        public Sample.API.Models.IMicrosoftGraphDriveItem[] Special
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .Special;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .Special = value;
            }
        }
        /// <summary>systemFacet</summary>
        public Sample.API.Models.IMicrosoftGraphSystemFacet System
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .System;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .System = value;
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
        public string UserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .UserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .UserDisplayName = value;
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
        public string UserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveAllof1 .UserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveAllof1 .UserId = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphDrive" /> instance.</summary>
        public MicrosoftGraphDrive()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDriveAllof1 ), _componentsSchemasMicrosoftGraphDriveAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDriveAllof1 ), _componentsSchemasMicrosoftGraphDriveAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDrive : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphBaseItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveAllof1 {

    }
}