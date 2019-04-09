namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteSection</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenotesectionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenotesectionAllof1
    {
        /// <summary>Backing field for <see cref="IsDefault" /> property.</summary>
        private bool? _isDefault;

        public bool? IsDefault
        {
            get
            {
                return this._isDefault;
            }
            set
            {
                this._isDefault = value;
            }
        }
        /// <summary>Backing field for <see cref="Links" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSectionLinks _links;

        /// <summary>sectionLinks</summary>
        public Sample.API.Models.IMicrosoftGraphSectionLinks Links
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
        /// <summary>Backing field for <see cref="Pages" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenotePage[] _pages;

        public Sample.API.Models.IMicrosoftGraphOnenotePage[] Pages
        {
            get
            {
                return this._pages;
            }
            set
            {
                this._pages = value;
            }
        }
        /// <summary>Backing field for <see cref="PagesUrl" /> property.</summary>
        private string _pagesUrl;

        public string PagesUrl
        {
            get
            {
                return this._pagesUrl;
            }
            set
            {
                this._pagesUrl = value;
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
        /// <summary>Backing field for <see cref="ParentSectionGroup" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSectionGroup _parentSectionGroup;

        public Sample.API.Models.IMicrosoftGraphSectionGroup ParentSectionGroup
        {
            get
            {
                return this._parentSectionGroup;
            }
            set
            {
                this._parentSectionGroup = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenotesectionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenotesectionAllof1()
        {
        }
    }
    /// onenoteSection
    public partial interface IComponentsSchemasMicrosoftGraphOnenotesectionAllof1 : Sample.API.Runtime.IJsonSerializable {
        bool? IsDefault { get; set; }
        Sample.API.Models.IMicrosoftGraphSectionLinks Links { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl { get; set; }
        string OneNoteClientUrlHref { get; set; }
        string OneNoteWebUrlHref { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenotePage[] Pages { get; set; }
        string PagesUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphNotebook ParentNotebook { get; set; }
        Sample.API.Models.IMicrosoftGraphSectionGroup ParentSectionGroup { get; set; }
    }
}