namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphDeviceManagementTroubleshootingEvent : Sample.API.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent, Sample.API.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphDeviceManagementTroubleshootingEvent" />
        /// </summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 ();
        /// <summary>
        /// Backing field for <see cref= "MicrosoftGraphDeviceManagementTroubleshootingEvent" />
        /// </summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        /// <summary>Id used for tracing the failure in the service.</summary>
        public string CorrelationId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 .CorrelationId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 .CorrelationId = value;
            }
        }
        /// <summary>Time when the event occurred .</summary>
        public System.DateTime? EventDateTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 .EventDateTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 .EventDateTime = value;
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
        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphDeviceManagementTroubleshootingEvent" /> instance.
        /// </summary>
        public MicrosoftGraphDeviceManagementTroubleshootingEvent()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 ), _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 ), _componentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 );
        }
    }
    public partial interface IMicrosoftGraphDeviceManagementTroubleshootingEvent : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 {

    }
}