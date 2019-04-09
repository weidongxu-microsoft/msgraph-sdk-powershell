namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>directoryObject</summary>
    public partial class ComponentsSchemasMicrosoftGraphDirectoryobjectAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDirectoryobjectAllof1
    {
        /// <summary>Backing field for <see cref="DeletedDateTime" /> property.</summary>
        private System.DateTime? _deletedDateTime;

        public System.DateTime? DeletedDateTime
        {
            get
            {
                return this._deletedDateTime;
            }
            set
            {
                this._deletedDateTime = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDirectoryobjectAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDirectoryobjectAllof1()
        {
        }
    }
    /// directoryObject
    public partial interface IComponentsSchemasMicrosoftGraphDirectoryobjectAllof1 : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? DeletedDateTime { get; set; }
    }
}