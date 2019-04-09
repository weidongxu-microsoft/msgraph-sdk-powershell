namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>emailAddress</summary>
    public partial class MicrosoftGraphEmailAddress : Sample.API.Models.IMicrosoftGraphEmailAddress
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
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphEmailAddress" /> instance.</summary>
        public MicrosoftGraphEmailAddress()
        {
        }
    }
    /// emailAddress
    public partial interface IMicrosoftGraphEmailAddress : Sample.API.Runtime.IJsonSerializable {
        string Address { get; set; }
        string Name { get; set; }
    }
}