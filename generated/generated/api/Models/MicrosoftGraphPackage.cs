namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>package</summary>
    public partial class MicrosoftGraphPackage : Sample.API.Models.IMicrosoftGraphPackage
    {
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
        /// <summary>Creates an new <see cref="MicrosoftGraphPackage" /> instance.</summary>
        public MicrosoftGraphPackage()
        {
        }
    }
    /// package
    public partial interface IMicrosoftGraphPackage : Sample.API.Runtime.IJsonSerializable {
        string Type { get; set; }
    }
}