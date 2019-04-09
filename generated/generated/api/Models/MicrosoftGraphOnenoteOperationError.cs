namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>onenoteOperationError</summary>
    public partial class MicrosoftGraphOnenoteOperationError : Sample.API.Models.IMicrosoftGraphOnenoteOperationError
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
        /// <summary>Creates an new <see cref="MicrosoftGraphOnenoteOperationError" /> instance.</summary>
        public MicrosoftGraphOnenoteOperationError()
        {
        }
    }
    /// onenoteOperationError
    public partial interface IMicrosoftGraphOnenoteOperationError : Sample.API.Runtime.IJsonSerializable {
        string Code { get; set; }
        string Message { get; set; }
    }
}