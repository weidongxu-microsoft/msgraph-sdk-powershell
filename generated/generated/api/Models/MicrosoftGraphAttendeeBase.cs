namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphAttendeeBase : Sample.API.Models.IMicrosoftGraphAttendeeBase, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphAttendeeBase" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphAttendeebaseAllof1 _componentsSchemasMicrosoftGraphAttendeebaseAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphAttendeebaseAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphAttendeeBase" /></summary>
        private Sample.API.Models.IMicrosoftGraphRecipient _microsoftGraphRecipient = new Sample.API.Models.MicrosoftGraphRecipient ();
        public string AddressEmailAddress
        {
            get
            {
                return _microsoftGraphRecipient .AddressEmailAddress;
            }
            set
            {
                _microsoftGraphRecipient .AddressEmailAddress = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress EmailAddress
        {
            get
            {
                return _microsoftGraphRecipient .EmailAddress;
            }
            set
            {
                _microsoftGraphRecipient .EmailAddress = value;
            }
        }
        public string EmailAddressName
        {
            get
            {
                return _microsoftGraphRecipient .EmailAddressName;
            }
            set
            {
                _microsoftGraphRecipient .EmailAddressName = value;
            }
        }
        /// <summary>attendeeType</summary>
        public string Type
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttendeebaseAllof1 .Type;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttendeebaseAllof1 .Type = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAttendeeBase" /> instance.</summary>
        public MicrosoftGraphAttendeeBase()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphRecipient ), _microsoftGraphRecipient );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphRecipient ), _microsoftGraphRecipient );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphAttendeebaseAllof1 ), _componentsSchemasMicrosoftGraphAttendeebaseAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphAttendeebaseAllof1 ), _componentsSchemasMicrosoftGraphAttendeebaseAllof1 );
        }
    }
    public partial interface IMicrosoftGraphAttendeeBase : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphRecipient, Sample.API.Models.IComponentsSchemasMicrosoftGraphAttendeebaseAllof1 {

    }
}