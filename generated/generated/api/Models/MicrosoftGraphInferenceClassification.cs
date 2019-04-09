namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphInferenceClassification : Sample.API.Models.IMicrosoftGraphInferenceClassification, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphInferenceClassification" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationAllof1 _componentsSchemasMicrosoftGraphInferenceclassificationAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphInferenceclassificationAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphInferenceClassification" /></summary>
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
        public Sample.API.Models.IMicrosoftGraphInferenceClassificationOverride[] Overrides
        {
            get
            {
                return _componentsSchemasMicrosoftGraphInferenceclassificationAllof1 .Overrides;
            }
            set
            {
                _componentsSchemasMicrosoftGraphInferenceclassificationAllof1 .Overrides = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphInferenceClassification" /> instance.</summary>
        public MicrosoftGraphInferenceClassification()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphInferenceclassificationAllof1 ), _componentsSchemasMicrosoftGraphInferenceclassificationAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphInferenceclassificationAllof1 ), _componentsSchemasMicrosoftGraphInferenceclassificationAllof1 );
        }
    }
    public partial interface IMicrosoftGraphInferenceClassification : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationAllof1 {

    }
}