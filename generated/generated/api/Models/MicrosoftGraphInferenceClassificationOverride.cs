namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphInferenceClassificationOverride : Sample.API.Models.IMicrosoftGraphInferenceClassificationOverride, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphInferenceClassificationOverride" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphInferenceClassificationOverride" />
        /// </summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public string AddressSenderEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .AddressSenderEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .AddressSenderEmailAddress = value;
            }
        }
        /// <summary>inferenceClassificationType</summary>
        public string ClassifyAs
        {
            get
            {
                return _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .ClassifyAs;
            }
            set
            {
                _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .ClassifyAs = value;
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
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress SenderEmailAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .SenderEmailAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .SenderEmailAddress = value;
            }
        }
        public string SenderEmailAddressName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .SenderEmailAddressName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 .SenderEmailAddressName = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphInferenceClassificationOverride" /> instance.
        /// </summary>
        public MicrosoftGraphInferenceClassificationOverride()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 ), _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 ), _componentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 );
        }
    }
    public partial interface IMicrosoftGraphInferenceClassificationOverride : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationoverrideAllof1 {

    }
}