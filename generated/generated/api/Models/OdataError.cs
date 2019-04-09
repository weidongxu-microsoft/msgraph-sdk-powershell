namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class OdataError : Sample.API.Models.IOdataError
    {
        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Sample.API.Models.IOdataErrorMain _error;

        public Sample.API.Models.IOdataErrorMain Error
        {
            get
            {
                return this._error;
            }
            set
            {
                this._error = value;
            }
        }
        public string ErrorCode
        {
            get
            {
                return /*1*/Error/*4*/.Code/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Code/*3*/ = value;
            }
        }
        public Sample.API.Models.IOdataErrorDetail[] ErrorDetails
        {
            get
            {
                return /*1*/Error/*4*/.Details/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Details/*3*/ = value;
            }
        }
        /// <summary>The structure of this object is service-specific</summary>
        public Sample.API.Models.IOdataErrorMainInnererror ErrorInnererror
        {
            get
            {
                return /*1*/Error/*4*/.Innererror/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Innererror/*3*/ = value;
            }
        }
        public string ErrorMessage
        {
            get
            {
                return /*1*/Error/*4*/.Message/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Message/*3*/ = value;
            }
        }
        public string ErrorTarget
        {
            get
            {
                return /*1*/Error/*4*/.Target/*3*/;
            }
            set
            {
                /*1*/Error/*4*/.Target/*3*/ = value;
            }
        }
        /// <summary>Creates an new <see cref="OdataError" /> instance.</summary>
        public OdataError()
        {
        }
    }
    public partial interface IOdataError : Sample.API.Runtime.IJsonSerializable {
        Sample.API.Models.IOdataErrorMain Error { get; set; }
        string ErrorCode { get; set; }
        Sample.API.Models.IOdataErrorDetail[] ErrorDetails { get; set; }
        Sample.API.Models.IOdataErrorMainInnererror ErrorInnererror { get; set; }
        string ErrorMessage { get; set; }
        string ErrorTarget { get; set; }
    }
}