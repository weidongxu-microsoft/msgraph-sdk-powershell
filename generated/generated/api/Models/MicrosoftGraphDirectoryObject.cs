namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDirectoryObject : Sample.API.Models.IMicrosoftGraphDirectoryObject, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDirectoryObject" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDirectoryobjectAllof1 _componentsSchemasMicrosoftGraphDirectoryobjectAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDirectoryobjectAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDirectoryObject" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public System.DateTime? DeletedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDirectoryobjectAllof1 .DeletedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDirectoryobjectAllof1 .DeletedDateTime = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphDirectoryObject" /> instance.</summary>
        public MicrosoftGraphDirectoryObject()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDirectoryobjectAllof1 ), _componentsSchemasMicrosoftGraphDirectoryobjectAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDirectoryobjectAllof1 ), _componentsSchemasMicrosoftGraphDirectoryobjectAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDirectoryObject : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphDirectoryobjectAllof1 {

    }
}