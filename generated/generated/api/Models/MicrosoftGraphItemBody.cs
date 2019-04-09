namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>itemBody</summary>
    public partial class MicrosoftGraphItemBody : Sample.API.Models.IMicrosoftGraphItemBody
    {
        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private string _content;

        public string Content
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
        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>bodyType</summary>
        public string ContentType
        {
            get
            {
                return this._contentType;
            }
            set
            {
                this._contentType = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphItemBody" /> instance.</summary>
        public MicrosoftGraphItemBody()
        {
        }
    }
    /// itemBody
    public partial interface IMicrosoftGraphItemBody : Sample.API.Runtime.IJsonSerializable {
        string Content { get; set; }
        string ContentType { get; set; }
    }
}