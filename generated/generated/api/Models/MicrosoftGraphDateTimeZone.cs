namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>dateTimeTimeZone</summary>
    public partial class MicrosoftGraphDateTimeZone : Sample.API.Models.IMicrosoftGraphDateTimeZone
    {
        /// <summary>Backing field for <see cref="DateTime" /> property.</summary>
        private string _dateTime;

        public string DateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                this._dateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        public string TimeZone
        {
            get
            {
                return this._timeZone;
            }
            set
            {
                this._timeZone = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDateTimeZone" /> instance.</summary>
        public MicrosoftGraphDateTimeZone()
        {
        }
    }
    /// dateTimeTimeZone
    public partial interface IMicrosoftGraphDateTimeZone : Sample.API.Runtime.IJsonSerializable {
        string DateTime { get; set; }
        string TimeZone { get; set; }
    }
}