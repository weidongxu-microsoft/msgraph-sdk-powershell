namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphSingleValueLegacyExtendedProperty : Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphSingleValueLegacyExtendedProperty" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 _componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphSingleValueLegacyExtendedProperty" />
        /// </summary>
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
        public string Value
        {
            get
            {
                return _componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 .Value;
            }
            set
            {
                _componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 .Value = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphSingleValueLegacyExtendedProperty" /> instance.
        /// </summary>
        public MicrosoftGraphSingleValueLegacyExtendedProperty()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 ), _componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 ), _componentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 );
        }
    }
    public partial interface IMicrosoftGraphSingleValueLegacyExtendedProperty : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphSinglevaluelegacyextendedpropertyAllof1 {

    }
}