namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphCalendarGroup : Sample.API.Models.IMicrosoftGraphCalendarGroup, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphCalendarGroup" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendargroupAllof1 _componentsSchemasMicrosoftGraphCalendargroupAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphCalendargroupAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphCalendarGroup" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphCalendar[] Calendars
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendargroupAllof1 .Calendars;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendargroupAllof1 .Calendars = value;
            }
        }
        public string ChangeKey
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendargroupAllof1 .ChangeKey;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendargroupAllof1 .ChangeKey = value;
            }
        }
        public string ClassId
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendargroupAllof1 .ClassId;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendargroupAllof1 .ClassId = value;
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
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendargroupAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendargroupAllof1 .Name = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphCalendarGroup" /> instance.</summary>
        public MicrosoftGraphCalendarGroup()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphCalendargroupAllof1 ), _componentsSchemasMicrosoftGraphCalendargroupAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphCalendargroupAllof1 ), _componentsSchemasMicrosoftGraphCalendargroupAllof1 );
        }
    }
    public partial interface IMicrosoftGraphCalendarGroup : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendargroupAllof1 {

    }
}