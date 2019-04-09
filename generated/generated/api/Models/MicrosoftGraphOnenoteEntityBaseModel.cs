namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenoteEntityBaseModel : Sample.API.Models.IMicrosoftGraphOnenoteEntityBaseModel, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteEntityBaseModel" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 _componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteEntityBaseModel" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
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
        public string Self
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 .Self;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 .Self = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenoteEntityBaseModel" /> instance.</summary>
        public MicrosoftGraphOnenoteEntityBaseModel()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 ), _componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 ), _componentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenoteEntityBaseModel : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentitybasemodelAllof1 {

    }
}