namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contactFolder</summary>
    public partial class ComponentsSchemasMicrosoftGraphContactfolderAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphContactfolderAllof1
    {
        /// <summary>Backing field for <see cref="ChildFolders" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContactFolder[] _childFolders;

        public Sample.API.Models.IMicrosoftGraphContactFolder[] ChildFolders
        {
            get
            {
                return this._childFolders;
            }
            set
            {
                this._childFolders = value;
            }
        }
        /// <summary>Backing field for <see cref="Contacts" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphContact[] _contacts;

        public Sample.API.Models.IMicrosoftGraphContact[] Contacts
        {
            get
            {
                return this._contacts;
            }
            set
            {
                this._contacts = value;
            }
        }
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

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
        /// <summary>Backing field for <see cref="MultiValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] _multiValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return this._multiValueExtendedProperties;
            }
            set
            {
                this._multiValueExtendedProperties = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentFolderId" /> property.</summary>
        private string _parentFolderId;

        public string ParentFolderId
        {
            get
            {
                return this._parentFolderId;
            }
            set
            {
                this._parentFolderId = value;
            }
        }
        /// <summary>Backing field for <see cref="SingleValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] _singleValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return this._singleValueExtendedProperties;
            }
            set
            {
                this._singleValueExtendedProperties = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphContactfolderAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphContactfolderAllof1()
        {
        }
    }
    /// contactFolder
    public partial interface IComponentsSchemasMicrosoftGraphContactfolderAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphContactFolder[] ChildFolders { get; set; }
        Sample.API.Models.IMicrosoftGraphContact[] Contacts { get; set; }
        string DisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get; set; }
        string ParentFolderId { get; set; }
        Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get; set; }
    }
}