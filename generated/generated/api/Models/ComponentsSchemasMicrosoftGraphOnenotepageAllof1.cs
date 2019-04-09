namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenotePage</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenotepageAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotepageAllof1
    {
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
        /// <summary>Backing field for <see cref="ContentUrl" /> property.</summary>
        private string _contentUrl;

        public string ContentUrl
        {
            get
            {
                return this._contentUrl;
            }
            set
            {
                this._contentUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="CreatedByAppId" /> property.</summary>
        private string _createdByAppId;

        public string CreatedByAppId
        {
            get
            {
                return this._createdByAppId;
            }
            set
            {
                this._createdByAppId = value;
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
        /// <summary>Backing field for <see cref="Level" /> property.</summary>
        private int? _level;

        public int? Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
        /// <summary>Backing field for <see cref="Links" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphPageLinks _links;

        /// <summary>pageLinks</summary>
        public Sample.API.Models.IMicrosoftGraphPageLinks Links
        {
            get
            {
                return this._links;
            }
            set
            {
                this._links = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl
        {
            get
            {
                return /*1*/Links/*4*/.OneNoteClientUrl/*3*/;
            }
            set
            {
                /*1*/Links/*4*/.OneNoteClientUrl/*3*/ = value;
            }
        }
        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl
        {
            get
            {
                return /*1*/Links/*4*/.OneNoteWebUrl/*3*/;
            }
            set
            {
                /*1*/Links/*4*/.OneNoteWebUrl/*3*/ = value;
            }
        }
        public string OneNoteClientUrlHref
        {
            get
            {
                return /*1*/Links/*4*/.OneNoteClientUrlHref/*3*/;
            }
            set
            {
                /*1*/Links/*4*/.OneNoteClientUrlHref/*3*/ = value;
            }
        }
        public string OneNoteWebUrlHref
        {
            get
            {
                return /*1*/Links/*4*/.OneNoteWebUrlHref/*3*/;
            }
            set
            {
                /*1*/Links/*4*/.OneNoteWebUrlHref/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private int? _order;

        public int? Order
        {
            get
            {
                return this._order;
            }
            set
            {
                this._order = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentNotebook" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphNotebook _parentNotebook;

        public Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook
        {
            get
            {
                return this._parentNotebook;
            }
            set
            {
                this._parentNotebook = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentSection" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteSection _parentSection;

        public Sample.API.Models.IMicrosoftGraphOnenoteSection ParentSection
        {
            get
            {
                return this._parentSection;
            }
            set
            {
                this._parentSection = value;
            }
        }
        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        /// <summary>Backing field for <see cref="UserTags" /> property.</summary>
        private string[] _userTags;

        public string[] UserTags
        {
            get
            {
                return this._userTags;
            }
            set
            {
                this._userTags = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenotepageAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenotepageAllof1()
        {
        }
    }
    /// onenotePage
    public partial interface IComponentsSchemasMicrosoftGraphOnenotepageAllof1 : Sample.API.Runtime.IJsonSerializable {
        byte[] Content { get; set; }
        string ContentUrl { get; set; }
        string CreatedByAppId { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        int? Level { get; set; }
        Sample.API.Models.IMicrosoftGraphPageLinks Links { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl { get; set; }
        string OneNoteClientUrlHref { get; set; }
        string OneNoteWebUrlHref { get; set; }
        int? Order { get; set; }
        Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenoteSection ParentSection { get; set; }
        string Title { get; set; }
        string[] UserTags { get; set; }
    }
}