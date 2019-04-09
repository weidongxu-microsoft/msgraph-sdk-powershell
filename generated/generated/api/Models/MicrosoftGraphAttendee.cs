namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphAttendee : Sample.API.Models.IMicrosoftGraphAttendee, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphAttendee" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphAttendeeAllof1 _componentsSchemasMicrosoftGraphAttendeeAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphAttendeeAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphAttendee" /></summary>
        private Sample.API.Models.IMicrosoftGraphAttendeeBase _microsoftGraphAttendeeBase = new Sample.API.Models.MicrosoftGraphAttendeeBase ();
        public string AddressEmailAddress
        {
            get
            {
                return _microsoftGraphAttendeeBase .AddressEmailAddress;
            }
            set
            {
                _microsoftGraphAttendeeBase .AddressEmailAddress = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress EmailAddress
        {
            get
            {
                return _microsoftGraphAttendeeBase .EmailAddress;
            }
            set
            {
                _microsoftGraphAttendeeBase .EmailAddress = value;
            }
        }
        public string EmailAddressName
        {
            get
            {
                return _microsoftGraphAttendeeBase .EmailAddressName;
            }
            set
            {
                _microsoftGraphAttendeeBase .EmailAddressName = value;
            }
        }
        /// <summary>responseStatus</summary>
        public Sample.API.Models.IMicrosoftGraphResponseStatus Status
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttendeeAllof1 .Status;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttendeeAllof1 .Status = value;
            }
        }
        /// <summary>responseType</summary>
        public string StatusResponse
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttendeeAllof1 .StatusResponse;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttendeeAllof1 .StatusResponse = value;
            }
        }
        public System.DateTime? StatusTime
        {
            get
            {
                return _componentsSchemasMicrosoftGraphAttendeeAllof1 .StatusTime;
            }
            set
            {
                _componentsSchemasMicrosoftGraphAttendeeAllof1 .StatusTime = value;
            }
        }
        /// <summary>attendeeType</summary>
        public string Type
        {
            get
            {
                return _microsoftGraphAttendeeBase .Type;
            }
            set
            {
                _microsoftGraphAttendeeBase .Type = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphAttendee" /> instance.</summary>
        public MicrosoftGraphAttendee()
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
            await eventListener.AssertNotNull(nameof(_microsoftGraphAttendeeBase ), _microsoftGraphAttendeeBase );
            await eventListener.AssertObjectIsValid(nameof(_microsoftGraphAttendeeBase ), _microsoftGraphAttendeeBase );
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphAttendeeAllof1 ), _componentsSchemasMicrosoftGraphAttendeeAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphAttendeeAllof1 ), _componentsSchemasMicrosoftGraphAttendeeAllof1 );
        }
    }
    public partial interface IMicrosoftGraphAttendee : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphAttendeeBase, Sample.API.Models.IComponentsSchemasMicrosoftGraphAttendeeAllof1 {

    }
}