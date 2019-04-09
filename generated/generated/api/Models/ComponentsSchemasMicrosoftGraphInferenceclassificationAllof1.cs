namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>inferenceClassification</summary>
    public partial class ComponentsSchemasMicrosoftGraphInferenceclassificationAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphInferenceclassificationAllof1
    {
        /// <summary>Backing field for <see cref="Overrides" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphInferenceClassificationOverride[] _overrides;

        public Sample.API.Models.IMicrosoftGraphInferenceClassificationOverride[] Overrides
        {
            get
            {
                return this._overrides;
            }
            set
            {
                this._overrides = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphInferenceclassificationAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphInferenceclassificationAllof1()
        {
        }
    }
    /// inferenceClassification
    public partial interface IComponentsSchemasMicrosoftGraphInferenceclassificationAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphInferenceClassificationOverride[] Overrides { get; set; }
    }
}