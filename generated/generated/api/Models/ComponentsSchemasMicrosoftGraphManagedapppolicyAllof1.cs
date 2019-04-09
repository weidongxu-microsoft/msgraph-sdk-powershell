namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>
    /// The ManagedAppPolicy resource represents a base type for platform specific policies.
    /// </summary>
    public partial class ComponentsSchemasMicrosoftGraphManagedapppolicyAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphManagedapppolicyAllof1
    {
        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private System.DateTime? _createdDateTime;

        /// <summary>The date and time the policy was created.</summary>
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return this._createdDateTime;
            }
            set
            {
                this._createdDateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The policy's description.</summary>
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
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Policy display name.</summary>
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

        /// <summary>Last time the policy was modified.</summary>
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
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphManagedapppolicyAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphManagedapppolicyAllof1()
        {
        }
    }
    /// The ManagedAppPolicy resource represents a base type for platform specific policies.
    public partial interface IComponentsSchemasMicrosoftGraphManagedapppolicyAllof1 : Sample.API.Runtime.IJsonSerializable {
        System.DateTime? CreatedDateTime { get; set; }
        string Description { get; set; }
        string DisplayName { get; set; }
        System.DateTime? LastModifiedDateTime { get; set; }
        string Version { get; set; }
    }
}