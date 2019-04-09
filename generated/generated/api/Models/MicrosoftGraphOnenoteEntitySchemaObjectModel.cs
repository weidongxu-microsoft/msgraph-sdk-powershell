namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphOnenoteEntitySchemaObjectModel : Sample.API.Models.IMicrosoftGraphOnenoteEntitySchemaObjectModel, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteEntitySchemaObjectModel" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 _componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphOnenoteEntitySchemaObjectModel" /></summary>
        private Sample.API.Models.IMicrosoftGraphOnenoteEntityBaseModel _microsoftGraphOnenoteEntityBaseModel = new Sample.API.Models.MicrosoftGraphOnenoteEntityBaseModel ();
        public System.DateTime? CreatedDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 .CreatedDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 .CreatedDateTime = value;
            }
        }
        public string Id
        {
            get
            {
                return _microsoftGraphOnenoteEntityBaseModel .Id;
            }
            set
            {
                _microsoftGraphOnenoteEntityBaseModel .Id = value;
            }
        }
        public string Self
        {
            get
            {
                return _microsoftGraphOnenoteEntityBaseModel .Self;
            }
            set
            {
                _microsoftGraphOnenoteEntityBaseModel .Self = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphOnenoteEntitySchemaObjectModel" /> instance.
        /// </summary>
        public MicrosoftGraphOnenoteEntitySchemaObjectModel()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphOnenoteEntityBaseModel ), _microsoftGraphOnenoteEntityBaseModel );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphOnenoteEntityBaseModel ), _microsoftGraphOnenoteEntityBaseModel );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 ), _componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 ), _componentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 );
        }
    }
    public partial interface IMicrosoftGraphOnenoteEntitySchemaObjectModel : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphOnenoteEntityBaseModel, Sample.API.Models.IComponentsSchemasMicrosoftGraphOnenoteentityschemaobjectmodelAllof1 {

    }
}