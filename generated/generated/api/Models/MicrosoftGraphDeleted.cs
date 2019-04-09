namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>deleted</summary>
    public partial class MicrosoftGraphDeleted : Sample.API.Models.IMicrosoftGraphDeleted
    {
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphDeleted" /> instance.</summary>
        public MicrosoftGraphDeleted()
        {
        }
    }
    /// deleted
    public partial interface IMicrosoftGraphDeleted : Sample.API.Runtime.IJsonSerializable {
        string State { get; set; }
    }
}