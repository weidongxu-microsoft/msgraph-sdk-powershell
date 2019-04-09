namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDeviceCategory : Sample.API.Models.IMicrosoftGraphDeviceCategory, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphDeviceCategory" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecategoryAllof1 _componentsSchemasMicrosoftGraphDevicecategoryAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDevicecategoryAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphDeviceCategory" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>Optional description for the device category.</summary>
        public string Description
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecategoryAllof1 .Description;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecategoryAllof1 .Description = value;
            }
        }
        /// <summary>Display name for the device category.</summary>
        public string DisplayName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicecategoryAllof1 .DisplayName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicecategoryAllof1 .DisplayName = value;
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
        /// <summary>Creates an new <see cref="MicrosoftGraphDeviceCategory" /> instance.</summary>
        public MicrosoftGraphDeviceCategory()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDevicecategoryAllof1 ), _componentsSchemasMicrosoftGraphDevicecategoryAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDevicecategoryAllof1 ), _componentsSchemasMicrosoftGraphDevicecategoryAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDeviceCategory : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecategoryAllof1 {

    }
}