namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphMultiValueLegacyExtendedProperty : Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphMultiValueLegacyExtendedProperty" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 _componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphMultiValueLegacyExtendedProperty" />
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
        public string[] Value
        {
            get
            {
                return _componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 .Value;
            }
            set
            {
                _componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 .Value = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphMultiValueLegacyExtendedProperty" /> instance.
        /// </summary>
        public MicrosoftGraphMultiValueLegacyExtendedProperty()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 ), _componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 ), _componentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 );
        }
    }
    public partial interface IMicrosoftGraphMultiValueLegacyExtendedProperty : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphMultivaluelegacyextendedpropertyAllof1 {

    }
}