namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>attendee</summary>
    public partial class ComponentsSchemasMicrosoftGraphAttendeeAllof1 : Sample.API.Models.IComponentsSchemasMicrosoftGraphAttendeeAllof1
    {
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Sample.API.Models.IMicrosoftGraphResponseStatus _status;

        /// <summary>responseStatus</summary>
        public Sample.API.Models.IMicrosoftGraphResponseStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>responseType</summary>
        public string StatusResponse
        {
            get
            {
                return /*1*/Status/*4*/.Response/*3*/;
            }
            set
            {
                /*1*/Status/*4*/.Response/*3*/ = value;
            }
        }
        public System.DateTime? StatusTime
        {
            get
            {
                return /*1*/Status/*4*/.Time/*3*/;
            }
            set
            {
                /*1*/Status/*4*/.Time/*3*/ = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasMicrosoftGraphAttendeeAllof1" /> instance.
        /// </summary>
        public ComponentsSchemasMicrosoftGraphAttendeeAllof1()
        {
        }
    }
    /// attendee
    public partial interface IComponentsSchemasMicrosoftGraphAttendeeAllof1 : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IMicrosoftGraphResponseStatus Status { get; set; }
        string StatusResponse { get; set; }
        System.DateTime? StatusTime { get; set; }
    }
}