namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>permission</summary>
    public partial class ComponentsSchemasMicrosoftGraphPermissionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphPermissionAllof1
    {
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/Invitation/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return /*1*/Invitation/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/Invitation/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return /*1*/Invitation/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/GrantedTo/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/GrantedTo/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return /*1*/GrantedTo/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="GrantedTo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _grantedTo;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet GrantedTo
        {
            get
            {
                return this._grantedTo;
            }
            set
            {
                this._grantedTo = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity GrantedToApplication
        {
            get
            {
                return /*1*/GrantedTo/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity GrantedToDevice
        {
            get
            {
                return /*1*/GrantedTo/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity GrantedToUser
        {
            get
            {
                return /*1*/GrantedTo/*4*/.User/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.User/*3*/ = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return /*1*/GrantedTo/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return /*1*/GrantedTo/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return /*1*/GrantedTo/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/GrantedTo/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="InheritedFrom" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphItemReference _inheritedFrom;

        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference InheritedFrom
        {
            get
            {
                return this._inheritedFrom;
            }
            set
            {
                this._inheritedFrom = value;
            }
        }
        public string InheritedFromDriveId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.DriveId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.DriveId/*3*/ = value;
            }
        }
        public string InheritedFromDriveType
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.DriveType/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.DriveType/*3*/ = value;
            }
        }
        public string InheritedFromId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.Id/*3*/ = value;
            }
        }
        public string InheritedFromName
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.Name/*3*/ = value;
            }
        }
        public string InheritedFromPath
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.Path/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.Path/*3*/ = value;
            }
        }
        public string InheritedFromShareId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.ShareId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.ShareId/*3*/ = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds InheritedFromSharepointIds
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIds/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIds/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Invitation" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharingInvitation _invitation;

        /// <summary>sharingInvitation</summary>
        public Sample.API.Models.IMicrosoftGraphSharingInvitation Invitation
        {
            get
            {
                return this._invitation;
            }
            set
            {
                this._invitation = value;
            }
        }
        public string InvitationEmail
        {
            get
            {
                return /*1*/Invitation/*4*/.Email/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.Email/*3*/ = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet InvitationInvitedBy
        {
            get
            {
                return /*1*/Invitation/*4*/.InvitedBy/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.InvitedBy/*3*/ = value;
            }
        }
        public string InvitationRedeemedBy
        {
            get
            {
                return /*1*/Invitation/*4*/.RedeemedBy/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.RedeemedBy/*3*/ = value;
            }
        }
        public bool? InvitationSignInRequired
        {
            get
            {
                return /*1*/Invitation/*4*/.SignInRequired/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.SignInRequired/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByApplication
        {
            get
            {
                return /*1*/Invitation/*4*/.InvitedByApplication/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.InvitedByApplication/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByDevice
        {
            get
            {
                return /*1*/Invitation/*4*/.InvitedByDevice/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.InvitedByDevice/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity InvitedByUser
        {
            get
            {
                return /*1*/Invitation/*4*/.InvitedByUser/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.InvitedByUser/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Link" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharingLink _link;

        /// <summary>sharingLink</summary>
        public Sample.API.Models.IMicrosoftGraphSharingLink Link
        {
            get
            {
                return this._link;
            }
            set
            {
                this._link = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LinkApplication
        {
            get
            {
                return /*1*/Link/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/Link/*4*/.Application/*3*/ = value;
            }
        }
        public string LinkScope
        {
            get
            {
                return /*1*/Link/*4*/.Scope/*3*/;
            }
            set
            {
                /*1*/Link/*4*/.Scope/*3*/ = value;
            }
        }
        public string LinkType
        {
            get
            {
                return /*1*/Link/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/Link/*4*/.Type/*3*/ = value;
            }
        }
        public string LinkWebUrl
        {
            get
            {
                return /*1*/Link/*4*/.WebUrl/*3*/;
            }
            set
            {
                /*1*/Link/*4*/.WebUrl/*3*/ = value;
            }
        }
        public string MicrosoftGraphIdentityDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/Link/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/Link/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string MicrosoftGraphIdentityIdApplicationId
        {
            get
            {
                return /*1*/Link/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/Link/*4*/.ApplicationId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Roles" /> property.</summary>
        private string[] _roles;

        public string[] Roles
        {
            get
            {
                return this._roles;
            }
            set
            {
                this._roles = value;
            }
        }
        /// <summary>Backing field for <see cref="ShareId" /> property.</summary>
        private string _shareId;

        public string ShareId
        {
            get
            {
                return this._shareId;
            }
            set
            {
                this._shareId = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsListId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsListId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsListItemId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsListItemId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsListItemUniqueId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsListItemUniqueId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsSiteId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsSiteId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsSiteUrl/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsSiteUrl/*3*/ = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return /*1*/InheritedFrom/*4*/.SharepointIdsWebId/*3*/;
            }
            set
            {
                /*1*/InheritedFrom/*4*/.SharepointIdsWebId/*3*/ = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return /*1*/Invitation/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return /*1*/Invitation/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/Invitation/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphPermissionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphPermissionAllof1()
        {
        }
    }
    /// permission
    public partial interface IComponentsSchemasMicrosoftGraphPermissionAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        string DeviceDisplayNameDeviceDisplayName { get; set; }
        string DeviceIdDeviceId { get; set; }
        string DisplayNameApplicationDisplayName { get; set; }
        string DisplayNameDeviceDisplayName { get; set; }
        string DisplayNameUserDisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet GrantedTo { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity GrantedToApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity GrantedToDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity GrantedToUser { get; set; }
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphItemReference InheritedFrom { get; set; }
        string InheritedFromDriveId { get; set; }
        string InheritedFromDriveType { get; set; }
        string InheritedFromId { get; set; }
        string InheritedFromName { get; set; }
        string InheritedFromPath { get; set; }
        string InheritedFromShareId { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds InheritedFromSharepointIds { get; set; }
        Sample.API.Models.IMicrosoftGraphSharingInvitation Invitation { get; set; }
        string InvitationEmail { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet InvitationInvitedBy { get; set; }
        string InvitationRedeemedBy { get; set; }
        bool? InvitationSignInRequired { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity InvitedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity InvitedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity InvitedByUser { get; set; }
        Sample.API.Models.IMicrosoftGraphSharingLink Link { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LinkApplication { get; set; }
        string LinkScope { get; set; }
        string LinkType { get; set; }
        string LinkWebUrl { get; set; }
        string MicrosoftGraphIdentityDisplayNameApplicationDisplayName { get; set; }
        string MicrosoftGraphIdentityIdApplicationId { get; set; }
        string[] Roles { get; set; }
        string ShareId { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
    }
}