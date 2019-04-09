namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>sectionLinks</summary>
    public partial class MicrosoftGraphSectionLinks : Sample.API.Models.IMicrosoftGraphSectionLinks
    {
        /// <summary>Backing field for <see cref="OneNoteClientUrl" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphExternalLink _oneNoteClientUrl;

        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink OneNoteClientUrl
        {
            get
            {
                return this._oneNoteClientUrl;
            }
            set
            {
                this._oneNoteClientUrl = value;
            }
        }
        public string OneNoteClientUrlHref
        {
            get
            {
                return /*1*/OneNoteClientUrl/*4*/.Href/*3*/;
            }
            set
            {
                /*1*/OneNoteClientUrl/*4*/.Href/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="OneNoteWebUrl" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphExternalLink _oneNoteWebUrl;

        /// <summary>externalLink</summary>
        public Sample.API.Models.IMicrosoftGraphExternalLink OneNoteWebUrl
        {
            get
            {
                return this._oneNoteWebUrl;
            }
            set
            {
                this._oneNoteWebUrl = value;
            }
        }
        public string OneNoteWebUrlHref
        {
            get
            {
                return /*1*/OneNoteWebUrl/*4*/.Href/*3*/;
            }
            set
            {
                /*1*/OneNoteWebUrl/*4*/.Href/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphSectionLinks" /> instance.</summary>
        public MicrosoftGraphSectionLinks()
        {
        }
    }
    /// sectionLinks
    public partial interface IMicrosoftGraphSectionLinks : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphExternalLink OneNoteClientUrl { get; set; }
        string OneNoteClientUrlHref { get; set; }
        Sample.API.Models.IMicrosoftGraphExternalLink OneNoteWebUrl { get; set; }
        string OneNoteWebUrlHref { get; set; }
    }
}