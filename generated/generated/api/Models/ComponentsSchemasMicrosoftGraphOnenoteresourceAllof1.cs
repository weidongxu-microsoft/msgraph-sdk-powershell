namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteResource</summary>
    public partial class ComponentsSchemasMicrosoftGraphOnenoteresourceAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteresourceAllof1
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphOnenoteresourceAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphOnenoteresourceAllof1()
        {
        }
    }
    /// onenoteResource
    public partial interface IComponentsSchemasMicrosoftGraphOnenoteresourceAllof1 : Sample.API.Runtime.IJsonSerializable {
        byte[] Content { get; set; }
        string ContentUrl { get; set; }
    }
}