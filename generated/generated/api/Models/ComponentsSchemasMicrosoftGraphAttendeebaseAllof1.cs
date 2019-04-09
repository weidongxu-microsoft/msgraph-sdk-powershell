namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>attendeeBase</summary>
    public partial class ComponentsSchemasMicrosoftGraphAttendeebaseAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphAttendeebaseAllof1
    {
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>attendeeType</summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphAttendeebaseAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphAttendeebaseAllof1()
        {
        }
    }
    /// attendeeBase
    public partial interface IComponentsSchemasMicrosoftGraphAttendeebaseAllof1 : Sample.API.Runtime.IJsonSerializable {
        string Type { get; set; }
    }
}