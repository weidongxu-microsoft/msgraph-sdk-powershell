namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>mailFolder</summary>
    public partial class ComponentsSchemasMicrosoftGraphMailfolderAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphMailfolderAllof1
    {
        /// <summary>Backing field for <see cref="ChildFolderCount" /> property.</summary>
        private int? _childFolderCount;

        public int? ChildFolderCount
        {
            get
            {
                return this._childFolderCount;
            }
            set
            {
                this._childFolderCount = value;
            }
        }
        /// <summary>Backing field for <see cref="ChildFolders" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMailFolder[] _childFolders;

        public Sample.API.Models.IMicrosoftGraphMailFolder[] ChildFolders
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
        /// <summary>Backing field for <see cref="MessageRules" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMessageRule[] _messageRules;

        public Sample.API.Models.IMicrosoftGraphMessageRule[] MessageRules
        {
            get
            {
                return this._messageRules;
            }
            set
            {
                this._messageRules = value;
            }
        }
        /// <summary>Backing field for <see cref="Messages" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMessage[] _messages;

        public Sample.API.Models.IMicrosoftGraphMessage[] Messages
        {
            get
            {
                return this._messages;
            }
            set
            {
                this._messages = value;
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
        /// <summary>Backing field for <see cref="TotalItemCount" /> property.</summary>
        private int? _totalItemCount;

        public int? TotalItemCount
        {
            get
            {
                return this._totalItemCount;
            }
            set
            {
                this._totalItemCount = value;
            }
        }
        /// <summary>Backing field for <see cref="UnreadItemCount" /> property.</summary>
        private int? _unreadItemCount;

        public int? UnreadItemCount
        {
            get
            {
                return this._unreadItemCount;
            }
            set
            {
                this._unreadItemCount = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphMailfolderAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphMailfolderAllof1()
        {
        }
    }
    /// mailFolder
    public partial interface IComponentsSchemasMicrosoftGraphMailfolderAllof1 : Sample.API.Runtime.IJsonSerializable {
        int? ChildFolderCount { get; set; }
        Sample.API.Models.IMicrosoftGraphMailFolder[] ChildFolders { get; set; }
        string DisplayName { get; set; }
        Sample.API.Models.IMicrosoftGraphMessageRule[] MessageRules { get; set; }
        Sample.API.Models.IMicrosoftGraphMessage[] Messages { get; set; }
        Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get; set; }
        string ParentFolderId { get; set; }
        Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get; set; }
        int? TotalItemCount { get; set; }
        int? UnreadItemCount { get; set; }
    }
}