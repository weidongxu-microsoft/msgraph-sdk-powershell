namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>notebook</summary>
    public partial class ComponentsSchemasMicrosoftGraphNotebookAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphNotebookAllof1
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
        /// <summary>Backing field for <see cref="IsShared" /> property.</summary>
        private bool? _isShared;

        public bool? IsShared
        {
            get
            {
                return this._isShared;
            }
            set
            {
                this._isShared = value;
            }
        }
        /// <summary>Backing field for <see cref="Links" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphNotebookLinks _links;

        /// <summary>notebookLinks</summary>
        public Sample.API.Models.IMicrosoftGraphNotebookLinks Links
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
        /// <summary>Backing field for <see cref="SectionGroups" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSectionGroup[] _sectionGroups;

        public Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups
        {
            get
            {
                return this._sectionGroups;
            }
            set
            {
                this._sectionGroups = value;
            }
        }
        /// <summary>Backing field for <see cref="SectionGroupsUrl" /> property.</summary>
        private string _sectionGroupsUrl;

        public string SectionGroupsUrl
        {
            get
            {
                return this._sectionGroupsUrl;
            }
            set
            {
                this._sectionGroupsUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="Sections" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteSection[] _sections;

        public Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections
        {
            get
            {
                return this._sections;
            }
            set
            {
                this._sections = value;
            }
        }
        /// <summary>Backing field for <see cref="SectionsUrl" /> property.</summary>
        private string _sectionsUrl;

        public string SectionsUrl
        {
            get
            {
                return this._sectionsUrl;
            }
            set
            {
                this._sectionsUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="UserRole" /> property.</summary>
        private string _userRole;

        /// <summary>onenoteUserRole</summary>
        public string UserRole
        {
            get
            {
                return this._userRole;
            }
            set
            {
                this._userRole = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphNotebookAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphNotebookAllof1()
        {
        }
    }
    /// notebook
    public partial interface IComponentsSchemasMicrosoftGraphNotebookAllof1 : Sample.API.Runtime.IJsonSerializable {
        bool? IsDefault { get; set; }
        bool? IsShared { get; set; }
        Sample.API.Models.IMicrosoftGraphNotebookLinks Links { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteClientUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink LinksOneNoteWebUrl { get; set; }
        string OneNoteClientUrlHref { get; set; }
        string OneNoteWebUrlHref { get; set; }
        Sample.API.Models.IMicrosoftGraphSectionGroup[] SectionGroups { get; set; }
        string SectionGroupsUrl { get; set; }
        Sample.API.Models.IMicrosoftGraphOnenoteSection[] Sections { get; set; }
        string SectionsUrl { get; set; }
        string UserRole { get; set; }
    }
}