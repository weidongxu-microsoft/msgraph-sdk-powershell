namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>remoteItem</summary>
    public partial class MicrosoftGraphRemoteItem : Sample.API.Models.IMicrosoftGraphRemoteItem
    {
        public string ApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/Shared/*4*/.ApplicationDisplayNameApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.ApplicationDisplayNameApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationIdApplicationId
        {
            get
            {
                return /*1*/Shared/*4*/.ApplicationIdApplicationId/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.ApplicationIdApplicationId/*3*/ = value;
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
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser
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
        public string DeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/Shared/*4*/.DeviceDisplayNameDeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.DeviceDisplayNameDeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceIdDeviceId
        {
            get
            {
                return /*1*/Shared/*4*/.DeviceIdDeviceId/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.DeviceIdDeviceId/*3*/ = value;
            }
        }
        public string DisplayNameApplicationDisplayName
        {
            get
            {
                return /*1*/Shared/*4*/.DisplayNameApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.DisplayNameApplicationDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameDeviceDisplayName
        {
            get
            {
                return /*1*/Shared/*4*/.DisplayNameDeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.DisplayNameDeviceDisplayName/*3*/ = value;
            }
        }
        public string DisplayNameUserDisplayName
        {
            get
            {
                return /*1*/Shared/*4*/.DisplayNameUserDisplayName/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.DisplayNameUserDisplayName/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="File" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFile _file;

        /// <summary>file</summary>
        public Sample.API.Models.IMicrosoftGraphFile File
        {
            get
            {
                return this._file;
            }
            set
            {
                this._file = value;
            }
        }
        /// <summary>hashes</summary>
        public Sample.API.Models.IMicrosoftGraphHashes FileHashes
        {
            get
            {
                return /*1*/File/*4*/.Hashes/*3*/;
            }
            set
            {
                /*1*/File/*4*/.Hashes/*3*/ = value;
            }
        }
        public string FileMimeType
        {
            get
            {
                return /*1*/File/*4*/.MimeType/*3*/;
            }
            set
            {
                /*1*/File/*4*/.MimeType/*3*/ = value;
            }
        }
        public bool? FileProcessingMetadata
        {
            get
            {
                return /*1*/File/*4*/.ProcessingMetadata/*3*/;
            }
            set
            {
                /*1*/File/*4*/.ProcessingMetadata/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="FileSystemInfo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFileSystemInfo _fileSystemInfo;

        /// <summary>fileSystemInfo</summary>
        public Sample.API.Models.IMicrosoftGraphFileSystemInfo FileSystemInfo
        {
            get
            {
                return this._fileSystemInfo;
            }
            set
            {
                this._fileSystemInfo = value;
            }
        }
        public System.DateTime? FileSystemInfoCreatedDateTime
        {
            get
            {
                return /*1*/FileSystemInfo/*4*/.CreatedDateTime/*3*/;
            }
            set
            {
                /*1*/FileSystemInfo/*4*/.CreatedDateTime/*3*/ = value;
            }
        }
        public System.DateTime? FileSystemInfoLastAccessedDateTime
        {
            get
            {
                return /*1*/FileSystemInfo/*4*/.LastAccessedDateTime/*3*/;
            }
            set
            {
                /*1*/FileSystemInfo/*4*/.LastAccessedDateTime/*3*/ = value;
            }
        }
        public System.DateTime? FileSystemInfoLastModifiedDateTime
        {
            get
            {
                return /*1*/FileSystemInfo/*4*/.LastModifiedDateTime/*3*/;
            }
            set
            {
                /*1*/FileSystemInfo/*4*/.LastModifiedDateTime/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Folder" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphFolder _folder;

        /// <summary>folder</summary>
        public Sample.API.Models.IMicrosoftGraphFolder Folder
        {
            get
            {
                return this._folder;
            }
            set
            {
                this._folder = value;
            }
        }
        public int? FolderChildCount
        {
            get
            {
                return /*1*/Folder/*4*/.ChildCount/*3*/;
            }
            set
            {
                /*1*/Folder/*4*/.ChildCount/*3*/ = value;
            }
        }
        /// <summary>folderView</summary>
        public Sample.API.Models.IMicrosoftGraphFolderView FolderView
        {
            get
            {
                return /*1*/Folder/*4*/.View/*3*/;
            }
            set
            {
                /*1*/Folder/*4*/.View/*3*/ = value;
            }
        }
        public string HashesCrc32Hash
        {
            get
            {
                return /*1*/File/*4*/.HashesCrc32Hash/*3*/;
            }
            set
            {
                /*1*/File/*4*/.HashesCrc32Hash/*3*/ = value;
            }
        }
        public string HashesQuickXorHash
        {
            get
            {
                return /*1*/File/*4*/.HashesQuickXorHash/*3*/;
            }
            set
            {
                /*1*/File/*4*/.HashesQuickXorHash/*3*/ = value;
            }
        }
        public string HashesSha1Hash
        {
            get
            {
                return /*1*/File/*4*/.HashesSha1Hash/*3*/;
            }
            set
            {
                /*1*/File/*4*/.HashesSha1Hash/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string IdApplicationId
        {
            get
            {
                return /*1*/Shared/*4*/.IdApplicationId/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.IdApplicationId/*3*/ = value;
            }
        }
        public string IdDeviceId
        {
            get
            {
                return /*1*/Shared/*4*/.IdDeviceId/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.IdDeviceId/*3*/ = value;
            }
        }
        public string IdUserId
        {
            get
            {
                return /*1*/Shared/*4*/.IdUserId/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.IdUserId/*3*/ = value;
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
        public string LastModifiedByApplicationDisplayNameApplicationDisplayName1
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
        public string LastModifiedByApplicationIdApplicationId1
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
        public string LastModifiedByDeviceDisplayNameDeviceDisplayName1
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
        public string LastModifiedByDeviceIdDeviceId1
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
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser
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
        public string LastModifiedByUserDisplayNameUserDisplayName1
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
        public string LastModifiedByUserIdUserId1
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
        public string ListIdSharepointIdsListId
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
        public string ListItemIdSharepointIdsListItemId
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
        public string ListItemUniqueIdSharepointIdsListItemUniqueId
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
        public string MicrosoftGraphIdentityDisplayNameApplicationDisplayName
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
        public string MicrosoftGraphIdentityDisplayNameDeviceDisplayName
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
        public string MicrosoftGraphIdentityDisplayNameUserDisplayName
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
        public string MicrosoftGraphIdentityIdApplicationId
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
        public string MicrosoftGraphIdentityIdDeviceId
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
        public string MicrosoftGraphIdentityIdUserId
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
        public string MicrosoftGraphSharepointIdsListIdSharepointIdsListId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.ListId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.ListId/*3*/ = value;
            }
        }
        public string MicrosoftGraphSharepointIdsListItemIdSharepointIdsListItemId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.ListItemId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.ListItemId/*3*/ = value;
            }
        }
        public string MicrosoftGraphSharepointIdsListItemUniqueIdSharepointIdsListItemUniqueId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.ListItemUniqueId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.ListItemUniqueId/*3*/ = value;
            }
        }
        public string MicrosoftGraphSharepointIdsSiteIdSharepointIdsSiteId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.SiteId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.SiteId/*3*/ = value;
            }
        }
        public string MicrosoftGraphSharepointIdsSiteUrlSharepointIdsSiteUrl
        {
            get
            {
                return /*1*/SharepointIds/*4*/.SiteUrl/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.SiteUrl/*3*/ = value;
            }
        }
        public string MicrosoftGraphSharepointIdsWebIdSharepointIdsWebId
        {
            get
            {
                return /*1*/SharepointIds/*4*/.WebId/*3*/;
            }
            set
            {
                /*1*/SharepointIds/*4*/.WebId/*3*/ = value;
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
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication
        {
            get
            {
                return /*1*/Shared/*4*/.OwnerApplication/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.OwnerApplication/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice
        {
            get
            {
                return /*1*/Shared/*4*/.OwnerDevice/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.OwnerDevice/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerUser
        {
            get
            {
                return /*1*/Shared/*4*/.OwnerUser/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.OwnerUser/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Package" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPackage _package;

        /// <summary>package</summary>
        public Sample.API.Models.IMicrosoftGraphPackage Package
        {
            get
            {
                return this._package;
            }
            set
            {
                this._package = value;
            }
        }
        public string PackageType
        {
            get
            {
                return /*1*/Package/*4*/.Type/*3*/;
            }
            set
            {
                /*1*/Package/*4*/.Type/*3*/ = value;
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
        /// <summary>Backing field for <see cref="Shared" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphShared _shared;

        /// <summary>shared</summary>
        public Sample.API.Models.IMicrosoftGraphShared Shared
        {
            get
            {
                return this._shared;
            }
            set
            {
                this._shared = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet SharedBy
        {
            get
            {
                return /*1*/Shared/*4*/.SharedBy/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.SharedBy/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByApplication
        {
            get
            {
                return /*1*/Shared/*4*/.SharedByApplication/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.SharedByApplication/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByDevice
        {
            get
            {
                return /*1*/Shared/*4*/.SharedByDevice/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.SharedByDevice/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByUser
        {
            get
            {
                return /*1*/Shared/*4*/.SharedByUser/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.SharedByUser/*3*/ = value;
            }
        }
        public System.DateTime? SharedDateTime
        {
            get
            {
                return /*1*/Shared/*4*/.SharedDateTime/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.SharedDateTime/*3*/ = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet SharedOwner
        {
            get
            {
                return /*1*/Shared/*4*/.Owner/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.Owner/*3*/ = value;
            }
        }
        public string SharedScope
        {
            get
            {
                return /*1*/Shared/*4*/.Scope/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.Scope/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SharepointIds" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharepointIds _sharepointIds;

        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds
        {
            get
            {
                return this._sharepointIds;
            }
            set
            {
                this._sharepointIds = value;
            }
        }
        public string SiteIdSharepointIdsSiteId
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
        public string SiteUrlSharepointIdsSiteUrl
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
        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private long? _size;

        public long? Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        /// <summary>Backing field for <see cref="SpecialFolder" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSpecialFolder _specialFolder;

        /// <summary>specialFolder</summary>
        public Sample.API.Models.IMicrosoftGraphSpecialFolder SpecialFolder
        {
            get
            {
                return this._specialFolder;
            }
            set
            {
                this._specialFolder = value;
            }
        }
        public string SpecialFolderName
        {
            get
            {
                return /*1*/SpecialFolder/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/SpecialFolder/*4*/.Name/*3*/ = value;
            }
        }
        public string UserDisplayNameUserDisplayName
        {
            get
            {
                return /*1*/Shared/*4*/.UserDisplayNameUserDisplayName/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.UserDisplayNameUserDisplayName/*3*/ = value;
            }
        }
        public string UserIdUserId
        {
            get
            {
                return /*1*/Shared/*4*/.UserIdUserId/*3*/;
            }
            set
            {
                /*1*/Shared/*4*/.UserIdUserId/*3*/ = value;
            }
        }
        public string ViewSortBy
        {
            get
            {
                return /*1*/Folder/*4*/.ViewSortBy/*3*/;
            }
            set
            {
                /*1*/Folder/*4*/.ViewSortBy/*3*/ = value;
            }
        }
        public string ViewSortOrder
        {
            get
            {
                return /*1*/Folder/*4*/.ViewSortOrder/*3*/;
            }
            set
            {
                /*1*/Folder/*4*/.ViewSortOrder/*3*/ = value;
            }
        }
        public string ViewType
        {
            get
            {
                return /*1*/Folder/*4*/.ViewType/*3*/;
            }
            set
            {
                /*1*/Folder/*4*/.ViewType/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="WebDavUrl" /> property.</summary>
        private string _webDavUrl;

        public string WebDavUrl
        {
            get
            {
                return this._webDavUrl;
            }
            set
            {
                this._webDavUrl = value;
            }
        }
        public string WebIdSharepointIdsWebId
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
        /// <summary>Creates an new <see cref="MicrosoftGraphRemoteItem" /> instance.</summary>
        public MicrosoftGraphRemoteItem()
        {
        }
    }
    /// remoteItem
    public partial interface IMicrosoftGraphRemoteItem : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet CreatedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity CreatedByUser { get; set; }
        System.DateTime? CreatedDateTime { get; set; }
        string DeviceDisplayNameDeviceDisplayName { get; set; }
        string DeviceIdDeviceId { get; set; }
        string DisplayNameApplicationDisplayName { get; set; }
        string DisplayNameDeviceDisplayName { get; set; }
        string DisplayNameUserDisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphFile File { get; set; }
        Sample.API.Models.IMicrosoftGraphHashes FileHashes { get; set; }
        string FileMimeType { get; set; }
        bool? FileProcessingMetadata { get; set; }
        Sample.API.Models.IMicrosoftGraphFileSystemInfo FileSystemInfo { get; set; }
        System.DateTime? FileSystemInfoCreatedDateTime { get; set; }
        System.DateTime? FileSystemInfoLastAccessedDateTime { get; set; }
        System.DateTime? FileSystemInfoLastModifiedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphFolder Folder { get; set; }
        int? FolderChildCount { get; set; }
        Sample.API.Models.IMicrosoftGraphFolderView FolderView { get; set; }
        string HashesCrc32Hash { get; set; }
        string HashesQuickXorHash { get; set; }
        string HashesSha1Hash { get; set; }
        string Id { get; set; }
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet LastModifiedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByApplication { get; set; }
        string LastModifiedByApplicationDisplayNameApplicationDisplayName1 { get; set; }
        string LastModifiedByApplicationIdApplicationId1 { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByDevice { get; set; }
        string LastModifiedByDeviceDisplayNameDeviceDisplayName1 { get; set; }
        string LastModifiedByDeviceIdDeviceId1 { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity LastModifiedByUser { get; set; }
        string LastModifiedByUserDisplayNameUserDisplayName1 { get; set; }
        string LastModifiedByUserIdUserId1 { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string ListIdSharepointIdsListId { get; set; }
        string ListItemIdSharepointIdsListItemId { get; set; }
        string ListItemUniqueIdSharepointIdsListItemUniqueId { get; set; }
        string MicrosoftGraphIdentityDisplayNameApplicationDisplayName { get; set; }
        string MicrosoftGraphIdentityDisplayNameDeviceDisplayName { get; set; }
        string MicrosoftGraphIdentityDisplayNameUserDisplayName { get; set; }
        string MicrosoftGraphIdentityIdApplicationId { get; set; }
        string MicrosoftGraphIdentityIdDeviceId { get; set; }
        string MicrosoftGraphIdentityIdUserId { get; set; }
        string MicrosoftGraphSharepointIdsListIdSharepointIdsListId { get; set; }
        string MicrosoftGraphSharepointIdsListItemIdSharepointIdsListItemId { get; set; }
        string MicrosoftGraphSharepointIdsListItemUniqueIdSharepointIdsListItemUniqueId { get; set; }
        string MicrosoftGraphSharepointIdsSiteIdSharepointIdsSiteId { get; set; }
        string MicrosoftGraphSharepointIdsSiteUrlSharepointIdsSiteUrl { get; set; }
        string MicrosoftGraphSharepointIdsWebIdSharepointIdsWebId { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerUser { get; set; }
        Sample.API.Models.IMicrosoftGraphPackage Package { get; set; }
        string PackageType { get; set; }
        Sample.API.Models.IMicrosoftGraphItemReference ParentReference { get; set; }
        string ParentReferenceDriveId { get; set; }
        string ParentReferenceDriveType { get; set; }
        string ParentReferenceId { get; set; }
        string ParentReferenceName { get; set; }
        string ParentReferencePath { get; set; }
        string ParentReferenceShareId { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds ParentReferenceSharepointIds { get; set; }
        Sample.API.Models.IMicrosoftGraphShared Shared { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet SharedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByUser { get; set; }
        System.DateTime? SharedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet SharedOwner { get; set; }
        string SharedScope { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds { get; set; }
        string SiteIdSharepointIdsSiteId { get; set; }
        string SiteUrlSharepointIdsSiteUrl { get; set; }
        long? Size { get; set; }
        Sample.API.Models.IMicrosoftGraphSpecialFolder SpecialFolder { get; set; }
        string SpecialFolderName { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
        string ViewSortBy { get; set; }
        string ViewSortOrder { get; set; }
        string ViewType { get; set; }
        string WebDavUrl { get; set; }
        string WebIdSharepointIdsWebId { get; set; }
        string WebUrl { get; set; }
    }
}