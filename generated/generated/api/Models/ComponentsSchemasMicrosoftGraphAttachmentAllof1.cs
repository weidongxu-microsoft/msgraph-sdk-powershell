namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>attachment</summary>
    public partial class ComponentsSchemasMicrosoftGraphAttachmentAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphAttachmentAllof1
    {
        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

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
        /// <summary>Backing field for <see cref="IsInline" /> property.</summary>
        private bool? _isInline;

        public bool? IsInline
        {
            get
            {
                return this._isInline;
            }
            set
            {
                this._isInline = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private System.DateTime? _lastModifiedDateTime;

        public System.DateTime? LastModifiedDateTime
        {
            get
            {
                return this._lastModifiedDateTime;
            }
            set
            {
                this._lastModifiedDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private int? _size;

        public int? Size
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphAttachmentAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphAttachmentAllof1()
        {
        }
    }
    /// attachment
    public partial interface IComponentsSchemasMicrosoftGraphAttachmentAllof1 : Sample.API.Runtime.IJsonSerializable {
        string ContentType { get; set; }
        bool? IsInline { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string Name { get; set; }
        int? Size { get; set; }
    }
}