namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class MicrosoftGraphCalendar : Sample.API.Models.IMicrosoftGraphCalendar, Sample.API.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref= "MicrosoftGraphCalendar" /></summary>
        private Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendarAllof1 _componentsSchemasMicrosoftGraphCalendarAllof1 = new Sample.API.Models.ComponentsSchemasMicrosoftGraphCalendarAllof1 ();
        /// <summary>Backing field for <see cref= "MicrosoftGraphCalendar" /></summary>
        private Sample.API.Models.IMicrosoftGraphEntity _microsoftGraphEntity = new Sample.API.Models.MicrosoftGraphEntity ();
        public Sample.API.Models.IMicrosoftGraphEvent[] CalendarView
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .CalendarView;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .CalendarView = value;
            }
        }
        public bool? CanEdit
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .CanEdit;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .CanEdit = value;
            }
        }
        public bool? CanShare
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .CanShare;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .CanShare = value;
            }
        }
        public bool? CanViewPrivateItems
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .CanViewPrivateItems;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .CanViewPrivateItems = value;
            }
        }
        public string ChangeKey
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .ChangeKey;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .ChangeKey = value;
            }
        }
        /// <summary>calendarColor</summary>
        public string Color
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .Color;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .Color = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphEvent[] Events
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .Events;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .Events = value;
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
        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .MultiValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .MultiValueExtendedProperties = value;
            }
        }
        public string Name
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .Name;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .Name = value;
            }
        }
        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress Owner
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .Owner;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .Owner = value;
            }
        }
        public string OwnerAddress
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .OwnerAddress;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .OwnerAddress = value;
            }
        }
        public string OwnerName
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .OwnerName;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .OwnerName = value;
            }
        }
        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return _componentsSchemasMicrosoftGraphCalendarAllof1 .SingleValueExtendedProperties;
            }
            set
            {
                _componentsSchemasMicrosoftGraphCalendarAllof1 .SingleValueExtendedProperties = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphCalendar" /> instance.</summary>
        public MicrosoftGraphCalendar()
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
            await eventListener.AssertNotNull(nameof(_componentsSchemasMicrosoftGraphCalendarAllof1 ), _componentsSchemasMicrosoftGraphCalendarAllof1 );
            await eventListener.AssertObjectIsValid(nameof(_componentsSchemasMicrosoftGraphCalendarAllof1 ), _componentsSchemasMicrosoftGraphCalendarAllof1 );
        }
    }
    public partial interface IMicrosoftGraphCalendar : Sample.API.Runtime.IJsonSerializable, Sample.API.Models.IMicrosoftGraphEntity, Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendarAllof1 {

    }
}