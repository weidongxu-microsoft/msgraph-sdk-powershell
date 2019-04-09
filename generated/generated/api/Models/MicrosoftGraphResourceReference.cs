namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>resourceReference</summary>
    public partial class MicrosoftGraphResourceReference : Sample.API.Models.IMicrosoftGraphResourceReference
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
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Backing field for <see cref="WebUrl" /> property.</summary>
        private string _webUrl;

        public string WebUrl
        {
            get
            {
                return this._webUrl;
            }
            set
            {
                this._webUrl = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphResourceReference" /> instance.</summary>
        public MicrosoftGraphResourceReference()
        {
        }
    }
    /// resourceReference
    public partial interface IMicrosoftGraphResourceReference : Sample.API.Runtime.IJsonSerializable {
        string Id { get; set; }
        string Type { get; set; }
        string WebUrl { get; set; }
    }
}