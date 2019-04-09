namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>internetMessageHeader</summary>
    public partial class MicrosoftGraphInternetMessageHeader : Sample.API.Models.IMicrosoftGraphInternetMessageHeader
    {
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
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="MicrosoftGraphInternetMessageHeader" /> instance.</summary>
        public MicrosoftGraphInternetMessageHeader()
        {
        }
    }
    /// internetMessageHeader
    public partial interface IMicrosoftGraphInternetMessageHeader : Sample.API.Runtime.IJsonSerializable {
        string Name { get; set; }
        string Value { get; set; }
    }
}