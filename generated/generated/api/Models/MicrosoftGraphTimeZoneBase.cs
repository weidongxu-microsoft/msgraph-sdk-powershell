namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>timeZoneBase</summary>
    public partial class MicrosoftGraphTimeZoneBase : Sample.API.Models.IMicrosoftGraphTimeZoneBase
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
        /// <summary>Creates an new <see cref="MicrosoftGraphTimeZoneBase" /> instance.</summary>
        public MicrosoftGraphTimeZoneBase()
        {
        }
    }
    /// timeZoneBase
    public partial interface IMicrosoftGraphTimeZoneBase : Sample.API.Runtime.IJsonSerializable {
        string Name { get; set; }
    }
}