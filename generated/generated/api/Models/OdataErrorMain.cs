namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class OdataErrorMain : Sample.API.Models.IOdataErrorMain
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
        /// <summary>Backing field for <see cref="Details" /> property.</summary>
        private Sample.API.Models.IOdataErrorDetail[] _details;

        public Sample.API.Models.IOdataErrorDetail[] Details
        {
            get
            {
                return this._details;
            }
            set
            {
                this._details = value;
            }
        }
        /// <summary>Backing field for <see cref="Innererror" /> property.</summary>
        private Sample.API.Models.IOdataErrorMainInnererror _innererror;

        /// <summary>The structure of this object is service-specific</summary>
        public Sample.API.Models.IOdataErrorMainInnererror Innererror
        {
            get
            {
                return this._innererror;
            }
            set
            {
                this._innererror = value;
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
        /// <summary>Creates an new <see cref="OdataErrorMain" /> instance.</summary>
        public OdataErrorMain()
        {
        }
    }
    public partial interface IOdataErrorMain : Sample.API.Runtime.IJsonSerializable {
        string Code { get; set; }
        Sample.API.Models.IOdataErrorDetail[] Details { get; set; }
        Sample.API.Models.IOdataErrorMainInnererror Innererror { get; set; }
        string Message { get; set; }
        string Target { get; set; }
    }
}