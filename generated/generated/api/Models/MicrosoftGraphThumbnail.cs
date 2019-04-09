namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>thumbnail</summary>
    public partial class MicrosoftGraphThumbnail : Sample.API.Models.IMicrosoftGraphThumbnail
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
        /// <summary>Backing field for <see cref="Height" /> property.</summary>
        private int? _height;

        public int? Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        /// <summary>Backing field for <see cref="SourceItemId" /> property.</summary>
        private string _sourceItemId;

        public string SourceItemId
        {
            get
            {
                return this._sourceItemId;
            }
            set
            {
                this._sourceItemId = value;
            }
        }
        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
        }
        /// <summary>Backing field for <see cref="Width" /> property.</summary>
        private int? _width;

        public int? Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphThumbnail" /> instance.</summary>
        public MicrosoftGraphThumbnail()
        {
        }
    }
    /// thumbnail
    public partial interface IMicrosoftGraphThumbnail : Sample.API.Runtime.IJsonSerializable {
        byte[] Content { get; set; }
        int? Height { get; set; }
        string SourceItemId { get; set; }
        string Url { get; set; }
        int? Width { get; set; }
    }
}