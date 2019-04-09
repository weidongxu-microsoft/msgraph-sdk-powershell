namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>insightIdentity</summary>
    public partial class MicrosoftGraphInsightIdentity : Sample.API.Models.IMicrosoftGraphInsightIdentity
    {
        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
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
        /// <summary>Creates an new <see cref="MicrosoftGraphInsightIdentity" /> instance.</summary>
        public MicrosoftGraphInsightIdentity()
        {
        }
    }
    /// insightIdentity
    public partial interface IMicrosoftGraphInsightIdentity : Sample.API.Runtime.IJsonSerializable {
        string Address { get; set; }
        string DisplayName { get; set; }
        string Id { get; set; }
    }
}