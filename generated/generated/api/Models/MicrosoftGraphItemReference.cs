namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>itemReference</summary>
    public partial class MicrosoftGraphItemReference : Sample.API.Models.IMicrosoftGraphItemReference
    {
        /// <summary>Backing field for <see cref="DriveId" /> property.</summary>
        private string _driveId;

        public string DriveId
        {
            get
            {
                return this._driveId;
            }
            set
            {
                this._driveId = value;
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
        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        public string Path
        {
            get
            {
                return this._path;
            }
            set
            {
                this._path = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphItemReference" /> instance.</summary>
        public MicrosoftGraphItemReference()
        {
        }
    }
    /// itemReference
    public partial interface IMicrosoftGraphItemReference : Sample.API.Runtime.IJsonSerializable {
        string DriveId { get; set; }
        string DriveType { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        string ShareId { get; set; }
        Sample.API.Models.IMicrosoftGraphSharepointIds SharepointIds { get; set; }
        string SharepointIdsListId { get; set; }
        string SharepointIdsListItemId { get; set; }
        string SharepointIdsListItemUniqueId { get; set; }
        string SharepointIdsSiteId { get; set; }
        string SharepointIdsSiteUrl { get; set; }
        string SharepointIdsWebId { get; set; }
    }
}