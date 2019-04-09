namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class OdataErrorDetail : Sample.API.Models.IOdataErrorDetail
    {
        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }
        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        public string Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
        /// <summary>Creates an new <see cref="OdataErrorDetail" /> instance.</summary>
        public OdataErrorDetail()
        {
        }
    }
    public partial interface IOdataErrorDetail : Sample.API.Runtime.IJsonSerializable {
        string Code { get; set; }
        string Message { get; set; }
        string Target { get; set; }
    }
}