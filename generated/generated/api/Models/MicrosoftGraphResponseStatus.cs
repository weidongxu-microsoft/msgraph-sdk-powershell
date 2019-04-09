namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>responseStatus</summary>
    public partial class MicrosoftGraphResponseStatus : Sample.API.Models.IMicrosoftGraphResponseStatus
    {
        /// <summary>Backing field for <see cref="Response" /> property.</summary>
        private string _response;

        /// <summary>responseType</summary>
        public string Response
        {
            get
            {
                return this._response;
            }
            set
            {
                this._response = value;
            }
        }
        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private System.DateTime? _time;

        public System.DateTime? Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphResponseStatus" /> instance.</summary>
        public MicrosoftGraphResponseStatus()
        {
        }
    }
    /// responseStatus
    public partial interface IMicrosoftGraphResponseStatus : Sample.API.Runtime.IJsonSerializable {
        string Response { get; set; }
        System.DateTime? Time { get; set; }
    }
}