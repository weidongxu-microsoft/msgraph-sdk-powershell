namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>identity</summary>
    public partial class MicrosoftGraphIdentity : Sample.API.Models.IMicrosoftGraphIdentity
    {
        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphIdentity" /> instance.</summary>
        public MicrosoftGraphIdentity()
        {
        }
    }
    /// identity
    public partial interface IMicrosoftGraphIdentity : Sample.API.Runtime.IJsonSerializable {
        string DisplayName { get; set; }
        string Id { get; set; }
    }
}