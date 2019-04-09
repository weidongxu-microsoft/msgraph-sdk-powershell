namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>baseItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphBaseitemAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphBaseitemAllof1
    {
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _createdBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy
        {
            get
            {
                return this._createdBy;
            }
            set
            {
                this._createdBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication
        {
            get
            {
                return /*1*/CreatedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice
        {
            get
            {
                return /*1*/CreatedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedByUser" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUser _createdByUser;

        public Sample.API.Models.IMicrosoftGraphUser CreatedByUser
        {
            get
            {
                return this._createdByUser;
            }
            set
            {
                this._createdByUser = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

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
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return /*1*/CreatedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        public string ETag
        {
            get
            {
                return this._eTag;
            }
            set
            {
                this._eTag = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.DeviceId/*3*/ = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return /*1*/CreatedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedBy" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _lastModifiedBy;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy
        {
            get
            {
                return this._lastModifiedBy;
            }
            set
            {
                this._lastModifiedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedByUser" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphUser _lastModifiedByUser;

        public Sample.API.Models.IMicrosoftGraphUser LastModifiedByUser
        {
            get
            {
                return this._lastModifiedByUser;
            }
            set
            {
                this._lastModifiedByUser = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private System.DateTime? _lastModifiedDateTime;

        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return this._lastModifiedDateTime;
            }
            set
            {
                this._lastModifiedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentReference" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphItemReference _parentReference;

        /// <summary>itemReference</summary>
        public Sample.API.Models.IMicrosoftGraphItemReference ParentReference
        {
            get
            {
                return this._parentReference;
            }
            set
            {
                this._parentReference = value;
            }
        }
        public string ParentReferenceDriveId
        {
            get
            {
                return /*1*/ParentReference/*4*/.DriveId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.DriveId/*3*/ = value;
            }
        }
        public string ParentReferenceDriveType
        {
            get
            {
                return /*1*/ParentReference/*4*/.DriveType/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.DriveType/*3*/ = value;
            }
        }
        public string ParentReferenceId
        {
            get
            {
                return /*1*/ParentReference/*4*/.Id/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.Id/*3*/ = value;
            }
        }
        public string ParentReferenceName
        {
            get
            {
                return /*1*/ParentReference/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.Name/*3*/ = value;
            }
        }
        public string ParentReferencePath
        {
            get
            {
                return /*1*/ParentReference/*4*/.Path/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.Path/*3*/ = value;
            }
        }
        public string ParentReferenceShareId
        {
            get
            {
                return /*1*/ParentReference/*4*/.ShareId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.ShareId/*3*/ = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds ParentReferenceSharepointIds
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIds/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIds/*3*/ = value;
            }
        }
        public string SharepointIdsListId
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIdsListId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIdsListId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemId
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIdsListItemId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIdsListItemId/*3*/ = value;
            }
        }
        public string SharepointIdsListItemUniqueId
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIdsListItemUniqueId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIdsListItemUniqueId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteId
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIdsSiteId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIdsSiteId/*3*/ = value;
            }
        }
        public string SharepointIdsSiteUrl
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIdsSiteUrl/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIdsSiteUrl/*3*/ = value;
            }
        }
        public string SharepointIdsWebId
        {
            get
            {
                return /*1*/ParentReference/*4*/.SharepointIdsWebId/*3*/;
            }
            set
            {
                /*1*/ParentReference/*4*/.SharepointIdsWebId/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity UserCreatedByUser
        {
            get
            {
                return /*1*/CreatedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/CreatedBy/*4*/.User/*3*/ = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity UserLastModifiedByUser
        {
            get
            {
                return /*1*/LastModifiedBy/*4*/.User/*3*/;
            }
            set
            {
                /*1*/LastModifiedBy/*4*/.User/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        public string WebUrl
        {
            get
            {
                return this._webUrl;
            }
            set
            {
                this._webUrl = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphBaseitemAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphBaseitemAllof1()
        {
        }
    }
    /// baseItem
    public partial interface IComponentsSchemasMicrosoftGraphBaseitemAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphUser CreatedByUser { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        string Description { get; set; }
        string DeviceDisplayNameDeviceDisplayName { get; set; }
        string DeviceIdDeviceId { get; set; }
        string DisplayNameApplicationDisplayName { get; set; }
        string DisplayNameDeviceDisplayName { get; set; }
        string DisplayNameUserDisplayName { get; set; }
        string ETag { get; set; }
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphUser LastModifiedByUser { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphItemReference ParentReference { get; set; }
        string ParentReferenceDriveId { get; set; }
        string ParentReferenceDriveType { get; set; }
        string ParentReferenceId { get; set; }
        string ParentReferenceName { get; set; }
        string ParentReferencePath { get; set; }
        string ParentReferenceShareId { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds ParentReferenceSharepointIds { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity UserCreatedByUser { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity UserLastModifiedByUser { get; set; }
        string WebUrl { get; set; }
    }
}