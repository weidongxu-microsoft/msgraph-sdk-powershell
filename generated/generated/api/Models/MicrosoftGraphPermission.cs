namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphPermission : Sample.API.Models.IMicrosoftGraphPermission, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphPermission" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphPermissionAllof1 _componentsSchemasMicrosoftGraphPermissionAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphPermissionAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphPermission" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .ApplicationIdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .ApplicationIdApplicationId = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .DeviceIdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .DeviceIdDeviceId = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .DisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .DisplayNameApplicationDisplayName = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .DisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .DisplayNameDeviceDisplayName = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .DisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .DisplayNameUserDisplayName = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet GrantedTo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedTo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedTo = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity GrantedToApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedToApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedToApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity GrantedToDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedToDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedToDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity GrantedToUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedToUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .GrantedToUser = value;
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
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .IdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .IdApplicationId = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .IdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .IdDeviceId = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .IdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .IdUserId = value;
            }
        }
        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference InheritedFrom
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFrom;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFrom = value;
            }
        }
        public string InheritedFromDriveId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromDriveId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromDriveId = value;
            }
        }
        public string InheritedFromDriveType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromDriveType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromDriveType = value;
            }
        }
        public string InheritedFromId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromId = value;
            }
        }
        public string InheritedFromName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromName = value;
            }
        }
        public string InheritedFromPath
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromPath;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromPath = value;
            }
        }
        public string InheritedFromShareId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromShareId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromShareId = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds InheritedFromSharepointIds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromSharepointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InheritedFromSharepointIds = value;
            }
        }
        /// <summary>sharingInvitation</summary>
        public Sample.API.Models.IMicrosoftGraphSharingInvitation Invitation
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .Invitation;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .Invitation = value;
            }
        }
        public string InvitationEmail
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationEmail;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationEmail = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet InvitationInvitedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationInvitedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationInvitedBy = value;
            }
        }
        public string InvitationRedeemedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationRedeemedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationRedeemedBy = value;
            }
        }
        public bool? InvitationSignInRequired
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationSignInRequired;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitationSignInRequired = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .InvitedByUser = value;
            }
        }
        /// <summary>sharingLink</summary>
        public Sample.API.Models.IMicrosoftGraphSharingLink Link
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .Link;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .Link = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LinkApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkApplication = value;
            }
        }
        public string LinkScope
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkScope;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkScope = value;
            }
        }
        public string LinkType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkType = value;
            }
        }
        public string LinkWebUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkWebUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .LinkWebUrl = value;
            }
        }
        public string MicrosoftGraphIdentityDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .MicrosoftGraphIdentityDisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .MicrosoftGraphIdentityDisplayNameApplicationDisplayName = value;
            }
        }
        public string MicrosoftGraphIdentityIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .MicrosoftGraphIdentityIdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .MicrosoftGraphIdentityIdApplicationId = value;
            }
        }
        public string[] Roles
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .Roles;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .Roles = value;
            }
        }
        public string ShareId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .ShareId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .ShareId = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsListId = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsListItemId = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsListItemUniqueId = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsSiteId = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsSiteUrl = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .SharepointIdsWebId = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .UserDisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphPermissionAllof1 .UserIdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphPermissionAllof1 .UserIdUserId = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphPermission" /> instance.</summary>
        public MicrosoftGraphPermission()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphPermissionAllof1 ), _componentsSchemasMicrosoftGraphPermissionAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphPermissionAllof1 ), _componentsSchemasMicrosoftGraphPermissionAllof1 );
        }
    }
    public partial interface IMicrosoftGraphPermission : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphPermissionAllof1 {

    }
}