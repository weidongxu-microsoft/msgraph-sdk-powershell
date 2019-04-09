namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>imageInfo</summary>
    public partial class MicrosoftGraphImageInfo : Sample.API.Models.IMicrosoftGraphImageInfo
    {
        /// <summary>Backing field for <see cref="AddImageQuery" /> property.</summary>
        private bool? _addImageQuery;

        public bool? AddImageQuery
        {
            get
            {
                return this._addImageQuery;
            }
            set
            {
                this._addImageQuery = value;
            }
        }
        /// <summary>Backing field for <see cref="AlternateText" /> property.</summary>
        private string _alternateText;

        public string AlternateText
        {
            get
            {
                return this._alternateText;
            }
            set
            {
                this._alternateText = value;
            }
        }
        /// <summary>Backing field for <see cref="AlternativeText" /> property.</summary>
        private string _alternativeText;

        public string AlternativeText
        {
            get
            {
                return this._alternativeText;
            }
            set
            {
                this._alternativeText = value;
            }
        }
        /// <summary>Backing field for <see cref="IconUrl" /> property.</summary>
        private string _iconUrl;

        public string IconUrl
        {
            get
            {
                return this._iconUrl;
            }
            set
            {
                this._iconUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphImageInfo" /> instance.</summary>
        public MicrosoftGraphImageInfo()
        {
        }
    }
    /// imageInfo
    public partial interface IMicrosoftGraphImageInfo : Sample.API.Runtime.IJsonSerializable {
        bool? AddImageQuery { get; set; }
        string AlternateText { get; set; }
        string AlternativeText { get; set; }
        string IconUrl { get; set; }
    }
}