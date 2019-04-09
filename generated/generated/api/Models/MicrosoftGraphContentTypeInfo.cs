namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>contentTypeInfo</summary>
    public partial class MicrosoftGraphContentTypeInfo : Sample.API.Models.IMicrosoftGraphContentTypeInfo
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
        /// <summary>Creates an new <see cref="MicrosoftGraphContentTypeInfo" /> instance.</summary>
        public MicrosoftGraphContentTypeInfo()
        {
        }
    }
    /// contentTypeInfo
    public partial interface IMicrosoftGraphContentTypeInfo : Sample.API.Runtime.IJsonSerializable {
        string Id { get; set; }
    }
}