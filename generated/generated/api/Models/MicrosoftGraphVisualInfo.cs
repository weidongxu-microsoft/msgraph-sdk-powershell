namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>visualInfo</summary>
    public partial class MicrosoftGraphVisualInfo : Sample.API.Models.IMicrosoftGraphVisualInfo
    {
        /// <summary>Backing field for <see cref="Attribution" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphImageInfo _attribution;

        /// <summary>imageInfo</summary>
        public Sample.API.Models.IMicrosoftGraphImageInfo Attribution
        {
            get
            {
                return this._attribution;
            }
            set
            {
                this._attribution = value;
            }
        }
        public bool? AttributionAddImageQuery
        {
            get
            {
                return /*1*/Attribution/*4*/.AddImageQuery/*3*/;
            }
            set
            {
                /*1*/Attribution/*4*/.AddImageQuery/*3*/ = value;
            }
        }
        public string AttributionAlternateText
        {
            get
            {
                return /*1*/Attribution/*4*/.AlternateText/*3*/;
            }
            set
            {
                /*1*/Attribution/*4*/.AlternateText/*3*/ = value;
            }
        }
        public string AttributionAlternativeText
        {
            get
            {
                return /*1*/Attribution/*4*/.AlternativeText/*3*/;
            }
            set
            {
                /*1*/Attribution/*4*/.AlternativeText/*3*/ = value;
            }
        }
        public string AttributionIconUrl
        {
            get
            {
                return /*1*/Attribution/*4*/.IconUrl/*3*/;
            }
            set
            {
                /*1*/Attribution/*4*/.IconUrl/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="BackgroundColor" /> property.</summary>
        private string _backgroundColor;

        public string BackgroundColor
        {
            get
            {
                return this._backgroundColor;
            }
            set
            {
                this._backgroundColor = value;
            }
        }
        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphJson _content;

        /// <summary>Json</summary>
        public Sample.API.Models.IMicrosoftGraphJson Content
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
        /// <summary>Backing field for <see cref="DisplayText" /> property.</summary>
        private string _displayText;

        public string DisplayText
        {
            get
            {
                return this._displayText;
            }
            set
            {
                this._displayText = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphVisualInfo" /> instance.</summary>
        public MicrosoftGraphVisualInfo()
        {
        }
    }
    /// visualInfo
    public partial interface IMicrosoftGraphVisualInfo : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphImageInfo Attribution { get; set; }
        bool? AttributionAddImageQuery { get; set; }
        string AttributionAlternateText { get; set; }
        string AttributionAlternativeText { get; set; }
        string AttributionIconUrl { get; set; }
        string BackgroundColor { get; set; }
        Sample.API.Models.IMicrosoftGraphJson Content { get; set; }
        string Description { get; set; }
        string DisplayText { get; set; }
    }
}