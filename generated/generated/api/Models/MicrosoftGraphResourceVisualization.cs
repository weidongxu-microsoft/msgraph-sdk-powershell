namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>resourceVisualization</summary>
    public partial class MicrosoftGraphResourceVisualization : Sample.API.Models.IMicrosoftGraphResourceVisualization
    {
        /// <summary>Backing field for <see cref="ContainerDisplayName" /> property.</summary>
        private string _containerDisplayName;

        public string ContainerDisplayName
        {
            get
            {
                return this._containerDisplayName;
            }
            set
            {
                this._containerDisplayName = value;
            }
        }
        /// <summary>Backing field for <see cref="ContainerType" /> property.</summary>
        private string _containerType;

        public string ContainerType
        {
            get
            {
                return this._containerType;
            }
            set
            {
                this._containerType = value;
            }
        }
        /// <summary>Backing field for <see cref="ContainerWebUrl" /> property.</summary>
        private string _containerWebUrl;

        public string ContainerWebUrl
        {
            get
            {
                return this._containerWebUrl;
            }
            set
            {
                this._containerWebUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="MediaType" /> property.</summary>
        private string _mediaType;

        public string MediaType
        {
            get
            {
                return this._mediaType;
            }
            set
            {
                this._mediaType = value;
            }
        }
        /// <summary>Backing field for <see cref="PreviewImageUrl" /> property.</summary>
        private string _previewImageUrl;

        public string PreviewImageUrl
        {
            get
            {
                return this._previewImageUrl;
            }
            set
            {
                this._previewImageUrl = value;
            }
        }
        /// <summary>Backing field for <see cref="PreviewText" /> property.</summary>
        private string _previewText;

        public string PreviewText
        {
            get
            {
                return this._previewText;
            }
            set
            {
                this._previewText = value;
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
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphResourceVisualization" /> instance.</summary>
        public MicrosoftGraphResourceVisualization()
        {
        }
    }
    /// resourceVisualization
    public partial interface IMicrosoftGraphResourceVisualization : Sample.API.Runtime.IJsonSerializable {
        string ContainerDisplayName { get; set; }
        string ContainerType { get; set; }
        string ContainerWebUrl { get; set; }
        string MediaType { get; set; }
        string PreviewImageUrl { get; set; }
        string PreviewText { get; set; }
        string Title { get; set; }
        string Type { get; set; }
    }
}