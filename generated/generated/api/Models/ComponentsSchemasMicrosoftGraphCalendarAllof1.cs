namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>calendar</summary>
    public partial class ComponentsSchemasMicrosoftGraphCalendarAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendarAllof1
    {
        /// <summary>Backing field for <see cref="CalendarView" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEvent[] _calendarView;

        public Sample.API.Models.IMicrosoftGraphEvent[] CalendarView
        {
            get
            {
                return this._calendarView;
            }
            set
            {
                this._calendarView = value;
            }
        }
        /// <summary>Backing field for <see cref="CanEdit" /> property.</summary>
        private bool? _canEdit;

        public bool? CanEdit
        {
            get
            {
                return this._canEdit;
            }
            set
            {
                this._canEdit = value;
            }
        }
        /// <summary>Backing field for <see cref="CanShare" /> property.</summary>
        private bool? _canShare;

        public bool? CanShare
        {
            get
            {
                return this._canShare;
            }
            set
            {
                this._canShare = value;
            }
        }
        /// <summary>Backing field for <see cref="CanViewPrivateItems" /> property.</summary>
        private bool? _canViewPrivateItems;

        public bool? CanViewPrivateItems
        {
            get
            {
                return this._canViewPrivateItems;
            }
            set
            {
                this._canViewPrivateItems = value;
            }
        }
        /// <summary>Backing field for <see cref="ChangeKey" /> property.</summary>
        private string _changeKey;

        public string ChangeKey
        {
            get
            {
                return this._changeKey;
            }
            set
            {
                this._changeKey = value;
            }
        }
        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

        /// <summary>calendarColor</summary>
        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        /// <summary>Backing field for <see cref="Events" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEvent[] _events;

        public Sample.API.Models.IMicrosoftGraphEvent[] Events
        {
            get
            {
                return this._events;
            }
            set
            {
                this._events = value;
            }
        }
        /// <summary>Backing field for <see cref="MultiValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] _multiValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties
        {
            get
            {
                return this._multiValueExtendedProperties;
            }
            set
            {
                this._multiValueExtendedProperties = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphEmailAddress _owner;

        /// <summary>emailAddress</summary>
        public Sample.API.Models.IMicrosoftGraphEmailAddress Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        public string OwnerAddress
        {
            get
            {
                return /*1*/Owner/*4*/.Address/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.Address/*3*/ = value;
            }
        }
        public string OwnerName
        {
            get
            {
                return /*1*/Owner/*4*/.Name/*3*/;
            }
            set
            {
                /*1*/Owner/*4*/.Name/*3*/ = value;
            }
        }
        /// <summary>Backing field for <see cref="SingleValueExtendedProperties" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] _singleValueExtendedProperties;

        public Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties
        {
            get
            {
                return this._singleValueExtendedProperties;
            }
            set
            {
                this._singleValueExtendedProperties = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphCalendarAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphCalendarAllof1()
        {
        }
    }
    /// calendar
    public partial interface IComponentsSchemasMicrosoftGraphCalendarAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphEvent[] CalendarView { get; set; }
        bool? CanEdit { get; set; }
        bool? CanShare { get; set; }
        bool? CanViewPrivateItems { get; set; }
        string ChangeKey { get; set; }
        string Color { get; set; }
        Sample.API.Models.IMicrosoftGraphEvent[] Events { get; set; }
        Sample.API.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[] MultiValueExtendedProperties { get; set; }
        string Name { get; set; }
        Sample.API.Models.IMicrosoftGraphEmailAddress Owner { get; set; }
        string OwnerAddress { get; set; }
        string OwnerName { get; set; }
        Sample.API.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[] SingleValueExtendedProperties { get; set; }
    }
}