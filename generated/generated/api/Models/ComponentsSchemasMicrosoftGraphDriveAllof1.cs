namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>drive</summary>
    public partial class ComponentsSchemasMicrosoftGraphDriveAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveAllof1
    {
        public string ApplicationDisplayName
        {
            get
            {
                return /*1*/Owner/*4*/.ApplicationDisplayName/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.ApplicationDisplayName/*3*/ = value;
            }
        }
        public string ApplicationId
        {
            get
            {
                return /*1*/Owner/*4*/.ApplicationId/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.ApplicationId/*3*/ = value;
            }
        }
        public string DeviceDisplayName
        {
            get
            {
                return /*1*/Owner/*4*/.DeviceDisplayName/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.DeviceDisplayName/*3*/ = value;
            }
        }
        public string DeviceId
        {
            get
            {
                return /*1*/Owner/*4*/.DeviceId/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.DeviceId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="DriveType" /> property.</summary>
        private string _driveType;

        public string DriveType
        {
            get
            {
                return this._driveType;
            }
            set
            {
                this._driveType = value;
            }
        }
        /// <summary>Backing field for <see cref="Items" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDriveItem[] _items;

        public Sample.API.Models.IMicrosoftGraphDriveItem[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        /// <summary>Backing field for <see cref="List" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphList _list;

        public Sample.API.Models.IMicrosoftGraphList List
        {
            get
            {
                return this._list;
            }
            set
            {
                this._list = value;
            }
        }
        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphIdentitySet _owner;

        /// <summary>identitySet</summary>
        public Sample.API.Models.IMicrosoftGraphIdentitySet Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication
        {
            get
            {
                return /*1*/Owner/*4*/.Application/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.Application/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice
        {
            get
            {
                return /*1*/Owner/*4*/.Device/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.Device/*3*/ = value;
            }
        }
        /// <summary>identity</summary>
        public Sample.API.Models.IMicrosoftGraphIdentity OwnerUser
        {
            get
            {
                return /*1*/Owner/*4*/.User/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.User/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Quota" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphQuota _quota;

        /// <summary>quota</summary>
        public Sample.API.Models.IMicrosoftGraphQuota Quota
        {
            get
            {
                return this._quota;
            }
            set
            {
                this._quota = value;
            }
        }
        public long? QuotaDeleted
        {
            get
            {
                return /*1*/Quota/*4*/.Deleted/*3*/;
            }
            set
            {
                /*1*/Quota/*4*/.Deleted/*3*/ = value;
            }
        }
        public long? QuotaRemaining
        {
            get
            {
                return /*1*/Quota/*4*/.Remaining/*3*/;
            }
            set
            {
                /*1*/Quota/*4*/.Remaining/*3*/ = value;
            }
        }
        public string QuotaState
        {
            get
            {
                return /*1*/Quota/*4*/.State/*3*/;
            }
            set
            {
                /*1*/Quota/*4*/.State/*3*/ = value;
            }
        }
        public long? QuotaTotal
        {
            get
            {
                return /*1*/Quota/*4*/.Total/*3*/;
            }
            set
            {
                /*1*/Quota/*4*/.Total/*3*/ = value;
            }
        }
        public long? QuotaUsed
        {
            get
            {
                return /*1*/Quota/*4*/.Used/*3*/;
            }
            set
            {
                /*1*/Quota/*4*/.Used/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Root" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDriveItem _root;

        public Sample.API.Models.IMicrosoftGraphDriveItem Root
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
        /// <summary>Backing field for <see cref="SharePointIds" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSharepointIds _sharePointIds;

        /// <summary>sharepointIds</summary>
        public Sample.API.Models.IMicrosoftGraphSharepointIds SharePointIds
        {
            get
            {
                return this._sharePointIds;
            }
            set
            {
                this._sharePointIds = value;
            }
        }
        public string SharePointIdsListId
        {
            get
            {
                return /*1*/SharePointIds/*4*/.ListId/*3*/;
            }
            set
            {
                /*1*/SharePointIds/*4*/.ListId/*3*/ = value;
            }
        }
        public string SharePointIdsListItemId
        {
            get
            {
                return /*1*/SharePointIds/*4*/.ListItemId/*3*/;
            }
            set
            {
                /*1*/SharePointIds/*4*/.ListItemId/*3*/ = value;
            }
        }
        public string SharePointIdsListItemUniqueId
        {
            get
            {
                return /*1*/SharePointIds/*4*/.ListItemUniqueId/*3*/;
            }
            set
            {
                /*1*/SharePointIds/*4*/.ListItemUniqueId/*3*/ = value;
            }
        }
        public string SharePointIdsSiteId
        {
            get
            {
                return /*1*/SharePointIds/*4*/.SiteId/*3*/;
            }
            set
            {
                /*1*/SharePointIds/*4*/.SiteId/*3*/ = value;
            }
        }
        public string SharePointIdsSiteUrl
        {
            get
            {
                return /*1*/SharePointIds/*4*/.SiteUrl/*3*/;
            }
            set
            {
                /*1*/SharePointIds/*4*/.SiteUrl/*3*/ = value;
            }
        }
        public string SharePointIdsWebId
        {
            get
            {
                return /*1*/SharePointIds/*4*/.WebId/*3*/;
            }
            set
            {
                /*1*/SharePointIds/*4*/.WebId/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Special" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphDriveItem[] _special;

        public Sample.API.Models.IMicrosoftGraphDriveItem[] Special
        {
            get
            {
                return this._special;
            }
            set
            {
                this._special = value;
            }
        }
        /// <summary>Backing field for <see cref="System" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSystemFacet _system;

        /// <summary>systemFacet</summary>
        public Sample.API.Models.IMicrosoftGraphSystemFacet System
        {
            get
            {
                return this._system;
            }
            set
            {
                this._system = value;
            }
        }
        public string UserDisplayName
        {
            get
            {
                return /*1*/Owner/*4*/.UserDisplayName/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.UserDisplayName/*3*/ = value;
            }
        }
        public string UserId
        {
            get
            {
                return /*1*/Owner/*4*/.UserId/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.UserId/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDriveAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDriveAllof1()
        {
        }
    }
    /// drive
    public partial interface IComponentsSchemasMicrosoftGraphDriveAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ApplicationDisplayName { get; set; }
        string ApplicationId { get; set; }
        string DeviceDisplayName { get; set; }
        string DeviceId { get; set; }
        string DriveType { get; set; }
        Sample.API.Models.IMicrosoftGraphDriveItem[] Items { get; set; }
        Sample.API.Models.IMicrosoftGraphList List { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentitySet Owner { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerApplication { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerDevice { get; set; }
        Sample.API.Models.IMicrosoftGraphIdentity OwnerUser { get; set; }
        Sample.API.Models.IMicrosoftGraphQuota Quota { get; set; }
        long? QuotaDeleted { get; set; }
        long? QuotaRemaining { get; set; }
        string QuotaState { get; set; }
        long? QuotaTotal { get; set; }
        long? QuotaUsed { get; set; }
        Sample.API.Models.IMicrosoftGraphDriveItem Root { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds SharePointIds { get; set; }
        string SharePointIdsListId { get; set; }
        string SharePointIdsListItemId { get; set; }
        string SharePointIdsListItemUniqueId { get; set; }
        string SharePointIdsSiteId { get; set; }
        string SharePointIdsSiteUrl { get; set; }
        string SharePointIdsWebId { get; set; }
        Sample.API.Models.IMicrosoftGraphDriveItem[] Special { get; set; }
        Sample.API.Models.IMicrosoftGraphSystemFacet System { get; set; }
        string UserDisplayName { get; set; }
        string UserId { get; set; }
    }
}