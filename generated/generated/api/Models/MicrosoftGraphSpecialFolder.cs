namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>specialFolder</summary>
    public partial class MicrosoftGraphSpecialFolder : Sample.API.Models.IMicrosoftGraphSpecialFolder
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
        /// <summary>Creates an new <see cref="MicrosoftGraphSpecialFolder" /> instance.</summary>
        public MicrosoftGraphSpecialFolder()
        {
        }
    }
    /// specialFolder
    public partial interface IMicrosoftGraphSpecialFolder : Sample.API.Runtime.IJsonSerializable {
        string Name { get; set; }
    }
}