namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Represents an operation applied against an app registration.</summary>
    public partial class ComponentsSchemasMicrosoftGraphManagedappoperationAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedappoperationAllof1
    {
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The operation name.</summary>
        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private System.DateTime? _lastModifiedDateTime;

        /// <summary>The last time the app operation was modified.</summary>
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
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The current state of the operation</summary>
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of the entity.</summary>
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphManagedappoperationAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphManagedappoperationAllof1()
        {
        }
    }
    /// Represents an operation applied against an app registration.
    public partial interface IComponentsSchemasMicrosoftGraphManagedappoperationAllof1 : Sample.API.Runtime.IJsonSerializable {
        string DisplayName { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string State { get; set; }
        string Version { get; set; }
    }
}