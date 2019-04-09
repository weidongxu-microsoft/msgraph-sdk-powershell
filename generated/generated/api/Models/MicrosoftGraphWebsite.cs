namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>website</summary>
    public partial class MicrosoftGraphWebsite : Sample.API.Models.IMicrosoftGraphWebsite
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
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>websiteType</summary>
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
        /// <summary>Creates an new <see cref="MicrosoftGraphWebsite" /> instance.</summary>
        public MicrosoftGraphWebsite()
        {
        }
    }
    /// website
    public partial interface IMicrosoftGraphWebsite : Sample.API.Runtime.IJsonSerializable {
        string Address { get; set; }
        string DisplayName { get; set; }
        string Type { get; set; }
    }
}