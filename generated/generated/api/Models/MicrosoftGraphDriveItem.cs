namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDriveItem : Sample.API.Models.IMicrosoftGraphDriveItem, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDriveItem" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemAllof1 _componentsSchemasMicrosoftGraphDriveitemAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDriveitemAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDriveItem" /></summary>
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
        public string ApplicationDisplayNameApplicationDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ApplicationDisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ApplicationDisplayNameApplicationDisplayName = value;
            }
        }
        public string ApplicationDisplayNameDisplayNameApplicationDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .DisplayNameApplicationDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .DisplayNameApplicationDisplayName = value;
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
        public string ApplicationIdApplicationIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ApplicationIdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ApplicationIdApplicationId = value;
            }
        }
        public string ApplicationIdIdApplicationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .IdApplicationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .IdApplicationId = value;
            }
        }
        /// <summary>audio</summary>
        public Sample.API.Models.IMicrosoftGraphAudio Audio
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Audio;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Audio = value;
            }
        }
        public string AudioAlbum
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioAlbum;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioAlbum = value;
            }
        }
        public string AudioAlbumArtist
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioAlbumArtist;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioAlbumArtist = value;
            }
        }
        public string AudioArtist
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioArtist;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioArtist = value;
            }
        }
        public long? AudioBitrate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioBitrate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioBitrate = value;
            }
        }
        public string AudioComposers
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioComposers;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioComposers = value;
            }
        }
        public string AudioCopyright
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioCopyright;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioCopyright = value;
            }
        }
        public int? AudioDisc
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioDisc;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioDisc = value;
            }
        }
        public int? AudioDiscCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioDiscCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioDiscCount = value;
            }
        }
        public long? AudioDuration
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioDuration;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioDuration = value;
            }
        }
        public string AudioGenre
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioGenre;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioGenre = value;
            }
        }
        public bool? AudioHasDrm
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioHasDrm;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioHasDrm = value;
            }
        }
        public bool? AudioIsVariableBitrate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioIsVariableBitrate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioIsVariableBitrate = value;
            }
        }
        public string AudioTitle
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioTitle;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioTitle = value;
            }
        }
        public int? AudioTrack
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioTrack;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioTrack = value;
            }
        }
        public int? AudioTrackCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioTrackCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioTrackCount = value;
            }
        }
        public int? AudioYear
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioYear;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .AudioYear = value;
            }
        }
        public string CTag
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .CTag;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .CTag = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphDriveItem[] Children
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Children;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Children = value;
            }
        }
        public byte[] Content
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Content;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Content = value;
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
        /// <summary>deleted</summary>
        public Sample.API.Models.IMicrosoftGraphDeleted Deleted
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Deleted;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Deleted = value;
            }
        }
        public string DeletedState
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .DeletedState;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .DeletedState = value;
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
        public string DeviceDisplayNameDeviceDisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .DeviceDisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .DeviceDisplayNameDeviceDisplayName = value;
            }
        }
        public string DeviceDisplayNameDisplayNameDeviceDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .DisplayNameDeviceDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .DisplayNameDeviceDisplayName = value;
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
        public string DeviceIdDeviceIdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .DeviceIdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .DeviceIdDeviceId = value;
            }
        }
        public string DeviceIdIdDeviceId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .IdDeviceId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .IdDeviceId = value;
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
        /// <summary>file</summary>
        public Sample.API.Models.IMicrosoftGraphFile File
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .File;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .File = value;
            }
        }
        /// <summary>hashes</summary>
        public Sample.API.Models.IMicrosoftGraphHashes FileHashes
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileHashes;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileHashes = value;
            }
        }
        public string FileMimeType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileMimeType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileMimeType = value;
            }
        }
        public bool? FileProcessingMetadata
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileProcessingMetadata;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileProcessingMetadata = value;
            }
        }
        /// <summary>fileSystemInfo</summary>
        public Sample.API.Models.IMicrosoftGraphFileSystemInfo FileSystemInfo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfo = value;
            }
        }
        public System.DateTime? FileSystemInfoCreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfoCreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfoCreatedDateTime = value;
            }
        }
        public System.DateTime? FileSystemInfoLastAccessedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfoLastAccessedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfoLastAccessedDateTime = value;
            }
        }
        public System.DateTime? FileSystemInfoLastModifiedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfoLastModifiedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FileSystemInfoLastModifiedDateTime = value;
            }
        }
        /// <summary>folder</summary>
        public Sample.API.Models.IMicrosoftGraphFolder Folder
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Folder;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Folder = value;
            }
        }
        public int? FolderChildCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FolderChildCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FolderChildCount = value;
            }
        }
        /// <summary>folderView</summary>
        public Sample.API.Models.IMicrosoftGraphFolderView FolderView
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .FolderView;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .FolderView = value;
            }
        }
        public string HashesCrc32Hash
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .HashesCrc32Hash;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .HashesCrc32Hash = value;
            }
        }
        public string HashesQuickXorHash
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .HashesQuickXorHash;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .HashesQuickXorHash = value;
            }
        }
        public string HashesSha1Hash
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .HashesSha1Hash;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .HashesSha1Hash = value;
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
        /// <summary>image</summary>
        public Sample.API.Models.IMicrosoftGraphImage Image
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Image;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Image = value;
            }
        }
        public int? ImageHeight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ImageHeight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ImageHeight = value;
            }
        }
        public int? ImageWidth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ImageWidth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ImageWidth = value;
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
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsListId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsListId = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphListItem ListItem
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ListItem;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ListItem = value;
            }
        }
        public string ListItemIdSharepointIdsListItemId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsListItemId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsListItemId = value;
            }
        }
        public string ListItemUniqueIdSharepointIdsListItemUniqueId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsListItemUniqueId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsListItemUniqueId = value;
            }
        }
        /// <summary>geoCoordinates</summary>
        public Sample.API.Models.IMicrosoftGraphGeoCoordinates Location
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Location;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Location = value;
            }
        }
        public double? LocationAltitude
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .LocationAltitude;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .LocationAltitude = value;
            }
        }
        public double? LocationLatitude
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .LocationLatitude;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .LocationLatitude = value;
            }
        }
        public double? LocationLongitude
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .LocationLongitude;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .LocationLongitude = value;
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
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .OwnerApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .OwnerApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .OwnerDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .OwnerDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .OwnerUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .OwnerUser = value;
            }
        }
        /// <summary>package</summary>
        public Sample.API.Models.IMicrosoftGraphPackage Package
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Package;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Package = value;
            }
        }
        public string PackageType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PackageType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PackageType = value;
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
        public Sample.API.Models.IMicrosoftGraphPermission[] Permissions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Permissions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Permissions = value;
            }
        }
        /// <summary>photo</summary>
        public Sample.API.Models.IMicrosoftGraphPhoto Photo
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Photo;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Photo = value;
            }
        }
        public string PhotoCameraMake
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoCameraMake;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoCameraMake = value;
            }
        }
        public string PhotoCameraModel
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoCameraModel;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoCameraModel = value;
            }
        }
        public double? PhotoExposureDenominator
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoExposureDenominator;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoExposureDenominator = value;
            }
        }
        public double? PhotoExposureNumerator
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoExposureNumerator;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoExposureNumerator = value;
            }
        }
        public double? PhotoFNumber
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoFNumber;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoFNumber = value;
            }
        }
        public double? PhotoFocalLength
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoFocalLength;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoFocalLength = value;
            }
        }
        public int? PhotoIso
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoIso;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoIso = value;
            }
        }
        public System.DateTime? PhotoTakenDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoTakenDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PhotoTakenDateTime = value;
            }
        }
        /// <summary>publicationFacet</summary>
        public Sample.API.Models.IMicrosoftGraphPublicationFacet Publication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Publication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Publication = value;
            }
        }
        public string PublicationLevel
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PublicationLevel;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PublicationLevel = value;
            }
        }
        public string PublicationVersionId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .PublicationVersionId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .PublicationVersionId = value;
            }
        }
        /// <summary>remoteItem</summary>
        public Sample.API.Models.IMicrosoftGraphRemoteItem RemoteItem
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .RemoteItem;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .RemoteItem = value;
            }
        }
        /// <summary>root</summary>
        public Sample.API.Models.IMicrosoftGraphRoot Root
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Root;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Root = value;
            }
        }
        /// <summary>searchResult</summary>
        public Sample.API.Models.IMicrosoftGraphSearchResult SearchResult
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SearchResult;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SearchResult = value;
            }
        }
        public string SearchResultOnClickTelemetryUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SearchResultOnClickTelemetryUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SearchResultOnClickTelemetryUrl = value;
            }
        }
        /// <summary>shared</summary>
        public Sample.API.Models.IMicrosoftGraphShared Shared
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Shared;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Shared = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet SharedBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedBy = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByApplication
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedByApplication;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedByApplication = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByDevice
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedByDevice;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedByDevice = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity SharedByUser
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedByUser;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedByUser = value;
            }
        }
        public System.DateTime? SharedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedDateTime = value;
            }
        }
        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet SharedOwner
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedOwner;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedOwner = value;
            }
        }
        public string SharedScope
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedScope;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharedScope = value;
            }
        }
        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIds;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIds = value;
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
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsSiteId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsSiteId = value;
            }
        }
        public string SiteUrlSharepointIdsSiteUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsSiteUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsSiteUrl = value;
            }
        }
        public long? Size
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Size;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Size = value;
            }
        }
        /// <summary>specialFolder</summary>
        public Sample.API.Models.IMicrosoftGraphSpecialFolder SpecialFolder
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SpecialFolder;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SpecialFolder = value;
            }
        }
        public string SpecialFolderName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SpecialFolderName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SpecialFolderName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphThumbnailSet[] Thumbnails
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Thumbnails;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Thumbnails = value;
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
        public string UserDisplayNameDisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .DisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .DisplayNameUserDisplayName = value;
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
        public string UserDisplayNameUserDisplayNameUserDisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .UserDisplayNameUserDisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .UserDisplayNameUserDisplayName = value;
            }
        }
        public string UserIdIdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .IdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .IdUserId = value;
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
        public string UserIdUserIdUserId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .UserIdUserId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .UserIdUserId = value;
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
        public Sample.API.Models.IMicrosoftGraphDriveItemVersion[] Versions
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Versions;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Versions = value;
            }
        }
        /// <summary>video</summary>
        public Sample.API.Models.IMicrosoftGraphVideo Video
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Video;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Video = value;
            }
        }
        public int? VideoAudioBitsPerSample
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioBitsPerSample;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioBitsPerSample = value;
            }
        }
        public int? VideoAudioChannels
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioChannels;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioChannels = value;
            }
        }
        public string VideoAudioFormat
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioFormat;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioFormat = value;
            }
        }
        public int? VideoAudioSamplesPerSecond
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioSamplesPerSecond;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoAudioSamplesPerSecond = value;
            }
        }
        public int? VideoBitrate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoBitrate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoBitrate = value;
            }
        }
        public long? VideoDuration
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoDuration;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoDuration = value;
            }
        }
        public string VideoFourCC
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoFourCC;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoFourCC = value;
            }
        }
        public double? VideoFrameRate
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoFrameRate;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoFrameRate = value;
            }
        }
        public int? VideoHeight
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoHeight;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoHeight = value;
            }
        }
        public int? VideoWidth
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoWidth;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .VideoWidth = value;
            }
        }
        public string ViewSortBy
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ViewSortBy;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ViewSortBy = value;
            }
        }
        public string ViewSortOrder
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ViewSortOrder;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ViewSortOrder = value;
            }
        }
        public string ViewType
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .ViewType;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .ViewType = value;
            }
        }
        public string WebDavUrl
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .WebDavUrl;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .WebDavUrl = value;
            }
        }
        public string WebIdSharepointIdsWebId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsWebId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .SharepointIdsWebId = value;
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
        public Sample.API.Models.IMicrosoftGraphWorkbook Workbook
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDriveitemAllof1 .Workbook;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDriveitemAllof1 .Workbook = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDriveItem" /> instance.</summary>
        public MicrosoftGraphDriveItem()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDriveitemAllof1 ), _componentsSchemasMicrosoftGraphDriveitemAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDriveitemAllof1 ), _componentsSchemasMicrosoftGraphDriveitemAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDriveItem : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphBaseItem, Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemAllof1 {

    }
}