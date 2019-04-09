namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>driveItem</summary>
    public partial class ComponentsSchemasMicrosoftGraphDriveitemAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemAllof1
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
        /// <summary>Backing field for <see cref="Audio" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphAudio _audio;

        /// <summary>audio</summary>
        public Sample.API.Models.IMicrosoftGraphAudio Audio
        {
            get
            {
                return this._audio;
            }
            set
            {
                this._audio = value;
            }
        }
        public string AudioAlbum
        {
            get
            {
                return /*1*/Audio/*4*/.Album/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Album/*3*/ = value;
            }
        }
        public string AudioAlbumArtist
        {
            get
            {
                return /*1*/Audio/*4*/.AlbumArtist/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.AlbumArtist/*3*/ = value;
            }
        }
        public string AudioArtist
        {
            get
            {
                return /*1*/Audio/*4*/.Artist/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Artist/*3*/ = value;
            }
        }
        public long? AudioBitrate
        {
            get
            {
                return /*1*/Audio/*4*/.Bitrate/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Bitrate/*3*/ = value;
            }
        }
        public string AudioComposers
        {
            get
            {
                return /*1*/Audio/*4*/.Composers/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Composers/*3*/ = value;
            }
        }
        public string AudioCopyright
        {
            get
            {
                return /*1*/Audio/*4*/.Copyright/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Copyright/*3*/ = value;
            }
        }
        public int? AudioDisc
        {
            get
            {
                return /*1*/Audio/*4*/.Disc/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Disc/*3*/ = value;
            }
        }
        public int? AudioDiscCount
        {
            get
            {
                return /*1*/Audio/*4*/.DiscCount/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.DiscCount/*3*/ = value;
            }
        }
        public long? AudioDuration
        {
            get
            {
                return /*1*/Audio/*4*/.Duration/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Duration/*3*/ = value;
            }
        }
        public string AudioGenre
        {
            get
            {
                return /*1*/Audio/*4*/.Genre/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Genre/*3*/ = value;
            }
        }
        public bool? AudioHasDrm
        {
            get
            {
                return /*1*/Audio/*4*/.HasDrm/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.HasDrm/*3*/ = value;
            }
        }
        public bool? AudioIsVariableBitrate
        {
            get
            {
                return /*1*/Audio/*4*/.IsVariableBitrate/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.IsVariableBitrate/*3*/ = value;
            }
        }
        public string AudioTitle
        {
            get
            {
                return /*1*/Audio/*4*/.Title/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Title/*3*/ = value;
            }
        }
        public int? AudioTrack
        {
            get
            {
                return /*1*/Audio/*4*/.Track/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Track/*3*/ = value;
            }
        }
        public int? AudioTrackCount
        {
            get
            {
                return /*1*/Audio/*4*/.TrackCount/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.TrackCount/*3*/ = value;
            }
        }
        public int? AudioYear
        {
            get
            {
                return /*1*/Audio/*4*/.Year/*3*/;
            }
            set
            {
                /*1*/Audio/*4*/.Year/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="CTag" /> property.</summary>
        private string _cTag;

        public string CTag
        {
            get
            {
                return this._cTag;
            }
            set
            {
                this._cTag = value;
            }
        }
        /// <summary>Backing field for <see cref="Children" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDriveItem[] _children;

        public Sample.API.Models.IMicrosoftGraphDriveItem[] Children
        {
            get
            {
                return this._children;
            }
            set
            {
                this._children = value;
            }
        }
        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private byte[] _content;

        public byte[] Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }
        /// <summary>Backing field for <see cref="Deleted" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDeleted _deleted;

        /// <summary>deleted</summary>
        public Sample.API.Models.IMicrosoftGraphDeleted Deleted
        {
            get
            {
                return this._deleted;
            }
            set
            {
                this._deleted = value;
            }
        }
        public string DeletedState
        {
            get
            {
                return /*1*/Deleted/*4*/.State/*3*/;
            }
            set
            {
                /*1*/Deleted/*4*/.State/*3*/ = value;
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
        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphImage _image;

        /// <summary>image</summary>
        public Sample.API.Models.IMicrosoftGraphImage Image
        {
            get
            {
                return this._image;
            }
            set
            {
                this._image = value;
            }
        }
        public int? ImageHeight
        {
            get
            {
                return /*1*/Image/*4*/.Height/*3*/;
            }
            set
            {
                /*1*/Image/*4*/.Height/*3*/ = value;
            }
        }
        public int? ImageWidth
        {
            get
            {
                return /*1*/Image/*4*/.Width/*3*/;
            }
            set
            {
                /*1*/Image/*4*/.Width/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="ListItem" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphListItem _listItem;

        public Sample.API.Models.IMicrosoftGraphListItem ListItem
        {
            get
            {
                return this._listItem;
            }
            set
            {
                this._listItem = value;
            }
        }
        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphGeoCoordinates _location;

        /// <summary>geoCoordinates</summary>
        public Sample.API.Models.IMicrosoftGraphGeoCoordinates Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        public double? LocationAltitude
        {
            get
            {
                return /*1*/Location/*4*/.Altitude/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.Altitude/*3*/ = value;
            }
        }
        public double? LocationLatitude
        {
            get
            {
                return /*1*/Location/*4*/.Latitude/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.Latitude/*3*/ = value;
            }
        }
        public double? LocationLongitude
        {
            get
            {
                return /*1*/Location/*4*/.Longitude/*3*/;
            }
            set
            {
                /*1*/Location/*4*/.Longitude/*3*/ = value;
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
        /// <summary>Backing field for <see cref="Permissions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPermission[] _permissions;

        public Sample.API.Models.IMicrosoftGraphPermission[] Permissions
        {
            get
            {
                return this._permissions;
            }
            set
            {
                this._permissions = value;
            }
        }
        /// <summary>Backing field for <see cref="Photo" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPhoto _photo;

        /// <summary>photo</summary>
        public Sample.API.Models.IMicrosoftGraphPhoto Photo
        {
            get
            {
                return this._photo;
            }
            set
            {
                this._photo = value;
            }
        }
        public string PhotoCameraMake
        {
            get
            {
                return /*1*/Photo/*4*/.CameraMake/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.CameraMake/*3*/ = value;
            }
        }
        public string PhotoCameraModel
        {
            get
            {
                return /*1*/Photo/*4*/.CameraModel/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.CameraModel/*3*/ = value;
            }
        }
        public double? PhotoExposureDenominator
        {
            get
            {
                return /*1*/Photo/*4*/.ExposureDenominator/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.ExposureDenominator/*3*/ = value;
            }
        }
        public double? PhotoExposureNumerator
        {
            get
            {
                return /*1*/Photo/*4*/.ExposureNumerator/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.ExposureNumerator/*3*/ = value;
            }
        }
        public double? PhotoFNumber
        {
            get
            {
                return /*1*/Photo/*4*/.FNumber/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.FNumber/*3*/ = value;
            }
        }
        public double? PhotoFocalLength
        {
            get
            {
                return /*1*/Photo/*4*/.FocalLength/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.FocalLength/*3*/ = value;
            }
        }
        public int? PhotoIso
        {
            get
            {
                return /*1*/Photo/*4*/.Iso/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.Iso/*3*/ = value;
            }
        }
        public System.DateTime? PhotoTakenDateTime
        {
            get
            {
                return /*1*/Photo/*4*/.TakenDateTime/*3*/;
            }
            set
            {
                /*1*/Photo/*4*/.TakenDateTime/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Publication" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPublicationFacet _publication;

        /// <summary>publicationFacet</summary>
        public Sample.API.Models.IMicrosoftGraphPublicationFacet Publication
        {
            get
            {
                return this._publication;
            }
            set
            {
                this._publication = value;
            }
        }
        public string PublicationLevel
        {
            get
            {
                return /*1*/Publication/*4*/.Level/*3*/;
            }
            set
            {
                /*1*/Publication/*4*/.Level/*3*/ = value;
            }
        }
        public string PublicationVersionId
        {
            get
            {
                return /*1*/Publication/*4*/.VersionId/*3*/;
            }
            set
            {
                /*1*/Publication/*4*/.VersionId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="RemoteItem" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRemoteItem _remoteItem;

        /// <summary>remoteItem</summary>
        public Sample.API.Models.IMicrosoftGraphRemoteItem RemoteItem
        {
            get
            {
                return this._remoteItem;
            }
            set
            {
                this._remoteItem = value;
            }
        }
        /// <summary>Backing field for <see cref="Root" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphRoot _root;

        /// <summary>root</summary>
        public Sample.API.Models.IMicrosoftGraphRoot Root
        {
            get
            {
                return this._root;
            }
            set
            {
                this._root = value;
            }
        }
        /// <summary>Backing field for <see cref="SearchResult" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSearchResult _searchResult;

        /// <summary>searchResult</summary>
        public Sample.API.Models.IMicrosoftGraphSearchResult SearchResult
        {
            get
            {
                return this._searchResult;
            }
            set
            {
                this._searchResult = value;
            }
        }
        public string SearchResultOnClickTelemetryUrl
        {
            get
            {
                return /*1*/SearchResult/*4*/.OnClickTelemetryUrl/*3*/;
            }
            set
            {
                /*1*/SearchResult/*4*/.OnClickTelemetryUrl/*3*/ = value;
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
        public string SharepointIdsListId
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
        public string SharepointIdsListItemId
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
        public string SharepointIdsListItemUniqueId
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
        public string SharepointIdsSiteId
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
        public string SharepointIdsSiteUrl
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
        public string SharepointIdsWebId
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
        /// <summary>Backing field for <see cref="Thumbnails" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphThumbnailSet[] _thumbnails;

        public Sample.API.Models.IMicrosoftGraphThumbnailSet[] Thumbnails
        {
            get
            {
                return this._thumbnails;
            }
            set
            {
                this._thumbnails = value;
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
        /// <summary>Backing field for <see cref="Versions" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDriveItemVersion[] _versions;

        public Sample.API.Models.IMicrosoftGraphDriveItemVersion[] Versions
        {
            get
            {
                return this._versions;
            }
            set
            {
                this._versions = value;
            }
        }
        /// <summary>Backing field for <see cref="Video" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphVideo _video;

        /// <summary>video</summary>
        public Sample.API.Models.IMicrosoftGraphVideo Video
        {
            get
            {
                return this._video;
            }
            set
            {
                this._video = value;
            }
        }
        public int? VideoAudioBitsPerSample
        {
            get
            {
                return /*1*/Video/*4*/.AudioBitsPerSample/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.AudioBitsPerSample/*3*/ = value;
            }
        }
        public int? VideoAudioChannels
        {
            get
            {
                return /*1*/Video/*4*/.AudioChannels/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.AudioChannels/*3*/ = value;
            }
        }
        public string VideoAudioFormat
        {
            get
            {
                return /*1*/Video/*4*/.AudioFormat/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.AudioFormat/*3*/ = value;
            }
        }
        public int? VideoAudioSamplesPerSecond
        {
            get
            {
                return /*1*/Video/*4*/.AudioSamplesPerSecond/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.AudioSamplesPerSecond/*3*/ = value;
            }
        }
        public int? VideoBitrate
        {
            get
            {
                return /*1*/Video/*4*/.Bitrate/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.Bitrate/*3*/ = value;
            }
        }
        public long? VideoDuration
        {
            get
            {
                return /*1*/Video/*4*/.Duration/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.Duration/*3*/ = value;
            }
        }
        public string VideoFourCC
        {
            get
            {
                return /*1*/Video/*4*/.FourCC/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.FourCC/*3*/ = value;
            }
        }
        public double? VideoFrameRate
        {
            get
            {
                return /*1*/Video/*4*/.FrameRate/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.FrameRate/*3*/ = value;
            }
        }
        public int? VideoHeight
        {
            get
            {
                return /*1*/Video/*4*/.Height/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.Height/*3*/ = value;
            }
        }
        public int? VideoWidth
        {
            get
            {
                return /*1*/Video/*4*/.Width/*3*/;
            }
            set
            {
                /*1*/Video/*4*/.Width/*3*/ = value;
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
        /// <summary>Backing field for <see cref="Workbook" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphWorkbook _workbook;

        public Sample.API.Models.IMicrosoftGraphWorkbook Workbook
        {
            get
            {
                return this._workbook;
            }
            set
            {
                this._workbook = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDriveitemAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDriveitemAllof1()
        {
        }
    }
    /// driveItem
    public partial interface IComponentsSchemasMicrosoftGraphDriveitemAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayNameApplicationDisplayName { get; set; }
        string ApplicationIdApplicationId { get; set; }
        Sample.API.Models.IMicrosoftGraphAudio Audio { get; set; }
        string AudioAlbum { get; set; }
        string AudioAlbumArtist { get; set; }
        string AudioArtist { get; set; }
        long? AudioBitrate { get; set; }
        string AudioComposers { get; set; }
        string AudioCopyright { get; set; }
        int? AudioDisc { get; set; }
        int? AudioDiscCount { get; set; }
        long? AudioDuration { get; set; }
        string AudioGenre { get; set; }
        bool? AudioHasDrm { get; set; }
        bool? AudioIsVariableBitrate { get; set; }
        string AudioTitle { get; set; }
        int? AudioTrack { get; set; }
        int? AudioTrackCount { get; set; }
        int? AudioYear { get; set; }
        string CTag { get; set; }
        Sample.API.Models.IMicrosoftGraphDriveItem[] Children { get; set; }
        byte[] Content { get; set; }
        Sample.API.Models.IMicrosoftGraphDeleted Deleted { get; set; }
        string DeletedState { get; set; }
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
        string IdApplicationId { get; set; }
        string IdDeviceId { get; set; }
        string IdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphImage Image { get; set; }
        int? ImageHeight { get; set; }
        int? ImageWidth { get; set; }
        Sample.API.Models.IMicrosoftGraphListItem ListItem { get; set; }
        Sample.API.Models.IMicrosoftGraphGeoCoordinates Location { get; set; }
        double? LocationAltitude { get; set; }
        double? LocationLatitude { get; set; }
        double? LocationLongitude { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerUser { get; set; }
        Sample.API.Models.IMicrosoftGraphPackage Package { get; set; }
        string PackageType { get; set; }
        Sample.API.Models.IMicrosoftGraphPermission[] Permissions { get; set; }
        Sample.API.Models.IMicrosoftGraphPhoto Photo { get; set; }
        string PhotoCameraMake { get; set; }
        string PhotoCameraModel { get; set; }
        double? PhotoExposureDenominator { get; set; }
        double? PhotoExposureNumerator { get; set; }
        double? PhotoFNumber { get; set; }
        double? PhotoFocalLength { get; set; }
        int? PhotoIso { get; set; }
        System.DateTime? PhotoTakenDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphPublicationFacet Publication { get; set; }
        string PublicationLevel { get; set; }
        string PublicationVersionId { get; set; }
        Sample.API.Models.IMicrosoftGraphRemoteItem RemoteItem { get; set; }
        Sample.API.Models.IMicrosoftGraphRoot Root { get; set; }
        Sample.API.Models.IMicrosoftGraphSearchResult SearchResult { get; set; }
        string SearchResultOnClickTelemetryUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphShared Shared { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet SharedBy { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity SharedByUser { get; set; }
        System.DateTime? SharedDateTime { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet SharedOwner { get; set; }
        string SharedScope { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
        long? Size { get; set; }
        Sample.API.Models.IMicrosoftGraphSpecialFolder SpecialFolder { get; set; }
        string SpecialFolderName { get; set; }
        Sample.API.Models.IMicrosoftGraphThumbnailSet[] Thumbnails { get; set; }
        string UserDisplayNameUserDisplayName { get; set; }
        string UserIdUserId { get; set; }
        Sample.API.Models.IMicrosoftGraphDriveItemVersion[] Versions { get; set; }
        Sample.API.Models.IMicrosoftGraphVideo Video { get; set; }
        int? VideoAudioBitsPerSample { get; set; }
        int? VideoAudioChannels { get; set; }
        string VideoAudioFormat { get; set; }
        int? VideoAudioSamplesPerSecond { get; set; }
        int? VideoBitrate { get; set; }
        long? VideoDuration { get; set; }
        string VideoFourCC { get; set; }
        double? VideoFrameRate { get; set; }
        int? VideoHeight { get; set; }
        int? VideoWidth { get; set; }
        string ViewSortBy { get; set; }
        string ViewSortOrder { get; set; }
        string ViewType { get; set; }
        string WebDavUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphWorkbook Workbook { get; set; }
    }
}