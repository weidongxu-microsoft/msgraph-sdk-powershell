namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>entity</summary>
    public partial class MicrosoftGraphEntity : Sample.API.Models.IMicrosoftGraphEntity
    {
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
        /// <summary>Creates an new <see cref="MicrosoftGraphEntity" /> instance.</summary>
        public MicrosoftGraphEntity()
        {
        }
    }
    /// entity
    public partial interface IMicrosoftGraphEntity : Sample.API.Runtime.IJsonSerializable {
        string Id { get; set; }
    }
}