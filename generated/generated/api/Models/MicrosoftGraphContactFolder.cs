namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphContactFolder : Sample.API.Models.IMicrosoftGraphContactFolder, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphContactFolder" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphContactfolderAllof1 _componentsSchemasMicrosoftGraphContactfolderAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphContactfolderAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphContactFolder" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphContactFolder[] ChildFolders
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactfolderAllof1 .ChildFolders;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactfolderAllof1 .ChildFolders = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphContact[] Contacts
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactfolderAllof1 .Contacts;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactfolderAllof1 .Contacts = value;
            }
        }
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactfolderAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactfolderAllof1 .DisplayName = value;
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
        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactfolderAllof1 .MultiValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactfolderAllof1 .MultiValueExtendedProperties = value;
            }
        }
        public string ParentFolderId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactfolderAllof1 .ParentFolderId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactfolderAllof1 .ParentFolderId = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphContactfolderAllof1 .SingleValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphContactfolderAllof1 .SingleValueExtendedProperties = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphContactFolder" /> instance.</summary>
        public MicrosoftGraphContactFolder()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphContactfolderAllof1 ), _componentsSchemasMicrosoftGraphContactfolderAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphContactfolderAllof1 ), _componentsSchemasMicrosoftGraphContactfolderAllof1 );
        }
    }
    public partial interface IMicrosoftGraphContactFolder : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphContactfolderAllof1 {

    }
}