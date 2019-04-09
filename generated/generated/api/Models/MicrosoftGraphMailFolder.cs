namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphMailFolder : Sample.API.Models.IMicrosoftGraphMailFolder, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphMailFolder" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphMailfolderAllof1 _componentsSchemasMicrosoftGraphMailfolderAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphMailfolderAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphMailFolder" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public int? ChildFolderCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .ChildFolderCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .ChildFolderCount = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMailFolder[] ChildFolders
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .ChildFolders;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .ChildFolders = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .DisplayName = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphEntity .Id;
            }
            set
            {
                _microsoftGraphEntity .Id = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMessageRule[] MessageRules
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .MessageRules;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .MessageRules = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMessage[] Messages
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .Messages;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .Messages = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .MultiValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .MultiValueExtendedProperties = value;
            }
        }
        public string ParentFolderId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .ParentFolderId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .ParentFolderId = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .SingleValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .SingleValueExtendedProperties = value;
            }
        }
        public int? TotalItemCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .TotalItemCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .TotalItemCount = value;
            }
        }
        public int? UnreadItemCount
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMailfolderAllof1 .UnreadItemCount;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMailfolderAllof1 .UnreadItemCount = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphMailFolder" /> instance.</summary>
        public MicrosoftGraphMailFolder()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Sample.API.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphEntity ), _microsoftGraphEntity );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphMailfolderAllof1 ), _componentsSchemasMicrosoftGraphMailfolderAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphMailfolderAllof1 ), _componentsSchemasMicrosoftGraphMailfolderAllof1 );
        }
    }
    public partial interface IMicrosoftGraphMailFolder : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphMailfolderAllof1 {

    }
}