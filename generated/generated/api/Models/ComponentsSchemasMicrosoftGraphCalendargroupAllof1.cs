namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>calendarGroup</summary>
    public partial class ComponentsSchemasMicrosoftGraphCalendargroupAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphCalendargroupAllof1
    {
        /// <summary>Backing field for <see cref="Calendars" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphCalendar[] _calendars;

        public Sample.API.Models.IMicrosoftGraphCalendar[] Calendars
        {
            get
            {
                return this._calendars;
            }
            set
            {
                this._calendars = value;
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
        /// <summary>Backing field for <see cref="ClassId" /> property.</summary>
        private string _classId;

        public string ClassId
        {
            get
            {
                return this._classId;
            }
            set
            {
                this._classId = value;
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
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphCalendargroupAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphCalendargroupAllof1()
        {
        }
    }
    /// calendarGroup
    public partial interface IComponentsSchemasMicrosoftGraphCalendargroupAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphCalendar[] Calendars { get; set; }
        string ChangeKey { get; set; }
        string ClassId { get; set; }
        string Name { get; set; }
    }
}