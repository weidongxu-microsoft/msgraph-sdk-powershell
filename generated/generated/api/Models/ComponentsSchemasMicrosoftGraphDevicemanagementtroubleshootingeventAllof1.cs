namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Event representing an general failure.</summary>
    public partial class ComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1
    {
        /// <summary>Backing field for <see cref="CorrelationId" /> property.</summary>
        private string _correlationId;

        /// <summary>Id used for tracing the failure in the service.</summary>
        public string CorrelationId
        {
            get
            {
                return this._correlationId;
            }
            set
            {
                this._correlationId = value;
            }
        }
        /// <summary>Backing field for <see cref="EventDateTime" /> property.</summary>
        private System.DateTime? _eventDateTime;

        /// <summary>Time when the event occurred .</summary>
        public System.DateTime? EventDateTime
        {
            get
            {
                return this._eventDateTime;
            }
            set
            {
                this._eventDateTime = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1()
        {
        }
    }
    /// Event representing an general failure.
    public partial interface IComponentsSchemasMicrosoftGraphDevicemanagementtroubleshootingeventAllof1 : Sample.API.Runtime.IJsonSerializable {
        string CorrelationId { get; set; }
        System.DateTime? EventDateTime { get; set; }
    }
}