namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>driveItemVersion</summary>
    public partial class ComponentsSchemasMicrosoftGraphDriveitemversionAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDriveitemversionAllof1
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
        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private long? _size;

        public long? Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDriveitemversionAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDriveitemversionAllof1()
        {
        }
    }
    /// driveItemVersion
    public partial interface IComponentsSchemasMicrosoftGraphDriveitemversionAllof1 : Sample.API.Runtime.IJsonSerializable {
        byte[] Content { get; set; }
        long? Size { get; set; }
    }
}